using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RedditEmblemPlayerPortal.Data;

namespace RedditEmblemPlayerPortal.Pages.Account
{
  public class ExternalLoginModel : PageModel
  {
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ILogger<ExternalLoginModel> _logger;

    //Discord Claim Types
    private const string DiscordUserId = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier";
    private const string DiscordUsername = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";
    private const string DiscordDiscriminator = "urn:discord:discriminator";
    private const string DiscordAvatar = "urn:discord:avatar";

    public ExternalLoginModel(
        SignInManager<ApplicationUser> signInManager,
        UserManager<ApplicationUser> userManager,
        ILogger<ExternalLoginModel> logger)
    {
      _signInManager = signInManager;
      _userManager = userManager;
      _logger = logger;
    }

    [TempData]
    public string ErrorMessage { get; set; }

    public IActionResult OnGetAsync()
    {
      // Request a redirect to the external login provider.
      const string provider = "Discord";
      const string returnUrl = "";
      var redirectUrl = Url.Page("./ExternalLogin", pageHandler: "Callback", values: new { returnUrl });
      var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
      return new ChallengeResult(provider, properties);
    }

    public async Task<IActionResult> OnGetCallbackAsync(string returnUrl = null, string remoteError = null)
    {
      if (remoteError != null)
      {
        ErrorMessage = $"Error from external provider: {remoteError}";
        return RedirectToPage("../Index");
      }
      var info = await _signInManager.GetExternalLoginInfoAsync();
      if (info == null)
      {
        return RedirectToPage("../Index");
      }

      // Sign in the user with this external login provider if the user already has a login.
      var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
      if (result.Succeeded)
      {
        _logger.LogInformation("{Name} logged in with {LoginProvider} provider.", info.Principal.Identity.Name, info.LoginProvider);
        return RedirectToPage("../Angular");
      }
      if (result.IsLockedOut)
      {
        return RedirectToPage("./Lockout");
      }
      else
      {
        // If the user does not have an account, then ask the user to create an account.
        var user = new ApplicationUser
        {
          UserName = info.Principal.Claims.First(x => x.Type.Equals(DiscordUserId)).Value,
          DiscordUsername = info.Principal.Claims.First(x => x.Type.Equals(DiscordUsername)).Value,
          DiscordAvatar = info.Principal.Claims.First(x => x.Type.Equals(DiscordAvatar)).Value
        };

        var userResult = await _userManager.CreateAsync(user);
        if (userResult.Succeeded)
        {
          userResult = await _userManager.AddLoginAsync(user, info);
          if (userResult.Succeeded)
          {
            await _signInManager.SignInAsync(user, isPersistent: false);
            _logger.LogInformation("User created an account using {Name} provider.", info.LoginProvider);
            return RedirectToPage("../Angular");
          }
        }

        foreach (var error in userResult.Errors)
        {
          ModelState.AddModelError(string.Empty, error.Description);
        }
        return RedirectToPage("../Index");
      }
    }
  }
}
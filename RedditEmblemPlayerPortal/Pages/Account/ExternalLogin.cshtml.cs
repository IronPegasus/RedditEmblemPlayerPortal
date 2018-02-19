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
        await _signInManager.UpdateExternalAuthenticationTokensAsync(info);
        _logger.LogInformation("{Name} logged in with {LoginProvider} provider.", info.Principal.Identity.Name, info.LoginProvider);
        return RedirectToPage("../Index");
      }
      if (result.IsLockedOut)
      {
        return RedirectToPage("./Lockout");
      }
      else
      {
        // If the user does not have an account, then create one
        var user = new ApplicationUser
        {
          UserName = info.Principal.Claims.First(x => x.Type.Equals(Constants.DiscordUserId)).Value
        };

        if (!DiscordQuery.IsUserREMember(user.UserName))
          return RedirectToPage("../LoginFailure");

        var userResult = await _userManager.CreateAsync(user);
        if (userResult.Succeeded)
        {
          userResult = await _userManager.AddLoginAsync(user, info);
          if (userResult.Succeeded)
          {
            await _signInManager.SignInAsync(user, isPersistent: false);
            await _signInManager.UpdateExternalAuthenticationTokensAsync(info);

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
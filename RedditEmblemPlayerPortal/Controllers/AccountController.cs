using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RedditEmblemPlayerPortal.Data;

namespace RedditEmblemPlayerPortal.Controllers
{
  [Route("[controller]/[action]")]
  public class AccountController : Controller
  {
    private readonly SignInManager<DiscordUserToken> _signInManager;
    private readonly ILogger _logger;

    public AccountController(SignInManager<DiscordUserToken> signInManager, ILogger<AccountController> logger)
    {
      _signInManager = signInManager;
      _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> DiscordCallback()
    {
      return RedirectToPage("/Index");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
      await _signInManager.SignOutAsync();
      _logger.LogInformation("User logged out.");
      return RedirectToPage("/Index");
    }
  }
}
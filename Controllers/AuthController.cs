using System.Security.Claims;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using tourneyapp.Models;
using tourneyapp.Repositories;

namespace tourneyapp.Controllers;
public class AuthController : Controller
{
    private readonly IUserRepository _userRepository;
    public AuthController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    // 
    // GET: /demo/
    public IActionResult Index()
    {
        return RedirectToAction("Login"); 
    }

    public IActionResult Login()
    {
        ViewData["returnUrl"] = Request.Query["returnUrl"];
    
        return View("login");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Authenticate(string email, string password, string returnUrl)
    {
        try
        {
            var user = await _userRepository.Authenticate(email, password);

            this.SignInUser(user);

            return Redirect(returnUrl ?? Url.Action("Index", "Home") ?? "/");
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View("login");
        }
    }

    public IActionResult Register()
    {
        return View("register");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> RegisterNewAccount(User userModel, string confirmPassword)
    {
        try
        {
            if(!ModelState.IsValid)
            {
               return View(userModel); 
            }
    
            await _userRepository.Create(userModel, confirmPassword);
            return RedirectToAction("Index");
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View(userModel);
        }
    }

    // 
    // GET: /demo/WelcomeWithParameters/ 
    public string WelcomeWithParameters(string name, int count)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, number of times: {count}");
    }

    private async void SignInUser(User user)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.Email),
        };

        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        var principal = new ClaimsPrincipal(identity);

        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
    }
}
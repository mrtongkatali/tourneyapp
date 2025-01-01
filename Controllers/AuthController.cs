using System.Text.Encodings.Web;
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
        return View("login");
    }

    public IActionResult Login()
    {
        return View("login");
    }
    
    public IActionResult Register()
    {
        return View("register");
    }

    [HttpPost]
    public async Task<IActionResult> Register(User userModel, string confirmPassword)
    {
        // if (ModelState.IsValid)
        // {
        //     return RedirectToAction("Index");
        // }

        try
        {
            await _userRepository.Create(userModel, confirmPassword);
            return RedirectToAction("Index");
        }
        catch (Exception ex)
        {
            // ModelState.AddModelError("Password", "Password and Confirm Password do not match.");
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
}
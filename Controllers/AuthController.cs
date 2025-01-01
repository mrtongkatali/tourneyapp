using System.Diagnostics;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using tourneyapp.Data;
using tourneyapp.Models;

namespace tourneyapp.Controllers;
public class AuthController : Controller
{
    private readonly ApplicationDbContext _context;
    public AuthController(ApplicationDbContext context)
    {
        _context = context;
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
    public IActionResult Register(User userModel, string confirmPassword)
    {
        // if (ModelState.IsValid)
        // {
        //     return RedirectToAction("Index");
        // }

        ModelState.AddModelError("Password", "Password and Confirm Password do not match.");

        return View(userModel);
    }

    // 
    // GET: /demo/WelcomeWithParameters/ 
    public string WelcomeWithParameters(string name, int count)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, number of times: {count}");
    }
}
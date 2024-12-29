using System.Diagnostics;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using tourneyapp.Data;
using tourneyapp.Models;

namespace tourneyapp.Controllers;
public class AuthController : Controller
{
    private readonly ApplicationContext _context;
    public AuthController(ApplicationContext context)
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
        return View();
    }

    // 
    // GET: /demo/WelcomeWithParameters/ 
    public string WelcomeWithParameters(string name, int count)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, number of times: {count}");
    }
}
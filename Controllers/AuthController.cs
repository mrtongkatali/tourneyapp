using System.Diagnostics;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using tourneyapp.Data;

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

    // 
    // GET: /demo/WelcomeWithParameters/ 
    public string WelcomeWithParameters(string name, int count)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, number of times: {count}");
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using tourneyapp.Models;

namespace tourneyapp.Controllers;

// [Authorize]
public class ErrorController : Controller
{
    private readonly ILogger<ErrorController> _logger;

    public ErrorController(ILogger<ErrorController> logger)
    {
        _logger = logger;
    }

    [Route("401")]
    public IActionResult UnauthorizedAccess()
    {
        return View("401");
    }

    [Route("403")]
    public IActionResult ForbiddenAccess()
    {
        return View("403");
    }

    [Route("404")]
    public IActionResult PageNotFound()
    {
        return View("404");
    } 
}

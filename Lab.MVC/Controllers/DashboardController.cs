using Lab.DataAccess.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace Lab.MVC.Controllers;

public class DashboardController : Controller
{
    private readonly LabDbContext _context;

    public DashboardController(LabDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        _context.Employees
        return View();
    }

    public IActionResult Employees()
    {
        return View();
    }
}

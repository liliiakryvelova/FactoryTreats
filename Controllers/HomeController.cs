using Microsoft.AspNetCore.Mvc;
using FactoryTreats.Models;
using System.Linq;

namespace FactoryTreats.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryTreatsContext _db;

    public HomeController(FactoryTreatsContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View(_db.TreatFlavor.ToList());
    }

  }
}
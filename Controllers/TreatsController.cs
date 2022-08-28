using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FactoryTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;


namespace FactoryTreats.Controllers
{

  public class TreatsController : Controller
  {
    private readonly FactoryTreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public TreatsController(UserManager<ApplicationUser> userManager, FactoryTreatsContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Index()
    {
        var userTreats = _db.Treats.ToList();
        return View(userTreats);
    }

    public ActionResult Details(int id)
      {
          var thisTreat = _db.Treats
              .Include(treat => treat.JoinEntities)
              .ThenInclude(join => join.Flavor)
              .FirstOrDefault(treat => treat.TreatId == id);
          return View(thisTreat);
      }

      [Authorize]
      public ActionResult Edit(int id)
      {
          var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
          ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
          return View(thisTreat);
      }

      [Authorize]
      [HttpPost]
      public ActionResult Edit(Treat treat)
      {
          _db.Entry(treat).State = EntityState.Modified;
          _db.SaveChanges();
          return RedirectToAction("Index");
      }

      [Authorize]
      [HttpPost]
      public ActionResult Edit(Treat treat, int FlavorId)
      {
        if (FlavorId != 0)
        {
          _db.TreatFlavor.Add(new TreatFlavor() { FlavorId = FlavorId, TreatId = treat.TreatId });
        }
        _db.Entry(treat).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Index");
      }

      [Authorize]
      public ActionResult AddFlavor(int id)
      {
          var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
          ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "FlavorName");
          return View(thisTreat);
      }

      [Authorize]
      [HttpPost]
      public ActionResult AddFlavor(Treat treat, int FlavorId)
      {
          if (FlavorId != 0)
          {
            _db.TreatFlavor.Add(new TreatFlavor() { FlavorId = FlavorId, TreatId = treat.TreatId });
            _db.SaveChanges();
          }
          return RedirectToAction("Index");
      }

      [Authorize]
      [HttpPost]
      public ActionResult DeleteFlavor(int joinId)
      {
          var joinEntry = _db.TreatFlavor.FirstOrDefault(entry => entry.TreatFlavorId == joinId);
          _db.TreatFlavor.Remove(joinEntry);
          _db.SaveChanges();
          return RedirectToAction("Index");
      }

      [Authorize]
      public ActionResult Delete(int id)
      {
          var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
          return View(thisTreat);
      }

      [Authorize]
      [HttpPost, ActionName("Delete")]
      public ActionResult DeleteConfirmed(int id)
      {
          var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
          _db.Treats.Remove(thisTreat);
          _db.SaveChanges();
          return RedirectToAction("Index");
      }

    [Authorize]
    public ActionResult Create()
    {
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "FlavorName");
      return View();
    }

    [Authorize]
    [HttpPost]
    public async Task<ActionResult> Create(Treat treat, int FlavorId)
    {
        var thisTreatName = _db.Treats.FirstOrDefault(u => u.TreatName == treat.TreatName);
        var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        var currentUser = await _userManager.FindByIdAsync(userId);
        treat.User = currentUser;
        if(thisTreatName == null){
            _db.Treats.Add(treat);
            _db.SaveChanges();
            if (FlavorId != 0)
            {
                _db.TreatFlavor.Add(new TreatFlavor() { FlavorId = FlavorId, TreatId = treat.TreatId });
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }else{
          ViewBag.Message = $"{treat.TreatName} is already exist, try other Treat!";
          ModelState.Clear();
          return View();
        }
    }
  }
}
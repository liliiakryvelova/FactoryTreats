using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FactoryTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace FactoryTreats.Controllers
{
  public class TreatsController : Controller
  {
    private readonly FactoryTreatsContext _db;

    public TreatsController(FactoryTreatsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Treats.ToList());
    }

    public ActionResult Details(int id)
      {
          var thisTreat = _db.Treats
              .Include(treat => treat.JoinEntities)
              .ThenInclude(join => join.Flavor)
              .FirstOrDefault(treat => treat.TreatId == id);
          return View(thisTreat);
      }

      public ActionResult Edit(int id)
      {
          var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
          ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
          return View(thisTreat);
      }

      [HttpPost]
      public ActionResult Edit(Treat treat)
      {
          _db.Entry(treat).State = EntityState.Modified;
          _db.SaveChanges();
          return RedirectToAction("Index");
      }

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

      public ActionResult AddFlavor(int id)
      {
          var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
          ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "FlavorName");
          return View(thisTreat);
      }

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

      [HttpPost]
      public ActionResult DeleteFlavor(int joinId)
      {
          var joinEntry = _db.TreatFlavor.FirstOrDefault(entry => entry.TreatFlavorId == joinId);
          _db.TreatFlavor.Remove(joinEntry);
          _db.SaveChanges();
          return RedirectToAction("Index");
      }
      public ActionResult Delete(int id)
      {
          var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
          return View(thisTreat);
      }

      [HttpPost, ActionName("Delete")]
      public ActionResult DeleteConfirmed(int id)
      {
          var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
          _db.Treats.Remove(thisTreat);
          _db.SaveChanges();
          return RedirectToAction("Index");
      }

    public ActionResult Create()
    {
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "FlavorName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Treat treat, int FlavorId)
    {
        var thisTreatName = _db.Treats.FirstOrDefault(u => u.TreatName == treat.TreatName);
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
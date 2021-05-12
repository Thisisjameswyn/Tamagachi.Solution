using Microsoft.AspNetCore.Mvc;
using Tamagotchis.Models;
using System.Collections.Generic;

namespace Tamagotchis.TamagotchisController
{
  public class TamagotchisController : Controller
  {
    [HttpGet("/tamagotchis")]
    public ActionResult Index()
    {
      List<Tamagotchi> allTamagotchis = Tamagotchi.GetAll();
      return View(allTamagotchis);
    }

    [HttpGet("/tamagotchis/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/tamagotchis")]
    public ActionResult Create(string description)
    {
      Tamagotchi myTamagotchi = new Tamagotchi(description);
      return RedirectToAction("Index");
    }

    [HttpPost("/tamagotchis/delete")]
    public ActionResult DeleteAll()
    {
      Tamagotchi.ClearAll();
      return View();
    }

    [HttpGet("/tamagotchis/{id}")]
    public ActionResult Show(int id)
    {
      Tamagotchi foundTamagotchi = Tamagotchi.Find(id);
      return View(foundTamagotchi);
    }

    [HttpPost("/tamagotchis/{id}")]
    public ActionResult Feed()
    {
      Tamagotchi foundTamagotchi = Tamagotchi.Find(id);
      foundTamagotchi.FeedMe();
      return RedirectToAction("Show", id);
    }
  }
}
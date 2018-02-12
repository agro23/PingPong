using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using PingPong.Models;

namespace PingPong.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<string> output = new List<string>{};
      return View("Index", output);
    }

    [HttpPost("/")]
    public ActionResult Result()
    {
      List<string> output = PingPongs.GetPingPong(PingPongs.GetRange(Int32.Parse(Request.Form["range"])));
      return View("Index", output);
    }
  }
}

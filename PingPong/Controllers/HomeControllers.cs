using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PingPong.Models;

namespace PingPong.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
      [HttpPost("/pingpong/results")]
      public ActionResult Results()
      {
        PingPongGenerator pingpong = new PingPongGenerator (int.Parse(Request.Form["inputNumber"]));
        return View (pingpong.GetList());
      }
    }
}

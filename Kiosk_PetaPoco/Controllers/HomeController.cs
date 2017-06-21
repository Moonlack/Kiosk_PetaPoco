using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kiosk_PetaPoco.Models;
using PetaPoco;

namespace Kiosk_PetaPoco.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var db = new Database("Infokiosk");
            var a = new Exhibit { Name = "Srani poko", Description = "SUUUKA", IsMedal = false };
            db.Insert(a);
            var b = db.Query<Exhibit>("SELECT * FROM articles");
                        return View(b);
        }
    }
}
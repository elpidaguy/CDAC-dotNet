using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GothamOnline.Models;

namespace GothamOnline.Controllers
{
    public class WeaponsController : Controller
    {
        // GET: Weapons
        public ActionResult Index()
        {
            List<Products> prodList = new List<Products>();

            prodList.Add(new Products { ID = 1, Name = "Batarang", Desc = "can neutralize mobile enemy" });
            prodList.Add(new Products { ID = 2, Name = "Batclaw", Desc = "Can Grapple t walls" });
            prodList.Add(new Products { ID = 3, Name = "Glue Grenede", Desc = "Stick and Explode" });
            prodList.Add(new Products { ID = 4, Name = "Shock Glows", Desc = "Neutralize enemy without fatal damage" });
            prodList.Add(new Products { ID = 5, Name = "Cloak", Desc = "Fly like a Bat" });
            prodList.Add(new Products { ID = 6, Name = "Grapnel Gun", Desc = "Batclaw but more badass" });
            this.ViewData["Weapons"] = prodList;
            return View();
        }
    }
}
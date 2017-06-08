using AntonVlasiukLab5Home.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AntonVlasiukLab5Home.Controllers
{
    public class AdresController : Controller
    {
        // GET: Adres
        public ActionResult Index()
        {
            List<Adres> adreses;

            using (var ctx = new SchoolContext())
            {
                adreses = ctx.Adreses.ToList();
            }

            return View(adreses);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhraseGenerator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult App(string Phrase, string NbFois, string Couleur)
        {
            ViewBag.Phrase = Phrase;
            ViewBag.NbFois = NbFois;
            ViewBag.Couleur = Couleur;

            return View();
        }
    }
}
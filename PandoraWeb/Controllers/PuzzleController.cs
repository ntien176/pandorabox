using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseIO2;
using Data_Provider;
namespace PandoraWeb.Controllers
{
    public class PuzzleController : Controller
    {
        // GET: Puzzle
        public ActionResult Index()
        {

            return View("Puzzle1");
        }
        public ActionResult Puzzle2()
        {
            return View("Puzzle2");
        }
        public ActionResult Puzzle3()
        {
            return View("Puzzle3");
        }
        public ActionResult Puzzle4()
        {
            return View("Puzzle4");
        }
        public ActionResult Puzzle5()
        {
            return View("Puzzle5");
        }
        public ActionResult Puzzle6()
        {
            return View("Puzzle6");
        }
        public ActionResult Puzzle7()
        {
            return View("Puzzle7");
        }
        public ActionResult Puzzle8()
        {
            return View("Puzzle8");
        }
        public ActionResult Puzzle9()
        {
            return View("Puzzle9");
        }
        public ActionResult Puzzle10()
        {
            return View("Puzzle10");
        }
        public ActionResult Puzzle11()
        {
            return View("Puzzle11");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.Title = "The amazing spiderman";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "Spiderman movie";
            ViewBag.Artits = new string[]
                {
                    "Artist 1 ",
                    "Artist 2 ",
                    "Artits 3 ",

                };

            return View();
        }
      
    }
}
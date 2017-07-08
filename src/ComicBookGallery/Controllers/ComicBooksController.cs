using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var ComicBook = new ComicBook()
            {
                SeriesTitle = "The amazing spiderman",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
                Artists = new Artist[] 
                { 
                  new Artist() {Name = "Mike", role="Writer" },
                  new Artist() {Name = "Luc", role= " publisher" },
                  new Artist() {Name="marc",role="publisher" },
                  new Artist() {Name="Jean", role="writer" }, 
                  
                }
            };
         

            return View(ComicBook);
        }
      
    }
}
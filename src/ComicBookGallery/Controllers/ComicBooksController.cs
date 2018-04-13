using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        //Action methods determine what result is returned in our case the detail of the webpage
        public ActionResult Detail()
        {
            return View();
            
            
        }
    }
}
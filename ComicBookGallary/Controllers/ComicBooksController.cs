using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallary.Controllers
{
    //inherit base class controller
    public class ComicBooksController: Controller
    {
        public ActionResult Detail()
        {
            //Create RedirectResult()
            if(DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            {
                return Redirect("/");
            }
            // create object constructor for contentResult()
            return Content("Hello world");
        }

    }
}
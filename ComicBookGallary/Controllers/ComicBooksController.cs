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
        public string Detail()
        {
            return "This is comic book controller";
        }

    }
}
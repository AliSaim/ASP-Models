using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tut1.Controllers
{
    public class CMSController : Controller
    {
        // GET: CMS
        public ActionResult Index()
        {
            return View();
        }
    }
}
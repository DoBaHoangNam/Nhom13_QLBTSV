using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLBTSV.Areas.Admin.Controllers
{
    public class EventController : Controller
    {
        // GET: Admin/Event
        public ActionResult Index()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace data1.Controllers
{
    public class trueController : Controller
    {
        codeeEntities obj = new codeeEntities();
        // GET: true
        public ActionResult Index()
        {
            List<emp> emps = obj.emps.ToList();
            return View(emps);
        }
    }
}
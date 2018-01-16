using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuckySevenMVC.Controllers
{
    public class LuckyNumberController : Controller
    {
        // GET: LuckyNumber
        public ActionResult Index(Int32? luck)
        {
            Int32 _lucky = 7;
            if(!luck.HasValue)
            {
                _lucky = 7;
            }
            else
            {
                _lucky = luck.Value;
            }
            ViewBag.Luck = _lucky;
            var rand1 = new System.Random();
            Int32 var1 = rand1.Next(0, 10);
            Int32 var2 = rand1.Next(0, 10);
            Int32 var3 = rand1.Next(0, 10);
            ViewBag.Var1 = var1;
            ViewBag.Var2 = var2;
            ViewBag.Var3 = var3;
            if (var1 == _lucky || var2 == _lucky || var3 == _lucky)
            {
                ViewBag.Display = "block";
            }
            else
            {
               ViewBag.Display = "none";
            }
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ATP.LanceBucket.Model;

namespace ATP2.LanceBucket.Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Registration()
        {
            var model = new Registration();
            return View();
        }
    }
}
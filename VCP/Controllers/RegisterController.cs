using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VCP.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// called when register button clicked
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }
    }
}
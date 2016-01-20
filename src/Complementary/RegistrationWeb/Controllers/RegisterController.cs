using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationWeb.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register index
        public ActionResult Index()
        {
            return View();
        }

        // GET: Register personal detail
        public ActionResult PersonalDetail()
        {
            return View();
        }

        // GET: Register payment
        public ActionResult Payment()
        {
            return View();
        }
    }
}
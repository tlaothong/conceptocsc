using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationWeb.Controllers
{
    public class CertificatedController : Controller
    {
        // GET: Certificated
        public ActionResult Certificated()
        {
            return View();
        }
        public ActionResult CertificatedDetail()
        {
            ViewBag.Url = Request.Url.ToString().ToLower();
            return View();
        }
    }
}
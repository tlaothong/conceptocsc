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

        // GET: Payment
        public ActionResult Payment()
        {
            return View();
        }

        // GET: Confirm
        public ActionResult ConfirmByCreditCard()
        {
            return View();
        }
        public ActionResult ConfirmByOnlineBanking()
        {
            return View();
        }
        public ActionResult ConfirmByCounterService()
        {
            return View();
        }
        public ActionResult ConfirmByBank()
        {
            return View();
        }
        // GET: Print exan card
        public ActionResult PrintExanCard()
        {
            return View();
        }
    }
}
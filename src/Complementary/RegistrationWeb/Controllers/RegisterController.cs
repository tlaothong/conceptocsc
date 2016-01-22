using RegistrationWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationWeb.Controllers
{
    public class RegisterController : Controller
    {
        public ActionResult Index()
        {
            var model = new SharedViewModel();
            model.ExamDate = DateTime.Today.AddDays(1);
            return View(model);
        }

        public ActionResult PersonalDetail(SharedViewModel model)
        {
            return View(model);
        }

        public ActionResult Payment(SharedViewModel model)
        {
            model.RegisterCode = DateTime.Now.Ticks.ToString().Substring(12);
            return View(model);
        }

        public ActionResult ConfirmPayment(SharedViewModel model)
        {
            switch (model.PaymentMethod)
            {
                case 1:
                    return View("ConfirmByBank", model);
                case 2:
                    return View("ConfirmByCounterService", model);
                case 3:
                    return View("ConfirmByCreditCard", model);
                case 4:
                    return View("ConfirmByOnlineBanking", model);
                default:
                    return View("ConfirmByBank", model);
            }
        }

        public ActionResult ConfirmByBank(SharedViewModel model)
        {
            return View();
        }

        public ActionResult ConfirmByCounterService(SharedViewModel model)
        {
            return View();
        }

        public ActionResult ConfirmByCreditCard(SharedViewModel model)
        {
            return View();
        }

        public ActionResult ConfirmByOnlineBanking(SharedViewModel model)
        {
            return View();
        }

        public ActionResult HowToPay(SharedViewModel model)
        {
            return View();
        }

        public ActionResult Invoice(SharedViewModel model)
        {
            var expiredDate = 6;
            var amount = 300;
            var invoiceId = 68462035465;

            ViewBag.InvoiceId = invoiceId;
            ViewBag.ExpiredDate = model.ExamDate.AddHours(expiredDate);
            ViewBag.Amount = amount;
            return View(model);
        }

        public ActionResult PrintExamCard(SharedViewModel model)
        {
            //SharedViewModel data = new SharedViewModel
            //{
            //    PID = "OCSC001",
            //    FirstName = "OCSC001",
            //    LastName = "LastName",
            //    Address = "xoxoxoxoxoxo",
            //    BirthDate = DateTime.Now,
            //    Email = "xxx@xxx.com",
            //    ExamDate = DateTime.Now,
            //    ExamLocation = "KKU",
            //    ExamPeriod = 1,
            //    ExamType = "OCSCa",
            //    PaymentMethod = 3,
            //    PhoneNum = "0123456789",
            //    RegisterCode = "13579",
            //};
            //RegisterToEExam(model);

            //Hack: Mock data
            //model.RegisterCode = "5DS3A14e" + DateTime.Now.Ticks;

            ViewBag.ExamTypeText = string.Empty;
            ViewBag.ExamPeriodText = string.Empty;

            if (!string.IsNullOrEmpty(model.FirstName))
            {
                if (model.ExamType == "OCSCa") ViewBag.ExamTypeText = "ภาค ก";
                if (model.ExamPeriod == 1) ViewBag.ExamPeriodText = "เช้า (9.00 - 12.00 น.)";
                else if (model.ExamPeriod == 2) ViewBag.ExamPeriodText = "(13.00 - 16.00 น.)";

                RegisterToEExam(model);
            }
            else
            {
                //HACK : mock data for print exam card
                model = new SharedViewModel
                {
                    PID = "OCSC001",
                    FirstName = "สมชาย",
                    LastName = "สายเสมอ",
                    Address = "xoxoxoxoxoxo",
                    BirthDate = DateTime.Now,
                    Email = "xxx@xxx.com",
                    ExamDate = DateTime.Now,
                    ExamLocation = "KKU",
                    ExamPeriod = 1,
                    ExamType = "OCSCa",
                    PaymentMethod = 3,
                    PhoneNum = "0123456789",
                    RegisterCode = "13579",
                };
                if (model.ExamType == "OCSCa") ViewBag.ExamTypeText = "ภาค ก";
                if (model.ExamPeriod == 1) ViewBag.ExamPeriodText = "เช้า (9.00 - 12.00 น.)";
                else if (model.ExamPeriod == 2) ViewBag.ExamPeriodText = "(13.00 - 16.00 น.)";
            }
            
            return View(model);
        }

        public ActionResult ExamCard(SharedViewModel model)
        {
            ViewBag.ExamTypeText = string.Empty;
            ViewBag.ExamPeriodText = string.Empty;

            if (model.ExamType == "OCSCa") ViewBag.ExamTypeText = "ภาค ก";
            if (model.ExamPeriod == 1) ViewBag.ExamPeriodText = "เช้า (9.00 - 12.00 น.)";
            else if (model.ExamPeriod == 2) ViewBag.ExamPeriodText = "(13.00 - 16.00 น.)";
            return View(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="schoolID"></param>
        private void RegisterToEExam(SharedViewModel data)
        {
            #region Convertion
            //แปลข้อมูล TestPerson เป็น Registraion

            RegistrationService.Register testReg = null;
            testReg = new RegistrationService.Register
            {
                //Person section
                PID = data.PID,
                FirstName = data.FirstName,
                LastName = data.LastName,
                BirthDate = data.BirthDate,

                //TestRegistration section
                ApplicationId = data.PID + data.RegisterCode,

                //LicenseType set below this block
                QuizLanguage = "TH",
                IsListenQuiz = false,
                //AppointDateTime set below this block
                //ExpireDateTime = DateTime.Now.AddDays(_ExpireDay),
                //ApprovedDateTime = DateTime.Now,
                //CourseType = item.CouseType != null ? item.CouseType : "No course",
                CourseType = "No course",
                //SchoolId = Convert.ToInt32(item.CERT_NO),
                SchoolId = 2071,
                ExamNumber = data.PID,
                //ExamNumber = 0,
                AppointDateTime = data.ExamDate,
                ExpireDateTime = data.ExamDate.AddYears(10),
                Status = "APPROVED",
                ApprovedDateTime = DateTime.Now,
                LicenseType = data.ExamType,
                ForPractice = false,
                ForTestSystem = false,
            };
            #endregion Convertion

            var wcf = new RegistrationService.RegistrationServiceClient();

            RegistrationService.Register[] arr = new RegistrationService.Register[] { testReg };
            wcf.RegisterNewPerson(arr);
        }
    }
}
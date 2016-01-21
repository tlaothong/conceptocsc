﻿using RegistrationWeb.Models;
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
            var model = new SharedViewModel();
            return View(model);
        }

        // GET: Register personal detail
        public ActionResult PersonalDetail(SharedViewModel model)
        {
            return View(model);
        }

        // GET: Payment
        public ActionResult Payment(SharedViewModel model)
        {
            return View();
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
                    return View("ConfirmByBank");
            }
        }

        public ActionResult ConfirmByBank()
        {
            return View();
        }

        public ActionResult ConfirmByCounterService()
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
        
        
        // GET: Invoice
        public ActionResult Invoice()
        {
            return View();
        }

        // GET: Print exan card
        public ActionResult PrintExanCard(SharedViewModel model)
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
            return View();
        }
        public ActionResult ExamCard()
        {
            return View();
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
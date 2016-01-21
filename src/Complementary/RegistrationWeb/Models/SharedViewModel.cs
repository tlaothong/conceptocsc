using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationWeb.Models
{
    public class SharedViewModel
    {
        ///////////////  Step 1  ////////////////
        public DateTime ExamDate { get; set; }
        public string ExamLocation { get; set; }
        public string ExamType { get; set; }

        /// <summary>
        /// รอบการสอบ 
        /// 1: เช้า (9.00 - 12.00 น.)
        /// 2: บ่าย (13.00 - 16.00 น.)
        /// </summary>
        public int ExamPeriod { get; set; }

        ///////////////  Step 2  ////////////////
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PID { get; set; }
        public string Address { get; set; }
        public int PhoneNum { get; set; }
        public string Email { get; set; }

        ////////////// Step 3  /////////////////
        /// <summary>
        /// วิธีการชำระเงิน
        /// 1 : Bill
        /// 2 : Counter-Service
        /// 3 : Credit card
        /// 4 : Online banking
        /// </summary>
        public int PaymentMethod { get; set; }

        ////////////// Step 5  /////////////////
        public string RegisterCode { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP_s00210945
{
    public class Member
    {
        public string Name { get; set; }

        public DateTime JoinDate { get; set; }

        public decimal Fee { get; set; }

        private DateTime renewalDate;

        private double daysToRenewal;

        public double DaysToRenewal
        {
            get
            {
                return daysToRenewal;
            }
            set
            {
                DateTime renewalDate1 = JoinDate.AddYears(1);
                DateTime now = DateTime.Now;
                TimeSpan diff = renewalDate1 - now;
                daysToRenewal = diff.Days;
            }
        }

        public DateTime RenewalDate
        {
            get
            {
                return renewalDate;
            }
            set
            {
                renewalDate = JoinDate.AddYears(1);
            }
        }

        public PaymentSchedule PaymentType { get; set; }
        public enum PaymentSchedule
        {
            Annual,
            Biannual,
            Monthly
        }
        public override string ToString()
        {
            return $"{Name }";
        }
        public string GetMemberDetails()
        {
            return $"{Name }\n Join Date: {JoinDate }\n Basic Fee: €{Fee }\n Payment Schedule: {PaymentType}\n Renewal Date: {renewalDate}\n Days To Renewal: {daysToRenewal}";
        }
    
    }
}

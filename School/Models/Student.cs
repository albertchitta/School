using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    internal class Student : Person
    {
        //public string Subject { get; set; }
        //public string MailingAddress { get; set; }
        public double GPA { get; set; }
        public bool isTimely { get; set; }

        public void Study()
        {

        }
    }
}

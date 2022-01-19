using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    internal class Person   //base class
    {
        public string Name { get; set; }
        public string GradeLevel { get; set; }
        public string MailingAddress { get; set; }

        //virtual - allows this method to be overridden in child class
        public virtual void AttendClass()
        {
            Console.WriteLine($"{Name} is attending class.");
        }

    }
}

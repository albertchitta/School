using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    internal class Teacher : Person
    {
        //public string Name { get; set; }
        //public string GradeLevel { get; set; }
        //public string MailingAddress { get; set; }
        public string Subject { get; set; }

        public override void AttendClass()
        {
            Console.WriteLine($"{Name} is teaching {Subject} class.");
        }
    }
}
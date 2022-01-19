// See https://aka.ms/new-console-template for more information
using School.Models;

var student = new Student();
var teacher = new Teacher();

student.Name = "Brian";
teacher.Name = "Nissa";
teacher.GradeLevel = "Third";
teacher.MailingAddress = "123 Main Street";

student.AttendClass();
teacher.AttendClass();

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_excercises
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }
        public decimal Salary { get; set; }
        public DateTime EmploymentDate { get; set; }

        public Person(string name, string surname, int age, string profession, decimal salary, DateTime employmentDate)
        {
            FirstName = name;
            LastName = surname;
            Age = age;
            Profession = profession;
            Salary = salary;
            EmploymentDate = employmentDate;
        }
    }

   
}

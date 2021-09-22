using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Repo
{
    public enum GradeType
    {
        freshman,
        sophmore,
        junior,
        senior
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public GradeType Grade { get; set; }

        public Person () {}
        
        public Person (string name, int age, GradeType grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
    }
}

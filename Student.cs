using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskclass2
{
    public class Student
    {
        public string name {  get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public int phonenumber { get; set; }
        public int limit {  get; set; }
        public string group {  get; set; }
        public Student(string name, string surname, string gender, int age, int phonenumber, int limit, string group)
        {
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.age = age;
            this.phonenumber = phonenumber;
            this.limit = limit;
            this.group = group;
        }
        public void Absent()
        {
            if (limit == 0)
            {
                Console.WriteLine("kesildiniz");
            }
            else if (limit > 0)
            {
                limit--;
                Console.WriteLine($"{name} {surname} bugun derse gelmiyib. Qalan limit:{limit}");
            }
            else
            {
                Console.WriteLine("limit menfi ola bilmir");
            }
            return;
        }
    }
}

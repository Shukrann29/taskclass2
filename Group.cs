using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskclass2
{
    public class Group
    {
        public string name { get; set; }
        public string shift { get; set; }
        public Student[] students { get; set; }

        public Group(string name, string shift, int maxstudents)
        {
            this.name = name;
            this.shift = shift;
           maxstudents = maxstudents;
        }
          public void AddStudent(Student student, string name)
          {
              if (student.group != name)
              {
                  Console.WriteLine($"(name) qrupu movcud deyil");
                  return;
              }
              for (int i = 0; i < students.Length; i++)
              {
                  if (students[i].name == default)
                  {
                      students[i] = student;
                      Console.WriteLine($"{student.name}{student.surname} qrupa elave olundu");
                      return;
                  }
              }
                Console.WriteLine("Qrupda yer yoxdur");
          }

          public void Findstudent(string name)
          {
              for (int i = 0; i < students.Length; i++)
               {
                Console.WriteLine($"{name} adli telebe qrupda var");
                 return;
              }
        }
    

    }
}

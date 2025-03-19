namespace taskclass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1=new Student("Shukran","Suleymanli", "kisi",20,055-729-17-29, 8, "TK");
            Student student2 = new Student("Shahverdi", "Salmanli", "kisi", 20, 055 - 555 - 55 - 55,8, "TK");
            student1.Absent();
            student2.Absent();

            Group group1 = new Group("Shukran", "birinci", 25);
            group1.AddStudent(student1, "TK");
            group1.Findstudent("Shukran");
        }
    }
}

using ClassRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom {
    internal class TestClass {
        static void Main(string[] args) {
            Student s1 = new Student("Jan", "Novák", 20, 1.2);
            Student s2 = new Student("Jan2", "Novák", 20, 2.2);
            Student s3 = new Student("Jan3", "Novák", 20, 3.2);
            Teacher t1 = new Teacher("Učitel 1");
            Teacher t2 = new Teacher("Učitel 2");
            ClassRoom cr1 = new ClassRoom(1);
            ClassRoom cr2 = new ClassRoom(10);

            cr1.AddStudent(s1);
            cr2.AddStudent(s1); cr2.AddStudent(s2); cr2.AddStudent(s3);
            cr1.AddTeacher(t1);
            cr2.AddTeacher(t2);

            Console.WriteLine(s1.ToString());
            Console.WriteLine("-----");
            Console.WriteLine(cr1.ToString());
            //Učitel 2 z druhé třídy
            Console.WriteLine(cr2.GetTeacherName());
            Console.WriteLine("-----");
            //Třetí student
            Console.WriteLine(cr2.GetStudent(3));
        }
    }
}

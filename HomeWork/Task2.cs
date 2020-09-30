using System;
using System.Collections.Generic;
using System.Data;

namespace HomeWork
{
    abstract class Student
    {
        public readonly string name;
        public string state;
        public Student(string Name)
        {
            name = Name;
            state = "";
        }
        public void Relax()
        {
            state += "\n Relax";
        }
        public void Read()
        {
            state += "\n Read";
        }
        public void Write()
        {
            state += "\n Write";
        }

        public abstract void Study();

    }
    class GoodStudent : Student
    {
        public GoodStudent(string name)
            : base(name)
        {
            state += "Good \n";
        }
        override public void Study()
        {
            Read(); Write(); Read(); Write(); Relax();
        }
    }
    class BadStudent : Student
    {
        public BadStudent(string name)
            : base(name)
        {
            state += "Bad \n";
        }
        override public void Study()
        {
            Relax(); Relax(); Relax(); Relax(); Read();
        }
    }
    class Group
    {
        public string groupName;
        private List<Student> students;
        public Group(string Name)
        {
            groupName = Name;
            students = new List<Student>();
        }
        public Group(Student st1, Student st2, Student st3)
        {
            groupName = "Unkown";
            students = new List<Student>() {st1, st2, st3 };
        }
        public void addStudent(Student st)
        {
            students.Add(st);
        }
        public void changeName(string Name)
        {
            groupName = Name;
        }
        public string GetInfo()
        {
            string result = groupName + ": ";
            students.ForEach(delegate (Student st)
            {
                result += st.name + " ";
            });
            return result;
        }
        public string GetFullInfo()
        {
            string result = groupName + ": ";
            students.ForEach(delegate (Student st)
            {
                result += "\n" +st.name + " " + st.state;
            });
            return result;
        }

    }
    class Task2
    {
        static void Main(string[] args)
        {
            GoodStudent Vlasov = new GoodStudent("Micle");
            GoodStudent Ave = new GoodStudent("Maria");
            BadStudent Pupkin = new BadStudent("Vasya");
            BadStudent Ivanov = new BadStudent("Ivan");
            Group K25 = new Group(Ivanov, Pupkin, Vlasov);
            Console.WriteLine(K25.GetInfo());
            K25.changeName("K25");
            Console.WriteLine(K25.GetFullInfo());
            K25.addStudent(Ave);
            Vlasov.Study();
            Ave.Read();
            Pupkin.Study();
            Ivanov.Write();
            Console.WriteLine(K25.GetFullInfo());
        }
    }
}

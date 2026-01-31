using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp02_OOP
{
    class Student
    {
        // Private data members (Encapsulation)
        private int rollNo;
        private string name;

        // Default constructor
        public Student()
        {
            rollNo = 0;
            name = "Not Assigned";
        }

        // Parameterized constructor
        public Student(int rollNo, string name)
        {
            this.rollNo = rollNo;
            this.name = name;
        }

        // Setter methods
        public void SetRollNo(int rollNo)
        {
            this.rollNo = rollNo;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        // Getter methods
        public int GetRollNo()
        {
            return rollNo;
        }

        public string GetName()
        {
            return name;
        }

        // Overriding ToString()
        public override string ToString()
        {
            return "Roll No: " + rollNo + ", Name: " + name;
        }
    }

}

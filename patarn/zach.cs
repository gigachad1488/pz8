using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patarn
{
    interface Itest
    {
        string Name { get; }
        int Grade { get; set; }
        bool Passed { get; set; }
    }

    class difftest : Itest
    {
        
        private int grade;
        private bool passed;
        private string name = "дифференциальный зачет";

        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value >= 1 && value <= 5)
                    grade = value;
                Passed = true;
            }
        }

        public bool Passed
        {
            get
            {
                return passed;
            }
            set
            {
                if (grade >= 3)
                    passed = true;
            }
        }

    }

    class normtest : Itest
    {
        public int Grade { get; set; }
        private bool passed;

        private string name = "зачет";

        public string Name
        {
            get
            {
                return name;
            }
        }

        public bool Passed
        {
            get
            {
                return passed;
            }
            set
            {
                passed = value;
            }
        }
    }

    class exam : Itest
    {
        private int grade;
        private bool passed;
        private string name = "экзамен";

        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value >= 1 && value <= 100)
                    grade = value;
                Passed = true;
            }
        }

        public bool Passed
        {
            get
            {
                return passed;
            }
            set
            {
                if (grade >= 70)
                    passed = true;
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public Itest test;

        public Student(string name, Itest tes)
        {
            Name = name;
            test = tes;
        }
    }
}

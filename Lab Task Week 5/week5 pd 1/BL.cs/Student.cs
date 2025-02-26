using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace week5_pd_1.BL.cs
{
    public class Student
    {
        public string Name;
        public int Age;
        public float FSCMarks;
        public float ECATMarks;
        public float Merit;
        public DegreeProgram EnrolledDegree;
        public List<Subject> RegisteredSubjects;

        public Student(string name, int age, float fscMarks, float ecatMarks)
        {
            Name = name;
            Age = age;
            FSCMarks = fscMarks;
            ECATMarks = ecatMarks;
            RegisteredSubjects = new List<Subject>();
        }

        public void CalculateMerit()
        {
            Merit = (FSCMarks * 0.7f) + (ECATMarks * 0.3f);
        }

        public bool RegisterSubject(Subject subject)
        {
            int totalCredits = 0;
            foreach (Subject s in RegisteredSubjects)
            {
                totalCredits += s.CreditHours;
            }
            if (totalCredits + subject.CreditHours <= 9)
            {
                RegisteredSubjects.Add(subject);
                return true;
            }
            return false;
        }
    }

}

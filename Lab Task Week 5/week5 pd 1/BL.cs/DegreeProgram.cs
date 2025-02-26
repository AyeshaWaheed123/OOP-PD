using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_pd_1.BL.cs
{
    public class DegreeProgram
    {
        public string Title;
        public int Duration;
        public int AvailableSeats;
        public List<Subject> Subjects;

        public DegreeProgram(string title, int duration, int availableSeats)
        {
            Title = title;
            Duration = duration;
            AvailableSeats = availableSeats;
            Subjects = new List<Subject>();
        }

        public void AddSubject(Subject subject)
        {
            int totalCredits = 0;
            foreach (Subject s in Subjects)
            {
                totalCredits += s.CreditHours;
            }
            if (totalCredits + subject.CreditHours <= 20)
            {
                Subjects.Add(subject);
            }
        }
    }
} 

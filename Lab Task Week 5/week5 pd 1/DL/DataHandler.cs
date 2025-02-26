using System.Collections.Generic;

namespace UAMS_DL
{ 
    using week5_pd_1.BL.cs;

    public static class DataHandler
    {
        public static List<Student> Students = new List<Student>();
        public static List<DegreeProgram> DegreePrograms = new List<DegreeProgram>();
        public static List<Subject> Subjects = new List<Subject>();

        public static void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public static void AddDegreeProgram(DegreeProgram program)
        {
            DegreePrograms.Add(program);
        }

        public static void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
        }
    }
}

using System;
using System.Collections.Generic;

namespace UAMS
{ 
 

    class Program
    {
        static void Main()
        {
            while (true)
            {
                UI.ShowMainMenu();
                Console.Write("Enter Option: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Student student = UI.TakeStudentInput();
                    student.CalculateMerit();
                    DataHandler.AddStudent(student);
                    Console.WriteLine("Student Added Successfully!");
                }
                else if (choice == 2)
                {
                    DegreeProgram degree = UI.TakeDegreeProgramInput();
                    DataHandler.AddDegreeProgram(degree);
                    Console.WriteLine("Degree Program Added Successfully!");
                }
                else if (choice == 3)
                {
                    Subject subject = UI.TakeSubjectInput();
                    DataHandler.AddSubject(subject);
                    Console.WriteLine("Subject Added Successfully!");
                }
                else if (choice == 4)
                {
                    Console.Write("Enter Student Name: ");
                    string studentName = Console.ReadLine();
                    Console.Write("Enter Degree Program Title: ");
                    string degreeTitle = Console.ReadLine();

                    Student foundStudent = null;
                    foreach (Student s in DataHandler.Students)
                    {
                        if (s.Name == studentName)
                        {
                            foundStudent = s;
                            break;
                        }
                    }

                    DegreeProgram foundDegree = null;
                    foreach (DegreeProgram d in DataHandler.DegreePrograms)
                    {
                        if (d.Title == degreeTitle)
                        {
                            foundDegree = d;
                            break;
                        }
                    }

                    if (foundStudent != null && foundDegree != null)
                    {
                        foundStudent.EnrolledDegree = foundDegree;
                        Console.WriteLine("Student Enrolled Successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Student or Degree Program not found!");
                    }
                }
                else if (choice == 6)
                {
                    foreach (Student s in DataHandler.Students)
                    {
                        Console.WriteLine(s.Name + " - Merit: " + s.Merit);
                    }
                }
                else if (choice == 7)
                {
                    foreach (DegreeProgram d in DataHandler.DegreePrograms)
                    {
                        Console.WriteLine(d.Title + " - Duration: " + d.Duration + " years");
                    }
                }
                else if (choice == 8)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Option!");
                }
            }
        }
    }
}

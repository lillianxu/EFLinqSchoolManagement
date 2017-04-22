using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolEntities db = new SchoolEntities();
            var courseList = db.Courses.ToList();


            //1*******Create a new Instructor and assign instructor to the Course
            //CourseInstructor newInstructor = new CourseInstructor();
            //newInstructor.CourseID = 1045;
            //newInstructor.PersonID = 1;
            //db.CourseInstructors.Add(newInstructor);


            //2*****Create a new Student and enroll to the Course
            //StudentGrade newStudentGrade = new StudentGrade();
            //newStudentGrade.StudentID = 32;
            //newStudentGrade.CourseID = 2030;
            //newStudentGrade.Grade = 100;
            //db.StudentGrades.Add(newStudentGrade);


            //3******Create a new Course and assign to a Department
            //Course newCourse = new Course();
            //newCourse.CourseID = 1000;
            //newCourse.Title = "Math";
            //newCourse.Credits = 10;
            //newCourse.DepartmentID = 7;
            //db.Courses.Add(newCourse);


            //4********View all Student grades in a Course
            //var query = db.StudentGrades
            //    .Where(studentCourse=>studentCourse.CourseID==4022)
            //    .Select(student => new
            //{
            //    StudentID=student.StudentID,
            //    Studentgrade=student.Grade
            //});
            //Console.WriteLine("Student Infor in Course4022:");
            //foreach(var studentInfo in query)
            //{
            //    Console.WriteLine("StudentID:{0} student Grade is :{1}", studentInfo.StudentID, studentInfo.Studentgrade);
            //}

            //5*******View all  Instructors and display the course they teach
            //var queryInstructors = db.CourseInstructors
            //    .Select(Instructors => new
            //    {
            //        InstructorsID = Instructors.PersonID,
            //        InstructorsCourseID = Instructors.CourseID
            //    });
            //Console.WriteLine("Instructors Infor is:");
            //foreach (var InstructorsInfo in queryInstructors)
            //{
            //    Console.WriteLine("InstructorsID:{0} Instructors Course is :{1}", InstructorsInfo.InstructorsID, InstructorsInfo.InstructorsCourseID);
            //}
            ////6*******Delete a Student********
                //Query for a specific student
                    var stud =
                        (from s in db.StudentGrades
                         where s.StudentID == 32
                         select s).First();
                    // Create and add a new student
                    StudentGrade newStudentGradeA = new StudentGrade
                    { StudentID = 34,
                      CourseID = 2030,
                      Grade = 102};
                     db.StudentGrades.Add(newStudentGradeA);


                    // Delete an existing student
                    StudentGrade newStudentGrade0=stud.


            //7*******Delete a Course*******


            //8*******Ability to Update a Students  record*******

                ////Query for a specific student
                //var stud =
                //    (from s in db.StudentGrades
                //     where s.StudentID == 2
                //     select s).First();
                ////Change the grage of the student
                //stud.Grade = 10;

            //9*******Change Course a Instructor is teaching*******

            // Ask the DataContext to save all the changes
            db.SaveChanges();
            Console.ReadKey();

        }
    }
}

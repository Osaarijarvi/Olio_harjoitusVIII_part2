using System.Linq;

namespace Olio_harjoitusVIII_part2;

// TASK 2 step 2
public class Student
{
    private string studentName;
    public string StudentName
    {
        get
        {
            return studentName;
        }
    }

    // Overloaded Constructor
    public Student(string studentName)
    {
        this.studentName = studentName;
    }

    // Empty list for courses of each student
    private List<Course> courses = new List<Course>();


    // Method for adding courses for a specific student
    public void AddCourse(Course course)
    {
        courses.Add(course);
        Console.WriteLine($"Kurssi {course.CourseName} — arvosana {course.Grade} lisätty opiskelijalle: {studentName}.");
        Console.WriteLine($"DEBUG: {studentName} courselist count = {courses.Count}");
    }

    //Method for listing all courses and their grades of a student.
    public void ListCourses()
    {
        if (courses.Count == 0)
        {
            Console.WriteLine("Opiskelijalla ei ole kursseja.");
        }
        else
            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }
    }
    

    // Method for counting the average grade of courses in the list.
    public void CountAverage()
    {
        // If the student has no courses user is informed of this. 
        if (courses.Count == 0)
        {
            Console.WriteLine($"Opiskelijalla ei ole kursseja. Keskiarvoa ei voi laskea.");
        }
        // Otherwise the average is counted and displayed.
        else
        {
            // New list only for grades initialized
            List<int> grades = new List<int>();

            foreach (var course in courses)
            {
                // Course Grade string --> int
                // Grades are added to the list
                int gradeInt = int.Parse(course.Grade);
                grades.Add(gradeInt);
            }

            // Average() is called, the result rounded and displayed.
            double average = grades.Average();
            average = Math.Round(average, 1, MidpointRounding.ToEven);
            Console.WriteLine($"Kurssikeskiarvosi on: {average}");
        }
    }
}

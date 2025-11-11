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

    // Empty list for students
    List<Student> students = new List<Student>();

    // Empty list for courses
    List<Course> courses = new List<Course>();
    
    
    // Method for adding students to the student list
    public void AddStudent(Student student)
    {
        students.Add(student);
        Console.WriteLine($"{student.studentName} lisätty.");
        Console.WriteLine($"Järjestelmässä on nyt {students.Count} opiskelija(a).");
    }

    public override string ToString()
    {
        return $"{StudentName ?? "<new student name>"}";
    }

    // Method for adding courses to the course list
    public void AddCourse(Course course, string student)
    {
        // Find the student by matching the inputted name to the student list
        Student student = students.FirstOrDefault(b => b.studentName == student_aChoice);

        if (student != null)
        {
            courses.Add(course);
            Console.WriteLine($"Kurssi {course.CourseName} — arvosana {course.Grade} lisätty opiskelijalle: {student.studentName}.");
            Console.WriteLine($"DEBUG: collection count = {courses.Count}");
        }
        // If the student name is not found, the user is advised to first add the student to the system
        else
        {
            Console.WriteLine("Opiskelijaa ei löydy. Lisää ensin opiskelija järjestelmään.");
        }
    }

    //Method for listing all courses and their grades of a student.
    public void ListCourses(Student student_cChoice)
    {
        // Find the student by matching the inputted name to the student list
        Student student = students.FirstOrDefault(c => c.studentName == student_cChoice);

        if (student != null)
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("Opiskelijalla ei ole kursseja.");
            }
            else
                foreach (Course course in courses)
                {
                    Console.WriteLine(course);
                }
        }
    }
    

    // Method for counting the average grade of courses in the list.
    public void averageGrade()
    {
        if (courses.Count > 1)
        {
            int average = courses.Average();
            string averageString = average.ToString();
            Console.WriteLine($"Kurssikeskiarvosi on: {averageString}");
        }
        else
        {
            Console.WriteLine($"Ei kursseja. Keskiarvoa ei voi laskea");
        }
        
    }

    }

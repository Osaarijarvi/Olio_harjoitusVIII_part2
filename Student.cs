namespace Olio_harjoitusVIII_part2;

/* Vaihe 2: Luo Opiskelija-luokka
    Opiskelija-luokka edustaa yksittäistä opiskelijaa, jolla on lista kursseista ja toimintoja
    kurssien lisäämiseen ja keskiarvon laskemiseen.*/

// TASK 2 step 2
public class Student
{
    private string studentName;

    public Student(string name)
    {
        this.studentName = name;
    }

    // Empty list for students
    List<Student> students = new List<Student>();

    // Empty list for courses
    List<Course> courses = new List<Course>();
    
    // Method for adding students to the student list
    public void AddStudent(Student student)
    {
        Console.WriteLine($"Olio luotu: {student}.");
        courses.Add(student);
        Console.WriteLine($"{studentName} lisätty.");
    }

    // Method for adding courses to the course list
    public void AddCourse(Course course)
    {
        Console.WriteLine($"Olio luotu: {course}.");
        courses.Add(course);
        Console.WriteLine($"{course.CourseName} lisätty.");
    }

    
    // Method for removing a course from the list using the name of the course
    public void RemoveCourse(string CoursetoRemove)
    {
        if (courses.Contains(CoursetoRemove))
        {
            courses.Remove(CoursetoRemove);
            Console.WriteLine($"{CoursetoRemove} poistettu.");
        }
        else
        {
            Console.WriteLine("Kurssia ei löydy. Kirjoita kurssin nimi uudestaan.");     }
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

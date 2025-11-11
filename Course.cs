namespace Olio_harjoitusVIII_part2;

// TASK 2 step 1
public class Course
{
    // Member variables initialized
    private string courseName;
    private string grade;

    // get - set for variables initialized
    public string CourseName
    {
        get
        {
            return courseName;
        }
        set
        {
            courseName = value;
        }
    }

    public string Grade
    {
        get
        {
            return grade;
        }
        set
        {
            grade = value;
        }
    }

    // Overloaded constructor
    public Course(string courseName, string grade)
    {
        this.courseName = courseName;
        this.grade = grade;
    }


    public override string ToString()
    {
        return $"{CourseName ?? "<unknown course name>"} — {Grade ?? "<unknown grade>"}";
    }

}
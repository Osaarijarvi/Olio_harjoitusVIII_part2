namespace Olio_harjoitusVIII_part2;

class Program
{
    static void Main(string[] args)
    {

    // TASK 2 STEP 3

    // isRunning initialized
    bool isRunning = true;
    
        while (isRunning)
    {
        // User is asked to choose a function.
        Console.WriteLine();
        Console.WriteLine("Valitse toiminto:");
        Console.WriteLine("a) Lisää uusi opiskelija järjestelmään.");
        Console.WriteLine("b) Lisää uusi kurssi arvosanoineen opiskelijan alle.");
        Console.WriteLine("c) Listaa kaikki opiskelijan kurssit arvosanoineen.");
        Console.WriteLine("d) Näytä opiskelijan kurssien keskiarvo.");
        Console.WriteLine("e) Lopeta ohjelma.");
        
        // Make input case-insensitive and trim whitespace
        string input = Console.ReadLine()?.Trim().ToLower();
        Console.WriteLine($"DEBUG: menu input = '{input}'");

        switch (input)
        {
        // a) adds a student to the system.
        case "a":
            Console.WriteLine("Anna uuden opiskelijan nimi:");
            string student_aChoice = Console.ReadLine();

            Student student_a = new Student(student_aChoice);
            
            // call for Addbook()
            student_a.AddStudent(student_a);
                break;


            // a) adds a course under the student.
        case "b":
            Console.WriteLine("Anna sen opiskelijan nimi, jolle haluat lisätä kurssin:");
            string student_bChoice = Console.ReadLine();
            Student student_b = new Student(student_bChoice);
        
            Console.WriteLine("Anna lisättävän kurssin nimi:");
            string courseName = Console.ReadLine();
            
            Console.WriteLine("Anna opiskelijan arvosana kurssista (1-5):");
            string grade = Console.ReadLine();
            //int grade = int.Parse(gradeInput);
            

            Course course = new Course(courseName, grade);

            // call for addCourse()
            student_b.AddCourse(course, student_bChoice);
            break;
    
        //c) lists all the courses and the grades of a student chosen.
        case "c":
            Console.WriteLine("Anna sen opiskelijan nimi, jonka kurssilistan haluat nähdä: ");
            string student_cChoice = Console.ReadLine();
            
            Student student_c = new Student(student_cChoice);
            student_c.ListCourses(Student student_cChoice);
                    break;
                
        //d) display the average grade of the stundent.
        case "d":
            break;

        // d) stops the programme
            case "e":
            isRunning = false;                 
            break;

            }
        }
    }
}


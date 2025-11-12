namespace Olio_harjoitusVIII_part2;

class Program
{
    static void Main(string[] args)
    {

        // TASK 2 STEP 3

        // isRunning initialized.
        bool isRunning = true;
    

        // Empty list for students initialized.
        List<Student> students = new List<Student>();


        while (isRunning)
        {
            // MENU — User is asked to choose a function.
            Console.WriteLine();
            Console.WriteLine("Valitse toiminto:");
            Console.WriteLine("a) Lisää uusi opiskelija järjestelmään.");
            Console.WriteLine("b) Lisää uusi kurssi arvosanoineen opiskelijan alle.");
            Console.WriteLine("c) Listaa kaikki opiskelijan kurssit arvosanoineen.");
            Console.WriteLine("d) Näytä opiskelijan kurssien keskiarvo.");
            Console.WriteLine("e) Lopeta ohjelma.");
            
            // Makes input case-insensitive and trim whitespace.
            string input = Console.ReadLine()?.Trim().ToLower();
            Console.WriteLine($"DEBUG: menu input = '{input}'");

            switch (input)
            {
                // a) Adds a student to the system.
                case "a":
                    // User is asked to input student's name
                    Console.WriteLine("Anna uuden opiskelijan nimi:");
                    string studentName = Console.ReadLine();

                    // new student instance created with the parameter name.
                    // the name is added to the list containing students
                    var newStudent = new Student(studentName);
                    students.Add(newStudent);

                    Console.WriteLine($"{studentName} lisätty.");
                    Console.WriteLine($"Järjestelmässä on nyt {students.Count} opiskelija(a).");
                    Console.WriteLine("Kaikki järjestelmään lisätyt opiskelijat:");
                        break;


                // b) Adds a course under the student.
                case "b":
                    // User is asked to input student's name.
                    Console.WriteLine("Anna sen opiskelijan nimi, jolle haluat lisätä kurssin:");
                    string coursesForThisStudent = Console.ReadLine();

                    // Matches the inputted name with a student's name.
                    var studentForCourse = students.FirstOrDefault(s => s.StudentName == coursesForThisStudent);

                    // If there is no match user is asked to check the spelling or add a new student.
                    if (studentForCourse == null)
                    {
                        Console.WriteLine("Opiskelijaa ei löydy. Tarkista kirjoitusasu tai lisää uusi opiskelija järjestelmään.");
                        break;
                    }

                    // User is asked to input the course name.
                    Console.WriteLine("Anna lisättävän kurssin nimi:");
                    string courseName = Console.ReadLine();
                    
                    // User is asked to input the course grade.
                    Console.WriteLine("Anna opiskelijan arvosana kurssista (1-5):");
                    string grade = Console.ReadLine();
                    
                    // new instance created with the parameters inputted.
                    Course course = new Course(courseName, grade);

                    // call for addCourse()
                    studentForCourse.AddCourse(course);
                        break;


                // c) Lists all the courses and the grades of a specific student.
                case "c":
                 // User is asked to input student's name
                    Console.WriteLine("Anna sen opiskelijan nimi, jonka kurssilistan haluat nähdä: ");
                    string studentWithCourses = Console.ReadLine();

                    // Matches the inputted name with a student's name.
                    var studentToList = students.FirstOrDefault(s => s.StudentName == studentWithCourses);

                    // If there is no match, user is informed of this.
                    if (studentToList == null)
                    {
                        Console.WriteLine("Opiskelijaa ei löydy.");
                    }
                    // If there is a match, student's courses are displayed. 
                    else
                    {
                        studentToList.ListCourses();
                    }
                        break;


                // d) displays the average grade of a student.
                case "d":
                    // User is asked to input a student's name
                    Console.WriteLine("Anna sen opiskelijan nimi, jonka kurssien keskiarvon haluat nähdä: ");
                    string studentWithAverage = Console.ReadLine();

                    // Matches the inputted name with a student's name.
                    var studentForAverage = students.FirstOrDefault(s => s.StudentName == studentWithAverage);
                    
                    // If there is no match, user is informed of this.
                    if (studentForAverage == null)
                    {
                        Console.WriteLine("Opiskelijaa ei löydy.");
                    }
                    // If there is a match, student's average course grade is displayed. 
                    else
                    {
                        studentForAverage.CountAverage();
                    }
                        break;

                // e) stops the programme
                case "e":
                isRunning = false;
                    break;
                
                default:
                Console.WriteLine("Tuntematon valinta. Kirjoita a, b, c tai d.");
                    break;
            }
        }
    }
}


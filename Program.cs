namespace Olio_harjoitusVIII_part2;

class Program
{
    static void Main(string[] args)
    {

        /*Kun ohjelma suoritetaan, käyttäjällä on seuraavat vaihtoehdot:
        - Lisätä opiskelija – luo uuden opiskelijan nimellä.
        - Lisätä kurssi opiskelijalle – lisää opiskelijan kurssilistaan uuden kurssin ja arvosanan.
        - Näyttää opiskelijan kurssit – listaa kaikki opiskelijan kurssit ja arvosanat.
        - Laskea opiskelijan keskiarvo – laskee opiskelijan kurssien keskiarvon ja näyttää sen.
        - Lopettaa ohjelma – lopettaa ohjelman*/

    {
    // TASK 2 STEP 3

    // isRunning initialized
    bool isRunning = true;

    // create new instance for library
    //Library collection = new Library();


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


        string input = Console.ReadLine();

        switch (input)
        {
        // a) adds a book to the library.
        case "a":
            Console.WriteLine("Anna opiskelijan nimi:");
            string studentName = Console.ReadLine();
            
            Student student = new Student(studentName);

            // call for Addbook()
            courses.AddBook(book);
                            break;
                

        // a) adds a course under the student.
        case "b":
            Console.WriteLine("Anna kurssin nimi:");
            string courseName = Console.ReadLine();
            Console.WriteLine("Anna kurssin arvosana:");
            string grade = Console.ReadLine();

            Course course = new Course(courseName, grade);

            // call for Addbook()
            courses.AddBook(book);
                            break;
    
   
        // c) removes a course from the course list.
        case "c":
            Console.WriteLine("Anna poistettavan kurssin nimi:");
            string CoursetoRemove = Console.ReadLine();
            courses.RemoveCourse(CoursetoRemove);
            break;

        //c) lists all the courses with their grades.
        case "c":
            Console.WriteLine("Opiskelijan kurssit: ");
            courses.ListBooks();
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
}

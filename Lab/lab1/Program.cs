int a;
string name;
Console.WriteLine("Enter your name:");
name = Console.ReadLine();
Console.WriteLine("Enter your mark:");
a = int.Parse(Console.ReadLine());
string grade;

            
            if (a >=75)
            {
                grade = "A";
            }
            else if (a>=6)
            {
                grade = "B";
            }
            else if (a>=50)
            {
                grade = "C";
}
            else if (a>=40)
            {
                grade = "D";
            }
            else
            {
                grade = "Fail";
            }

            
            Console.WriteLine("Student name: {0}", name);
            Console.WriteLine("Student grade: {0}", grade);
Console.ReadKey();

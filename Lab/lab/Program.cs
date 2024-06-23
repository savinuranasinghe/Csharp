int a, b;
Console.WriteLine("Enter  first number:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
b = int.Parse(Console.ReadLine());

int sum = a + b;
int subtraction = a - b;
int multiplication = a * b;
float division = (float)a / b;

Console.WriteLine("Sum: {0} ", sum);
Console.WriteLine("Subtraction:{0}", subtraction);
Console.WriteLine("Multiplication:{0}", multiplication);
Console.WriteLine("division:{0:F2}", division);
Console.ReadKey();
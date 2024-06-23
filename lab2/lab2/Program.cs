using System;

namespace ConvertValues
{
    class ConvertValues
    {
        public void KilometerToMeter()
        {
            
            Console.WriteLine("Enter the kilometer value: ");
            double kilometer = Convert.ToDouble(Console.ReadLine());

            
            double meters = kilometer * 1000;

            
            Console.WriteLine("The equivalent in meters is: {0}", meters);
            Console.ReadKey();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
           
            ConvertValues convertValues = new ConvertValues();

            
            convertValues.KilometerToMeter();
           
            
        }
    }
}


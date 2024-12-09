using System;

namespace BMI_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight (kg): ");
            decimal weight = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height (cm): ");
            decimal heightInCm = decimal.Parse(Console.ReadLine());

            decimal heightInMeters = heightInCm / 100;

            decimal bmi = weight / (heightInMeters * heightInMeters);

            Console.WriteLine($"Your BMI is: {bmi:F2}");
            if (bmi < 18.5m)
            {
                Console.WriteLine("Underweight");
            }
            else if (bmi >= 18.5m && bmi < 24.9m)
            {
                Console.WriteLine("Normal weight");
            }
            else if (bmi >= 25m && bmi < 29.9m)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obesity");
            }
        }
    }
}

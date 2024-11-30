using System;

namespace BloodType
{
    internal class Program
    {
        static void Main()
        {
            START:
            Console.WriteLine("Select father blood type (A, B, AB, O): ");
            string fatherBT = Console.ReadLine().ToUpper();

            Console.WriteLine("Select mother blood type (A, B, AB, O): ");
            string motherBT = Console.ReadLine().ToUpper();

            Console.WriteLine("The child blood type will be:");

            switch (fatherBT)
            {
                case "A":
                    switch (motherBT)
                    {
                        case "A":
                            Console.WriteLine("A, O");
                            break;
                        case "B":
                            Console.WriteLine("A, B, AB, O");
                            break;
                        case "AB":
                            Console.WriteLine("A, B, AB");
                            break;
                        case "O":
                            Console.WriteLine("A, O");
                            break;
                        default:
                            Console.WriteLine("Invalid mother blood type.");
                            break;
                    }
                    break;

                case "B":
                    switch (motherBT)
                    {
                        case "A":
                            Console.WriteLine("A, B, AB, O");
                            break;
                        case "B":
                            Console.WriteLine("B, O");
                            break;
                        case "AB":
                            Console.WriteLine("A, B, AB");
                            break;
                        case "O":
                            Console.WriteLine("B, O");
                            break;
                        default:
                            Console.WriteLine("Invalid mother blood type.");
                            break;
                    }
                    break;

                case "AB":
                    switch (motherBT)
                    {
                        case "A":
                            Console.WriteLine("A, B, AB");
                            break;
                        case "B":
                            Console.WriteLine("A, B, AB");
                            break;
                        case "AB":
                            Console.WriteLine("A, B, AB");
                            break;
                        case "O":
                            Console.WriteLine("A, B");
                            break;
                        default:
                            Console.WriteLine("Invalid mother blood type.");
                            break;
                    }
                    break;

                case "O":
                    switch (motherBT)
                    {
                        case "A":
                            Console.WriteLine("A, O");
                            break;
                        case "B":
                            Console.WriteLine("B, O");
                            break;
                        case "AB":
                            Console.WriteLine("A, B");
                            break;
                        case "O":
                            Console.WriteLine("O");
                            break;
                        default:
                            Console.WriteLine("Invalid mother blood type.");
                            break;
                    }
                    break;
                   

                default:
                    Console.WriteLine("Invalid father blood type.");
                    break;

            }
            Console.WriteLine("------------------------------------");
            goto START;
        }
    }
}
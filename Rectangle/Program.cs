using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of recatangle ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of recatangle ");
            double width = double.Parse(Console.ReadLine());

            HinhChuNhat hinhChuNhat = new HinhChuNhat(length,width);
            hinhChuNhat.show();
        }


     
    }

    class HinhChuNhat
    {
        double Length { get; set; }
        double Width { get; set; }

        public HinhChuNhat()
        {
            
        }

        public HinhChuNhat(double length, double width)
        {
            Length = length;
            Width = width;
        }

        double calculateArea()
        {
            return Length * Width;
        }

        double calculatePerimeter()
        {
            return 2 * (Length * Width);
        }

        public void show()
        {
            double area = calculateArea();
            double perimeter = calculatePerimeter();

            Console.WriteLine($"\nRectangle Details:");
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Month:");
            //int month = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Year: ");
            //int year = Convert.ToInt32(Console.ReadLine());


            //switch (month)
            //{
            //    case 2:
            //        if (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0))
            //        {
            //            Console.WriteLine("29 Days");
            //        }
            //        else
            //        {

            //            Console.WriteLine("28 Days");
            //        }
            //        break;
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        {
            //            Console.WriteLine("31 Days"); break;
            //        }

            //    default:
            //        Console.WriteLine("30 Days"); break;
            //}


            Console.WriteLine("Enter day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());


            int dayInMonth = 0;

            switch (month)
            {
                case 1:
                    dayInMonth = 31;
                    break;
                case 2:
                    if (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0))
                    {
                        dayInMonth = 29;
                    }
                    else
                    {
                        dayInMonth = 28;
                    }break;
                case 3:
                    dayInMonth = 31;
                    break;
                case 4:
                    dayInMonth = 30;
                    break;
                case 5:
                    dayInMonth = 31;
                    break;
                case 6:
                    dayInMonth = 30;
                    break;
                case 7:
                    dayInMonth = 31;
                    break;
                case 8:
                    dayInMonth = 31;
                    break;
                case 9:
                    dayInMonth = 30;
                    break;
                case 10:
                    dayInMonth = 31;
                    break;
                case 11:
                    dayInMonth = 30;
                    break;
                case 12:
                    dayInMonth = 31;
                    break;
                default:
                    Console.WriteLine("Invalid month");
                    break;
            }

            if(day < dayInMonth)
            {
                day++;
            }else if(day == dayInMonth)
            {
                day = 1;
                if(month == 12)
                {
                    month = 1;
                    year++;
                }
                else
                {
                    month++;
                }
            }
            string monthName = "";
            switch (month)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
            }
            Console.WriteLine($"Tomorrw is {day} {monthName} {year}");
           }
        }
    }

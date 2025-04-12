using StudentORM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentORM
{

    public class Program
    {
      static void Main(string[] args)
        {
            //string result = InsertStudent();
            //Console.WriteLine(result);

            //Console.WriteLine(InsertStudent());
            UpdateStudent();
        }

        static string InsertStudent()
        {
            try
            {
                using (StudentdbDataContext db = new StudentdbDataContext())
                {

                    tbl_Student stu = new tbl_Student();
                    Console.Write("Enter Student Name: ");
                    stu.Name = Console.ReadLine();
                    Console.Write("Enter Student Age: ");
                    stu.Age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Student Gender: ");
                    stu.Gender = Console.ReadLine();
                    Console.Write("Enter Student Email: ");
                    stu.Email = Console.ReadLine();
                    Console.Write("Enter Student Phone: ");
                    stu.Phone = Console.ReadLine();

                    stu.ID = Guid.NewGuid();
                    stu.CreatedDate = DateTime.Now;
                    stu.UpdatedDate = DateTime.Now;
                    stu.IsActive = true;

                    if (string.IsNullOrEmpty(stu.Name) || string.IsNullOrEmpty(stu.Gender) || string.IsNullOrEmpty(stu.Email) || string.IsNullOrEmpty(stu.Phone) || stu.Age <= 0)
                    {

                        return "Please add valid information.";
                    }
                    else
                    {


                        db.tbl_Students.InsertOnSubmit(stu);
                        db.SubmitChanges();
                        return "Student successfully added.";
                    }
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        static string ShowStudent()
        {
            try
            {
                using (StudentdbDataContext db = new StudentdbDataContext())
                {
                    var student = db.tbl_Students;
                    if (!student.Any())
                    {
                        return "Total Student List.....\nNo students found in the database.";
                    }

                    int studentCount = student.Count();
                    string result = $"Total Student List ({studentCount} students).....\n";
                    foreach (var stu in student)
                    {
                        result += $"Name: {stu.Name}\n" +
                                  $"Gender: {stu.Gender}\n" +
                                  $"Age: {stu.Age}\n" +
                                  $"Email: {stu.Email}\n" +
                                  $"Phone: {stu.Phone}\n" +
                                  "-------------------\n";
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        static bool DelectStudent()
        {
            try
            {
                using(StudentdbDataContext db = new StudentdbDataContext())
                {
                    Console.Write("Enter Student ID to delete: ");
                    Guid id;
                    if (!Guid.TryParse(Console.ReadLine(), out id))
                    {
                        Console.WriteLine("Invalid ID format.");
                        return false;
                    }
                    tbl_Student stu = db.tbl_Students.SingleOrDefault(s => s.ID == id);
                    if (stu == null)
                    {
                        Console.WriteLine("Student not found");
                        return false;
                    }
                    db.tbl_Students.DeleteOnSubmit(stu);
                    db.SubmitChanges();
                    Console.WriteLine("Student successfully deleted.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
        static bool SearchStudent()
        {
            try
            {
                using(StudentdbDataContext db = new StudentdbDataContext())
                {
                    Console.WriteLine("Enter Student Id to find Student: ");
                    Guid id;
                    if (!Guid.TryParse(Console.ReadLine(), out id))
                    {
                        Console.WriteLine("Invalid ID format.");
                        return false;
                    }

                    tbl_Student stu = db.tbl_Students.FirstOrDefault(s => s.ID == id);
                    if(stu == null)
                    {
                        Console.WriteLine("Student not found");
                        return false;
                    }
                    else
                    {
                        Console.WriteLine($"Student : {stu.ID} \n{stu.Name} \n{stu.Gender} \n{stu.Age} \n{stu.Phone}");
                        return true;
                    }
                }
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        static bool UpdateStudent()
        {
            try
            {
                using (StudentdbDataContext db = new StudentdbDataContext())
                {
                    Console.Write("Enter Student Id to update student: ");
                    Guid id;
                    if (!Guid.TryParse(Console.ReadLine(),out id))
                    {
                        Console.WriteLine("Invalid ID format.");
                        return false;
                    }

                    tbl_Student stu = db.tbl_Students.SingleOrDefault(s => s.ID == id);
                    if (stu == null)
                    {
                        Console.WriteLine("Student not found.");
                        return false;
                    }
                    else
                    {
                        Console.Write("Enter Student Name: ");
                        stu.Name = Console.ReadLine();
                        Console.Write("Enter Student Age: ");
                        stu.Age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Student Gender: ");
                        stu.Gender = Console.ReadLine();
                        Console.Write("Enter Student Email: ");
                        stu.Email = Console.ReadLine();
                        Console.Write("Enter Student Phone: ");
                        stu.Phone = Console.ReadLine();

                        stu.UpdatedDate = DateTime.Now;
                        db.SubmitChanges();
                        Console.WriteLine("Student successfully updated.");
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}


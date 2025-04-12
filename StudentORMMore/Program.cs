using StudentORMMore.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentORMMore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UpdateStudent();
        }
        static void GetAllStudent()
        {
            try
            {
                using (StudentdbDataContext db = new StudentdbDataContext())
                {
                    var student = db.tbl_Students;
                    if (db == null)
                    {
                        Console.WriteLine("Total Student List.....\nNo students found in the database.");
                    }
                    else
                    {
                        foreach (var stu in student)
                        {
                            Console.WriteLine($"Student: {stu.ID} \nName: {stu.Name} \nGender: {stu.Gender} \nEmail: {stu.Email} \nPhone: {stu.Phone}");
                            Console.WriteLine("-----------------------------------------");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void SearchStudent()
        {
            try
            {
                using (StudentdbDataContext db = new StudentdbDataContext())
                {
                    Console.Write("Enter Student ID: ");
                    Guid id;
                    if (!Guid.TryParse(Console.ReadLine(), out id))
                    {
                        Console.WriteLine("Invalid ID format.");
                    }
                    else
                    {
                        var exsitingSudent = db.tbl_Students.SingleOrDefault(e => e.ID == id);
                        if (exsitingSudent == null)
                        {
                            Console.WriteLine("Student not found!");
                        }
                        else
                        {
                            Console.WriteLine($"Student: {exsitingSudent.ID} \nName: {exsitingSudent.Name} \nGender: {exsitingSudent.Gender} \nEmail: {exsitingSudent.Email} \nPhone: {exsitingSudent.Phone}");
                            Console.WriteLine("-----------------------------------------");
                        }

                    }
                    ;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void AddStudent()
        {
            try
            {
                using (StudentdbDataContext db = new StudentdbDataContext())
                {
                    tbl_Student tbl = new tbl_Student();
                    Console.Write("Enter Student name: ");
                    tbl.Name = Console.ReadLine();
                    Console.Write("Enter Student age: ");
                    tbl.Age = int.Parse(Console.ReadLine());
                    Console.Write("Enter Student Gender: ");
                    tbl.Gender = Console.ReadLine();
                    Console.Write("Enter Student Email: ");
                    tbl.Email = Console.ReadLine();
                    Console.Write("Enter Student Phone: ");
                    tbl.Phone = Console.ReadLine();

                    tbl.ID = Guid.NewGuid();
                    tbl.CreatedDate = DateTime.UtcNow;
                    //tbl.UpdatedDate = DateTime.UtcNow;

                    tbl.IsActive = true;
                    //var tblStudent = db.tbl_Students;
                    if (string.IsNullOrEmpty(tbl.Name) || tbl.Age <= 0 || string.IsNullOrEmpty(tbl.Gender) || string.IsNullOrEmpty(tbl.Email) || string.IsNullOrEmpty(tbl.Phone))
                    {
                        Console.WriteLine("Invalid data");
                    }
                    else
                    {
                        db.tbl_Students.InsertOnSubmit(tbl);
                        db.SubmitChanges();
                        Console.WriteLine("Add Student Successfully..");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void DeleteStudent()
        {
            try
            {
                using (StudentdbDataContext db = new StudentdbDataContext())
                {

                    Console.Write("Enter student id to delete: ");
                    Guid id;
                    if (!Guid.TryParse(Console.ReadLine(), out id))
                    {
                        Console.WriteLine("Invalid Student ID fromat.");
                    }
                    else
                    {
                        var existingStudentId = db.tbl_Students.SingleOrDefault(x => x.ID == id);
                        if (existingStudentId == null)
                        {
                            Console.WriteLine("Student not found!");
                        }
                        else
                        {
                            db.tbl_Students.DeleteOnSubmit(existingStudentId);
                            db.SubmitChanges();
                            Console.WriteLine("Delete Student Successfully");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void UpdateStudent()
        {
            try
            {
                using (StudentdbDataContext db = new StudentdbDataContext())
                {
                    Console.Write("Enter Student Id to update student: ");
                    Guid id;
                    if (!Guid.TryParse(Console.ReadLine(), out id))
                    {
                        Console.WriteLine("Invalid Student id format. ");

                    }
                    else
                    {
                        var existingStudentId = db.tbl_Students.SingleOrDefault(x => x.ID == id);
                        if(existingStudentId == null)
                        {
                            Console.WriteLine("Student not found!");
                        }
                        else
                        {
                            tbl_Student tbl = new tbl_Student();
                            Console.Write("Enter Student name: ");
                            tbl.Name = Console.ReadLine();
                            Console.Write("Enter Student age: ");
                            tbl.Age = int.Parse(Console.ReadLine());
                            Console.Write("Enter Student Gender: ");
                            tbl.Gender = Console.ReadLine();
                            Console.Write("Enter Student Email: ");
                            tbl.Email = Console.ReadLine();
                            Console.Write("Enter Student Phone: ");
                            tbl.Phone = Console.ReadLine();

                      
                            if (string.IsNullOrEmpty(tbl.Name) || tbl.Age <= 0 || string.IsNullOrEmpty(tbl.Gender) || string.IsNullOrEmpty(tbl.Email) || string.IsNullOrEmpty(tbl.Phone))
                            {
                                Console.WriteLine("Invalid data");
                            }
                            else
                            {
                                existingStudentId.Name = tbl.Name;
                                existingStudentId.Age = tbl.Age;
                                existingStudentId.Gender = tbl.Gender;
                                existingStudentId.Email = tbl.Email;
                                existingStudentId.Phone = tbl.Phone;
                                existingStudentId.UpdatedDate = DateTime.UtcNow;

                                existingStudentId.IsActive = true;
                                db.SubmitChanges();
                                Console.WriteLine("Update Student Successfully..");
                            }


                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}




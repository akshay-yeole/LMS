using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Entities;
using LMS.BooksBLL;
namespace LMS.PL
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string check = string.Empty;
            bookbll bkbll = new bookbll(); 
            do
            {
                Console.WriteLine("******************************LMS*********************************");
                Console.WriteLine(" 1. Add a Book");
                Console.WriteLine(" 2. Add a Category");
                Console.WriteLine(" 3. Add a New Student");
                Console.WriteLine(" 4. Edit Student Details");
                Console.WriteLine(" 5. Get details of all books belonging to specific category");
                Console.WriteLine(" 6. Get details of students from specific standard and division");
                Console.WriteLine(" 7. Issue a book to student entry");
                Console.WriteLine(" 8. Book returned by student entry");
                Console.WriteLine("******************************************************************");
                Console.WriteLine(" Enter your choice :: ");
                choice=int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Books book = new Books();
                        Console.WriteLine(" Book Code :: ");
                        book.BookCode = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Book Name :: ");
                        book.BookName = Console.ReadLine();
                        Console.WriteLine(" Author :: ");
                        book.Author = Console.ReadLine();
                        Console.WriteLine(" Copies Available :: ");
                        book.CopiesAvailable = int.Parse(Console.ReadLine());
                        Console.WriteLine(" CategoryID :: ");
                        book.CategoryID = int.Parse(Console.ReadLine());

                        if (bkbll.AddBookBLL(book))
                        {
                            Console.WriteLine("Book Added");
                        }else
                        {
                            Console.WriteLine("Book not added");
                        }
                        break;
                    case 2:
                        BookCategory obj = new BookCategory();

                        Console.WriteLine(" CatgeoryID :: ");
                        obj.CategoryID = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Category Name :: ");
                        obj.CategoryName = Console.ReadLine();

                        if (bkbll.AddBookCategoryBLL(obj)) 
                        {
                            Console.WriteLine("Category added.");
                        }
                        else 
                        {
                            Console.WriteLine("Unable to add category");
                        }
                        break;
                    case 3:
                        Student student = new Student();
                        Console.WriteLine(" Roll No :: ");
                        student.RollNo = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Name :: ");
                        student.Name= Console.ReadLine();
                        Console.WriteLine(" Address :: ");
                        student.Address= Console.ReadLine();
                        Console.WriteLine(" STD :: ");
                        student.STD= int.Parse(Console.ReadLine());
                        Console.WriteLine(" DIV :: ");
                        student.DIV= Console.ReadLine();

                        if (bkbll.AddStudentBLL(student))
                        {
                            Console.WriteLine("Student added");
                        }
                        else
                        {
                            Console.WriteLine("Unable to add student");
                        }
                        break;
                    case 4:
                        Student stud = new Student();
                        Console.WriteLine(" Enter RollNumber To Update Details :: ");
                        stud.RollNo = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Name :: ");
                        stud.Name = Console.ReadLine();
                        Console.WriteLine(" Address :: ");
                        stud.Address = Console.ReadLine();
                        Console.WriteLine(" STD :: ");
                        stud.STD = int.Parse(Console.ReadLine());
                        Console.WriteLine(" DIV :: ");
                        stud.DIV = Console.ReadLine();

                        if (bkbll.AddStudentBLL(stud))
                        {
                            Console.WriteLine("Student Profile updated");
                        }
                        else
                        {
                            Console.WriteLine("Student Profile not updated");
                        }
                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:

                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
                Console.WriteLine(" Do you want to continue (YES/NO) :: ");
                check=Console.ReadLine().ToUpper();
            } while (check != "NO");
        }
    }
}

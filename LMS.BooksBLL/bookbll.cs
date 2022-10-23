using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.BooksDAL;
using LMS.Entities;
namespace LMS.BooksBLL
{
    public class bookbll
    {
        Booksdal bdal = new Booksdal();

        public bool AddBookBLL(Books book) 
        {
            bool status = false;
            try
            {
                status = bdal.AddBook(book);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return status;
        }
        public bool AddBookCategoryBLL(BookCategory obj)
        {
            bool status = false;
            try
            {
                status = bdal.AddCategory(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return status;
        }
        public bool AddStudentBLL(Student obj)
        {
            bool status = false;
            try
            {
                status = bdal.AddStudent(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return status;
        }
        public bool UpdateStudentDetailsBLL(Student obj)
        {
            bool status = false;
            try
            {
                status = bdal.UpdateStudentDetails(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return status;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.BooksDAL;
using LMS.Entities;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace LMS.BooksDAL
{
    public class Booksdal
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter sda;
        SqlDataReader sdr;
        public Booksdal() 
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);     
        }
        public bool AddCategory(BookCategory obj) 
        {
            bool status = false;
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "sp_AddBookCategory";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoryID", obj.CategoryID);
                cmd.Parameters.AddWithValue("@CategoryName", obj.CategoryName);
               
                conn.Open();
                int result=cmd.ExecuteNonQuery();
                if (result > 0) 
                {
                    status= true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally 
            {
                conn.Close();
            }
            return status;
        }

        public bool AddBook(Books book)
        {
            bool status = false;
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "sp_AddBook";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookCode", book.BookCode);
                cmd.Parameters.AddWithValue("@BookName", book.BookName);
                cmd.Parameters.AddWithValue("@CopiesAvailable", book.CopiesAvailable);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@CategoryID", book.CategoryID);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return status;
        }
        public bool AddStudent(Student obj)
        {
            bool status = false;
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "sp_AddStudent";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RollNo", obj.RollNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@STD", obj.STD);
                cmd.Parameters.AddWithValue("@DIV", obj.DIV);
                cmd.Parameters.AddWithValue("@Address", obj.Address);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return status;
        }
        public bool UpdateStudentDetails(Student obj)
        {
            bool status = false;
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "sp_UpdateStudentDetails";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RollNo", obj.RollNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@STD", obj.STD);
                cmd.Parameters.AddWithValue("@DIV", obj.DIV);
                cmd.Parameters.AddWithValue("@Address", obj.Address);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return status;
        }
    }
}

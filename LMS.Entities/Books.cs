using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Entities
{
    public class Books
    {
        private int bookcode, copiesavailable, categoryid;
        private string bookname, author;

        public int BookCode { get; set; }
        public int CopiesAvailable{get;set;}
        public int CategoryID { get; set; }
        public string BookName { get;set;}
        public string Author { get; set; }

    }
}

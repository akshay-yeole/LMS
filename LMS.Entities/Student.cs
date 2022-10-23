using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Entities
{
    public class Student
    {
        private int std,rollno;
        private string div, address, name;

        public int STD { get; set; }
        public int RollNo { get; set; }
        public string DIV { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
    }
}

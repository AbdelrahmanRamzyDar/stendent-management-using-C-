using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management.Models.employee
{
    class Employee
    {
        public int employeeid { get; set; }

        public string fullname { get; set; }
         public DateTime dataofbirth { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public byte[] photo { get; set; }
        public int DepartId { get; set; }



    }
}

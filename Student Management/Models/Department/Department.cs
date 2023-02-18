using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management.Models.Department
{
    public class Department
    {
    public int DepartId { get; set; }
        public string StudentName { get; set; }

        public string DepatmentName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public byte[] StudentImage { get; set; }
         
    }
}

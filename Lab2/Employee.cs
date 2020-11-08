using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    partial class Employee
    {
        public Employee() {
            name = "";
            experience = "";
            status = "";
            office = "";
            sex = "";
            position = "";
        }
        public string name;
        public string experience;
        public string status;
        public string office;
        public string sex;
        public string position;
    }
}

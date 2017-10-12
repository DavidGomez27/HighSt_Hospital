using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospital
{
    class Hospital_Employee
    {

        protected string employeeName;
        protected int employeeNumber;
        protected string specialtyArea;
        protected string department;

        public string EmployeeName { get; set; }
        public int EmployeeNumber { get; set; }


        public Hospital_Employee()
        {

        }
            

        public Hospital_Employee(string employeeName, int employeeNumber)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
        }




    }
}

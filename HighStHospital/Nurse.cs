using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospital
{
    class Nurse : Hospital_Employee
    {

        public int numberOfPatients;



        public Nurse(string employeeName, int employeeNumber, int numberOfPatients, string department)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.numberOfPatients = numberOfPatients;
            this.department = department;
        }





    }
}

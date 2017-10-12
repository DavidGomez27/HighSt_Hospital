using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospital
{
    class Receptionist : Hospital_Employee
    {

        public bool onPhone;



        public Receptionist(string employeeName, int employeeNumber, string department, bool onPhone)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.onPhone = onPhone;
          
        }





    }
}

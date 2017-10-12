using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospital
{
    class Surgeon : Hospital_Employee
    {

        public bool isOperating;




        public Surgeon(string employeeName, int employeeNumber, string specialtyArea, bool isOperating)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
            this.isOperating = isOperating;

        }







    }
}

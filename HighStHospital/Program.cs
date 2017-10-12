﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospital
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("High St Hospital Employees \n");

            Doctor doctor1 = new Doctor("Dr Gomez", 7832, "Pediatrics\n");
            Console.WriteLine(doctor1.GetInfo());

            Surgeon surgeon1 = new Surgeon("Dr Dyko", 8724, "Liver", true);
            Console.WriteLine(surgeon1.GetInfo());

            Nurse nurse1 = new Nurse("\nNurse Brown", 9901, "Maternity", 6);
            Console.WriteLine(nurse1.GetInfo());

            Receptionist receptionist1 = new Receptionist("\nMs. Nelson", 4421, "ER", true);
            Console.WriteLine(receptionist1.GetInfo());





        }
    }
}

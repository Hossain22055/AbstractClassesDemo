using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
   abstract class Vehicle
    {
        public string Year { get; set; } = "2020";
        public string Make { get; set; } = "Default";
        public string Modle { get; set; } = "Default";


        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($" This {GetType().Name} is virtual in drive");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        public Car()
        {

        }
        public bool HasTrunk { get; set; } = true;

        public override void DriveAbstract()
        {
            throw new NotImplementedException();
        }
    }
}

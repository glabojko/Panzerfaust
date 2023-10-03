using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panzerfaust
{
    public class Vehicle
    {
        int RegistrationNumber { get; set; }

        public Vehicle(int registrationNumber)
        {
            RegistrationNumber = registrationNumber;
        }
    }
}

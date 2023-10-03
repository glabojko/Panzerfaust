using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panzerfaust
{
    public class Truck : Vehicle
    {
        int MaxSpeed {  get; set; }

        public Truck(int registrationNumber, int maxSpeed) : base(registrationNumber)
        {
            MaxSpeed = maxSpeed;
        }
    }
}

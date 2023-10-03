using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panzerfaust
{
    public class Tank : Vehicle
    {
        int MaxSpeed { get; set; }
        int FirePower { get; set; }

        public Tank(int registrationNumber, int maxSpeed, int firePower) : base (registrationNumber)
        {
            MaxSpeed = maxSpeed;
            FirePower = firePower;
        }
    }
}

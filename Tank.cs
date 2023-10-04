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
        public List<Panzer> panzers;

        public Tank(int registrationNumber, int maxSpeed, int firePower) : base (registrationNumber)
        {
            MaxSpeed = maxSpeed;
            FirePower = firePower;
            panzers = new List<Panzer>();
        }

        public void AddPanzer(Panzer panzer)
        {
            panzers.Add(panzer);
        }

        public string ShowParameters()
        {
            Console.Write($"We have {FirePower} points of fire power, and {MaxSpeed} km/h maximum speed. ");
            if (panzers.Count > 4)
            {
                return "Our tank stuff is complete";
            }
            else
            {
                return $"Herzlich wilkomenn im unsere TANK, wir sind: {panzers.Count} zusammen.";
            }
        }
    }
}

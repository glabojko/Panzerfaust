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
        public List<Infantry> infantrys;

        public Truck(int registrationNumber, int maxSpeed) : base(registrationNumber)
        {
            MaxSpeed = maxSpeed;
            infantrys = new List<Infantry>();
        }
        public void AddInfantry(Infantry infantry)
        {
            infantrys.Add(infantry);
        }

        public string ShowParameters()
        {
            Console.Write($"We can drive at {MaxSpeed} km/h maximum, and ");
            if (infantrys.Count > 5)
            {
                return "our truck stuff is complete";
            }
            else
            {
                return $"Herzlich wilkomenn im unsere TRUCK, wir sind: {infantrys.Count} zusammen.";
            }
        }
    }
}

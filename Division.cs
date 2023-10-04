using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panzerfaust
{
    public class Division
    {
        public string Name { get; set; }
        public List<Tank> tanks;
        public List<Truck> trucks;
        public List<Gunner> gunners;
        

        public Division(string name)
        {
            tanks = new List<Tank>();
            trucks = new List<Truck>();
            gunners = new List<Gunner>();
            Name = name;
        }


        public void AddTank(Tank tank)
        {
            tanks.Add(tank);
        }

        public void AddTruck(Truck truck)
        {
            trucks.Add(truck);
        }

        public void AddGunner(Gunner gunner)
        {
            gunners.Add(gunner);
        }

        public string ShowPower()
        {
            return $"Our division name is: {Name}.\n" +

                    $"We have: {tanks[100]} tanks and: {trucks.ToString()} trucks.\n " +
                    $"And we have: {gunners[0]} gunners.\n\n";
            
        }

    }
}

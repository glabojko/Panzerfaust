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
        public List<Panzer> panzers;
        public List<Gunner> gunners;
        public List<Infantry> infantrys;

        public Division(string name)
        {
            tanks = new List<Tank>();
            trucks = new List<Truck>();
            panzers = new List<Panzer>();
            gunners = new List<Gunner>();
            infantrys = new List<Infantry>();
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

        public void AddPanzer(Panzer panzer)
        {
            panzers.Add(panzer);
        }

        public void AddGunner(Gunner gunner)
        {
            gunners.Add(gunner);
        }

        public void AddInfantry(Infantry infantry)
        {
            infantrys.Add(infantry);
        }
    }
}

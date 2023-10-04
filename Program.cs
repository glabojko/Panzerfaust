namespace Panzerfaust
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herzlich wilkommen im unsere Panzerfaust!");

            //Dictionary<string, Division> leibstandarteAdolfHitler = new Dictionary<string, Division>();
            //Dictionary<string, Division> dasReich = new Dictionary<string, Division>();

            var tank1 = new Tank(1, 40, 1500);
            var truck1 = new Truck(2, 80);
            var infantry1 = new Infantry(1);
            var gunner1 = new Gunner(1);
            var panzer1 = new Panzer(1);

            //więcej czołgów for

            var ah = new Division("leibstandarteAdolfHitler");

            ah.AddTank(tank1);
            ah.AddTruck(truck1);
            ah.AddInfantry(infantry1);
            ah.AddGunner(gunner1);
            ah.AddPanzer(panzer1);
        }
    }
}
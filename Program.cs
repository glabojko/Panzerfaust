namespace Panzerfaust
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herzlich wilkommen im unsere Panzerfaust!");

            //Dictionary<string, Division> leibstandarteAdolfHitler = new Dictionary<string, Division>();
            //Dictionary<string, Division> dasReich = new Dictionary<string, Division>();

            var tank = new Tank(1, 40, 1500);
            var truck = new Truck(2, 80);
            var infantry = new Infantry(1);
            var gunner = new Gunner(1);
            var panzer = new Panzer(1);
            

            var ah = new Division("leibstandarteAdolfHitler");

            for (int i = 0; i < 200; i++) { ah.AddTank(tank); }
            for (int i = 0; i < 350; i++) { ah.AddTruck(truck); }
            for (int i = 0; i < 320; i++) { ah.AddGunner(gunner); }
            for (int i = 0; i<4; i++) { tank.AddPanzer(panzer); }
            for (int i = 0; i<10; i++) { truck.AddInfantry(infantry);}

            var ds = new Division("Das reich");

            for (int i = 0; i < 200; i++) { ds.AddTank(tank); }
            for (int i = 0; i < 350; i++) { ds.AddTruck(truck); }
            for (int i = 0; i < 320; i++) { ds.AddGunner(gunner); }
            for (int i = 0; i < 4; i++) { tank.AddPanzer(panzer); }
            for (int i = 0; i < 10; i++) { truck.AddInfantry(infantry); }


            Console.WriteLine(tank.ShowParameters());
            Console.WriteLine(truck.ShowParameters());
            Console.WriteLine(ah.ShowPower());
            Console.WriteLine(ds.ShowPower());
        }
    }
}
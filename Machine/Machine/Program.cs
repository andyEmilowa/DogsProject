using System;
using System.Collections.Generic;

namespace Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMachine> machines = new List<IMachine>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input =="End")
                {
                    break;
                }
                switch (input)
                {
                    case "Car":
                        Car currentCar = new Car();
                        MachineOperator moc = new MachineOperator(currentCar);

                        //Console.WriteLine(moc.Start());
                        //Console.WriteLine(moc.Stop());
                        machines.Add(currentCar);
                        break;

                    case "Truck":
                       Truck currentTruck = new Truck();
                        MachineOperator mot = new MachineOperator(currentTruck);
                        Console.WriteLine(mot.Start());
                        Console.WriteLine(mot.Stop());
                        machines.Add(currentTruck);
                        break;
                    case "Airplane":
                        Airplane currentAirplane = new Airplane();
                        MachineOperator moa = new MachineOperator(currentAirplane);
                        Console.WriteLine(moa.Start());
                        Console.WriteLine(moa.Stop());
                        machines.Add(currentAirplane);
                        break;
                    case "Bus":
                        Bus currentBus = new Bus();
                        MachineOperator mob = new MachineOperator(currentBus);
                        Console.WriteLine(mob.Start());
                        Console.WriteLine(mob.Stop());
                        machines.Add(currentBus);
                        break;
                }
            }
        }
    }
}

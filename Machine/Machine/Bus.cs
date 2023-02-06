using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
    public class Bus: IMachine
    {
        public string MachineType { get; set; }
        public Bus()
        { this.MachineType = "Bus"; }
        public bool Start()
        {
            Console.WriteLine("Bus starting...");
            return true;
        }
        public bool Stop()
        {
            Console.WriteLine("Bus stopping...");
            return true;
        }
    }
}

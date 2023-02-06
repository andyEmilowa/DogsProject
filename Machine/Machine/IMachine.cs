using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
    public interface IMachine
    {
        string MachineType { get; set; }

        bool Start();
        bool Stop();
    }
}

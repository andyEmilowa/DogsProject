using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
    public class MachineOperator
    {
        private IMachine machine;

        public MachineOperator(IMachine entity)
        {
            this.Machine = entity;
        }

        public IMachine Machine
        {
            get { return this.machine; }
            set
            {
                this.machine = value;
                Console.WriteLine("Machine operator is operating:  " + value.MachineType);
            }
        }

        public bool Start()
        {
            return Machine.Start();
        }
         public bool Stop()
        {
            return Machine.Stop();
        }

        
    }
}

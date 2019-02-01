using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class SubsystemB : ISubsystem
    {
        public string Operation1()
        {
            return "b: operation1" + Environment.NewLine;
        }

        public string Operation2()
        {
            return "b: operation2" + Environment.NewLine;
        }
    }
}

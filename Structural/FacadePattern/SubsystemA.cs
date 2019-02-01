using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class SubsystemA : ISubsystem
    {
        public string Operation1()
        {
            return "a: operation1" + Environment.NewLine;
        }

        public string Operation2()
        {
            return "a: operation2" + Environment.NewLine;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class Facade
    {
        private ISubsystem subsystemA;
        private ISubsystem subsystemB;

        public Facade()
        {
            subsystemA = new SubsystemA();
            subsystemB = new SubsystemB();
        }
        public string Operation1()
        {
            return subsystemA.Operation1() + subsystemB.Operation1();
        }

        public string Operation2()
        {
            return subsystemA.Operation2() + subsystemB.Operation2();
        }
    }
}

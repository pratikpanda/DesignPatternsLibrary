﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Subject1 : ISubject
    {
        public string GetMessage()
        {
            return "subject1";
        }
    }
}

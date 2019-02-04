using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Factory : IFactory
    {
        public ISubject GetSubject(string subjectName)
        {
            ISubject subject = null;
            switch (subjectName)
            {
                case "subject1":
                    subject = new Subject1();
                    break;
                case "subject2":
                    subject = new Subject2();
                    break;
                default:
                    break;
            };
            return subject;
        }
    }
}

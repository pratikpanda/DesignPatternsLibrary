using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public enum AccessTypes
    {
        DenyAccess,
        AllowAccess
    }

    public class Proxy : ISubject
    {
        private AccessTypes accessType;
        private ISubject subject;
        public Proxy(AccessTypes accessType)
        {
            subject = new Subject();
            this.accessType = accessType;
        }

        public string GetData()
        {
            if (accessType == AccessTypes.AllowAccess)
            {
                return subject.GetData();
            }
            else
            {
                throw new Exception();
            }
        }
    }
}

using System;

namespace ProxyPattern
{
    public class Subject : ISubject
    {
        public string GetData()
        {
            return "message";
        }
    }
}

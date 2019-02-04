using System;

namespace DecoratorPattern
{
    public class Subject : ISubject
    {
        public string GetMessage()
        {
            return "message";
        }
    }
}

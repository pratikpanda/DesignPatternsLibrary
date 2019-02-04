using System;

namespace DecoratorPattern
{
    public class Decorator : ISubject
    {
        private ISubject subject;
        public Decorator(ISubject subject)
        {
            this.subject = subject;
        }

        public string GetMessage()
        {
            return "decorator " + subject.GetMessage();
        }
    }
}
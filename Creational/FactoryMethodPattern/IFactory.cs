using System;

namespace FactoryMethodPattern
{
    public interface IFactory
    {
        ISubject GetSubject(string subjectName);
    }
}

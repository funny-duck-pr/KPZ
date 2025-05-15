using System;
using System.Collections;

namespace Task5
{
    public interface IIterator
    {
        bool HasNext();
        LightNode Next();
    }
}
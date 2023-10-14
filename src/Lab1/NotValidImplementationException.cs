using System;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class NotValidImplementationException : Exception
{
    public NotValidImplementationException()
        : base("Not valid GetEnumerator() implementation")
    {
    }

    public NotValidImplementationException(string message)
        : base(message)
    {
    }

    public NotValidImplementationException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Exceptions;

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
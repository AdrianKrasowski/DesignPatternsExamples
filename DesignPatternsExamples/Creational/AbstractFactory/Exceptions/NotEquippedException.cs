using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.Creational.AbstractFactory.Exceptions
{
    public class NotEquippedException : Exception
    {
        public NotEquippedException() : base()
        {
        }

        public NotEquippedException(string message) : base(message)
        {
        }
    }
}
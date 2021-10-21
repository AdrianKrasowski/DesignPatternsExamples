using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.Creational.AbstractFactory.Exceptions
{
    public class NothingToBeUnatachedException : Exception
    {
        public NothingToBeUnatachedException() : base()
        {
        }

        public NothingToBeUnatachedException(string message) : base(message)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.Creational.AbstractFactory.Exceptions
{
    public class AlreadyAttachedException : Exception
    {
        public AlreadyAttachedException() : base()
        {
        }

        public AlreadyAttachedException(string message) : base(message)
        {
        }
    }
}
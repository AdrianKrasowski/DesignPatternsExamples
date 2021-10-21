using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.Creational.AbstractFactory.Exceptions
{
    public class WrongArmorClassException : Exception
    {
        public WrongArmorClassException() : base()
        {
        }

        public WrongArmorClassException(string message) : base(message)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.Creational.AbstractFactory.Exceptions
{
    public class AlreadyEquipedException : Exception
    {
        public AlreadyEquipedException() : base()
        {
        }

        public AlreadyEquipedException(string message) : base(message)
        {
        }
    }
}
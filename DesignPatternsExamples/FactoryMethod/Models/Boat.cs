using DesignPatternsExamples.FactoryMethod.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.FactoryMethod.Models
{
    public class Boat : ITransport
    {
        public string Name { get; private set; }

        public Boat()
        {
            Name = "Boat";
        }

        public void Deliver()
        {
            Swim();
        }

        private void Swim()
        {
        }
    }
}
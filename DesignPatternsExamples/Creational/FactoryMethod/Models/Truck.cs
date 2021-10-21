using DesignPatternsExamples.FactoryMethod.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.FactoryMethod.Models
{
    public class Truck : ITransport
    {
        public string Name { get; private set; }

        public Truck()
        {
            Name = "Truck";
        }

        public void Deliver()
        {
            GoDoTransport();
        }

        private void GoDoTransport()
        {
        }
    }
}
using DesignPatternsExamples.FactoryMethod.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.FactoryMethod.Abstract
{
    public abstract class Logistics
    {
        public ITransport Transport { get; private set; }

        public abstract ITransport FactoryMethod();

        public virtual string Deliver()
        {
            Transport = FactoryMethod();

            var result = $"Order was delivered with {Transport.Name}";
            Transport.Deliver();

            return result;
        }
    }
}
using DesignPatternsExamples.FactoryMethod.Abstract;
using DesignPatternsExamples.FactoryMethod.Models;
using DesignPatternsExamples.FactoryMethod.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.FactoryMethod
{
    public class SeaLogistics : Logistics
    {
        public override ITransport FactoryMethod()
        {
            return new Boat();
        }
    }
}
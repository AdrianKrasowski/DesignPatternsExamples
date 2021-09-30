using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.FactoryMethod.Models.Abstract
{
    public interface ITransport
    {
        string Name { get; }

        void Deliver();
    }
}
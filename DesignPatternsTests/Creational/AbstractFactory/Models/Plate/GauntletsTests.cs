using DesignPatternsExamples.Creational.AbstractFactory.Models.Plate;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatternsTests.Creational.AbstractFactory.Models.Plate
{
    public class GauntletsTests : Gauntlets
    {
        [Fact]
        public void AttachedGauntletsShouldReturnFalseOnAttach()
        {
            //Arrange
            this.IsAttached = true;

            //Act
            var result = this.Attach();

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void UnattachedGauntletsShouldReturnTrueOnAttach()
        {
            //Arrange
            this.IsAttached = false;

            //Act
            var result = this.Attach();

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void UnattachedGauntletsShouldReturnFalseOnDetach()
        {
            //Arrange
            this.IsAttached = false;

            //Act
            var result = this.Detach();

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void AttachedGauntletsShouldReturnTrueOnDetach()
        {
            //Arrange
            this.IsAttached = true;

            //Act
            var result = this.Detach();

            //Assert
            Assert.True(result);
        }
    }
}
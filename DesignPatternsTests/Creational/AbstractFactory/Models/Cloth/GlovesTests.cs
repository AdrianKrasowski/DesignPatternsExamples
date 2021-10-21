using DesignPatternsExamples.Creational.AbstractFactory.Models.Cloth;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatternsTests.Creational.AbstractFactory.Models.Cloth
{
    public class GlovesTests : Gloves
    {
        [Fact]
        public void AttachedGlovesShouldReturnFalseOnAttach()
        {
            //Arrange
            this.IsAttached = true;

            //Act
            var result = this.Attach();

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void UnattachedGlovesShouldReturnTrueOnAttach()
        {
            //Arrange
            this.IsAttached = false;

            //Act
            var result = this.Attach();

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void UnattachedGlovesShouldReturnFalseOnDetach()
        {
            //Arrange
            this.IsAttached = false;

            //Act
            var result = this.Detach();

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void AttachedGlovesShouldReturnTrueOnDetach()
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
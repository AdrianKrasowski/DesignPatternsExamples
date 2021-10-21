using DesignPatternsExamples.Creational.AbstractFactory.Exceptions;
using DesignPatternsExamples.Creational.AbstractFactory.Models.Cloth;
using DesignPatternsExamples.Creational.AbstractFactory.Models.Plate;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatternsTests.Creational.AbstractFactory.Models.Cloth
{
    public class RobeTest : Robe
    {
        [Fact]
        public void ShouldThrowArmorClassExceptionWhenTryToAttachGauntlets()
        {
            //Arrange
            var glovesName = "Gloves";
            var Gloves = new Gauntlets(10, glovesName, "Desc");

            //Act
            Assert.Throws<WrongArmorClassException>(() => this.AttachGloves(Gloves));
        }

        [Fact]
        public void WhenGlovesAlreadyAttahcedAttachGlovesShouldThrowAlreadyAttachedException()
        {
            //Arrange
            var glovesName = "Gloves";
            var Gloves = new Gloves(10, glovesName, "Desc");
            Gloves.Attach();
            this.Gauntlets = Gloves;

            //Act
            Assert.Throws<AlreadyAttachedException>(() => this.AttachGloves(Gloves));
        }

        [Fact]
        public void WhenGlovesAreNotAttachedSHouldSuccesfullyAttahcGloves()
        {
            //Arrange
            var glovesName = "Gloves";
            var robeName = "Robe";
            this.Name = robeName;
            var Gloves = new Gloves(10, glovesName, "Desc");
            var expectedResult = $"{glovesName} has been attached to {robeName}";

            //Act
            var result = this.AttachGloves(Gloves);

            //Assert

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void WhenNoGlovesAttachedOnDettachShouldThrowNothingToUnattachException()
        {
            Assert.Throws<NothingToBeUnatachedException>(() => this.DetachGloves());
        }

        [Fact]
        public void WhenGlovesEquippedDwetachShouldDetachGlovesSuccessfully()
        {
            //Arrange
            var glovesName = "Gloves";
            var Gloves = new Gloves(10, glovesName, "Desc");
            Gloves.Attach();
            this.Gauntlets = Gloves;
            var expectedResult = $"{glovesName} successfully detached";

            //Act
            var result = this.DetachGloves();

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
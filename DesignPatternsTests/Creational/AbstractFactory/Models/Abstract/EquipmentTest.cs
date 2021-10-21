using DesignPatternsExamples.Creational.AbstractFactory.Exceptions;
using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatternsTests.Creational.AbstractFactory.Models.Abstract
{
    public class EquipmentTest : Equipment
    {
        [Fact]
        public void EquipedPartShouldThrowAlreadyEquipedExceptionOnEquip()
        {
            //Arrange
            var hatName = "ExampleHat";
            this.Name = hatName;
            this.IsEquiped = true;

            //Act
            Assert.Throws<AlreadyEquipedException>(() => this.Equip());
        }

        [Fact]
        public void UnEquipedPartShouldBeEquipedSuccesfullyOnEquip()
        {
            //Arrange
            var hatName = "ExampleHat";
            this.Name = hatName;
            this.IsEquiped = false;
            var expectedResult = $"{Name} has been equiped";

            //Act
            var result = this.Equip();

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void EquipedPartShouldUnequipedSuccesfullyOnUnEquip()
        {
            //Arrange
            var hatName = "ExampleHat";
            this.Name = hatName;
            this.IsEquiped = true;
            var expectedResult = $"{Name} has been unequipped";

            //Act
            var result = this.Uneqip();

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void NotEquipedPartShouldThrowNottEquippedExceptionOnUnequip()
        {
            //Arrange
            var hatName = "ExampleHat";
            this.Name = hatName;
            this.IsEquiped = false;
            var expectedResult = $"{Name} has been unequiped";

            //Act
            Assert.Throws<NotEquippedException>(() => this.Uneqip());
        }
    }
}
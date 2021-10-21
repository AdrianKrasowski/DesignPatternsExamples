using DesignPatternsExamples.Creational.AbstractFactory;
using DesignPatternsExamples.Creational.AbstractFactory.Models.Cloth;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatternsTests.Creational.AbstractFactory
{
    public class ClothEquipmentFactoryTest
    {
        [Fact]
        public void CreateHelmetShouldReturnHat()
        {
            //Arrange
            var _uut = new ClothEquipmentFactory();

            //Act
            var product = _uut.CreateHelmet(10, "hat", "Some hat");

            //Assert
            Assert.IsType<Hat>(product);
        }

        [Fact]
        public void CreateGauntletsShouldReturnGloves()
        {
            //Arrange
            var _uut = new ClothEquipmentFactory();

            //Act
            var product = _uut.CreateGauntlets(10, "gloves", "Some gloves");

            //Assert
            Assert.IsType<Gloves>(product);
        }

        [Fact]
        public void CreateBodyShouldReturnRobe()
        {
            //Arrange
            var _uut = new ClothEquipmentFactory();

            //Act
            var product = _uut.CreateBody(10, "robe", "Some robe");

            //Assert
            Assert.IsType<Robe>(product);
        }
    }
}
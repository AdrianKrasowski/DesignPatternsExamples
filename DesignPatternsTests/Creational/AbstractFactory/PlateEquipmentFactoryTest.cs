﻿using DesignPatternsExamples.Creational.AbstractFactory;
using DesignPatternsExamples.Creational.AbstractFactory.Models.Plate;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatternsTests.Creational.AbstractFactory
{
    public class PlateEquipmentFactoryTest
    {
        [Fact]
        public void CreateHelmetShouldReturnPlateHelmet()
        {
            //Arrange
            var _uut = new PlateEquipmentFactory();

            //Act
            var product = _uut.CreateHelmet(10, "PlateHelmet", "Some PlateHelmet");

            //Assert
            Assert.IsType<PlateHelmet>(product);
        }

        [Fact]
        public void CreateGauntletsShouldReturnGauntlets()
        {
            //Arrange
            var _uut = new PlateEquipmentFactory();

            //Act
            var product = _uut.CreateGauntlets(10, "Gauntlets", "Some Gauntlets");

            //Assert
            Assert.IsType<Gauntlets>(product);
        }

        [Fact]
        public void CreateBodyShouldReturnPlateArmor()
        {
            //Arrange
            var _uut = new PlateEquipmentFactory();

            //Act
            var product = _uut.CreateBody(10, "PlateArmor", "Some PlateArmor");

            //Assert
            Assert.IsType<PlateArmor>(product);
        }
    }
}
using System;
using Trucks.Domain.Entities;
using Trucks.Domain.Enums;
using Xunit;

namespace Trucks.Tests.Domain.Entities
{
    public class TruckTest
    {
        [Fact]
        public void When_truck_has_manufacture_year_and_model_year_equals_current_year_returns_true()
        {
            //Arrange
            var currentYear = DateTime.Now.Year;
            var truck = new Truck("New Truck", "blue", currentYear, currentYear, TruckModelEnum.FM);

            //Act
            var isValid = truck.IsValid();

            //Assert
            Assert.True(isValid);
        }

        [Fact]
        public void When_truck_has_manufacture_year_equals_current_year_and_model_year_equals_next_year_returns_true()
        {
            //Arrange
            var currentYear = DateTime.Now.Year;
            var truck = new Truck("New Truck", "blue", currentYear, currentYear +1, TruckModelEnum.FM);

            //Act
            var isValid = truck.IsValid();

            //Assert
            Assert.True(isValid);
        }

        [Fact]
        public void When_truck_has_manufacture_year_not_equals_current_year_returns_false()
        {
            //Arrange
            var currentYear = DateTime.Now.Year;
            var truck = new Truck("New Truck", "blue", currentYear -1, currentYear, TruckModelEnum.FM);

            //Act
            var isValid = truck.IsValid();

            //Assert
            Assert.False(isValid);
        }

        [Fact]
        public void When_truck_has_model_year_not_equals_current_year_or_next_year_returns_false()
        {
            //Arrange
            var currentYear = DateTime.Now.Year;
            var truck = new Truck("New Truck", "blue", currentYear, currentYear -1, TruckModelEnum.FM);

            //Act
            var isValid = truck.IsValid();

            //Assert
            Assert.False(isValid);
        }

        [Fact]
        public void When_truck_has_model_equals_FM_returns_true()
        {
            //Arrange
            var currentYear = DateTime.Now.Year;
            var truck = new Truck("New Truck", "blue", currentYear, currentYear, TruckModelEnum.FM);

            //Act
            var isValid = truck.IsValid();

            //Assert
            Assert.True(isValid);
        }

        [Fact]
        public void When_truck_has_model_equals_FH_returns_true()
        {
            //Arrange
            var currentYear = DateTime.Now.Year;
            var truck = new Truck("New Truck", "blue", currentYear, currentYear, TruckModelEnum.FM);

            //Act
            var isValid = truck.IsValid();

            //Assert
            Assert.True(isValid);
        }

        [Fact]
        public void When_truck_has_model_equals_OTHERS_returns_false()
        {
            //Arrange
            var currentYear = DateTime.Now.Year;
            var truck = new Truck("New Truck", "blue", currentYear, currentYear, TruckModelEnum.OTHERS);

            //Act
            var isValid = truck.IsValid();

            //Assert
            Assert.False(isValid);
        }
    }
}
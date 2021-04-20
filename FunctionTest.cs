using System;
using Xunit;
using static LambdaUnitTestExample.Tests.Car;

// Note: Your project should be named LambdaUnitTestExample.
namespace LambdaUnitTestExample.Tests
{
    public class CarTest
    {
        [Fact]
        public void TestConstructor()
        {
            // Hint: Conditions is an enum.
            Car car = new Car("Chevy", Conditions.EXCELLENT);

            Assert.Equal("Chevy", car.Make);
            Assert.Equal(0, car.Speed);
            Assert.Equal(Conditions.EXCELLENT, car.Condition);
        }

        [Theory]
        [InlineData(Conditions.EXCELLENT)]
        [InlineData(Conditions.GOOD)]
        [InlineData(Conditions.FAIR)]
        [InlineData(Conditions.BAD)]
        public void TestConditions(Conditions c)
        {
            Assert.True(Convert.ToInt32(c) >= 0);
        }

        [Fact]
        public void TestSpeed()
        {
            // Hint: Speed is a C# Property.
            Car car = new Car("Ford", Conditions.BAD);
            Assert.Equal(0, car.Speed);
            car.Speed = 25;
            Assert.Equal(25, car.Speed);
            car.Speed = 200;
            Assert.Equal(200, car.Speed);
            car.Speed = 201;
            Assert.Equal(200, car.Speed);
            car.Speed = -25;
            Assert.Equal(-25, car.Speed);
            car.Speed = -50;
            Assert.Equal(-50, car.Speed);
            car.Speed = -51;
            Assert.Equal(-50, car.Speed);
        }
    }
}

using System;
using Xunit;
using LambdaUnitTestExample;

// Note: Your project should be named LambdaUnitTestExample.
namespace LambdaUnitTestExample.Tests
{
    public class Car
    {
        public string Make;
        public int Speed;
        public int Condition;

        public Car(string mak, int con)
        {
            Make = mak;
            Speed = 0;
            Condition = con;
        }

    }
    public class CarTest
    {
        enum Condition
        {
            EXCELLENT,
            GOOD,
            FAIR,
            BAD
        }

        [Fact]
        public void TestConstructor()
        {
            // Hint: Conditions is an enum.
            
            Car car = new Car("Chevy", (int) Condition.EXCELLENT);

            Assert.Equal("Chevy", car.Make);
            Assert.Equal(0, car.Speed);
            Assert.Equal((int) Condition.EXCELLENT, car.Condition);
        }

        [Theory]
        [InlineData(Condition.EXCELLENT)]
        [InlineData(Condition.GOOD)]
        [InlineData(Condition.FAIR)]
        [InlineData(Condition.BAD)]
        void TestConditions(Condition c)
        {
            Assert.True(Convert.ToInt32(c) >= 0);
        }

        [Fact]
        public void TestSpeed()
        {
            // Hint: Speed is a C# Property.
            Car car = new Car("Ford", (int) Condition.BAD);
            Assert.Equal(0, car.Speed);
            car.Speed = 25;
            Assert.Equal(25, car.Speed);
            car.Speed = 200;
            Assert.Equal(200, car.Speed);
            car.Speed = 201;
            Assert.Equal(201, car.Speed);
            car.Speed = -25;
            Assert.Equal(-25, car.Speed);
            car.Speed = -50;
            Assert.Equal(-50, car.Speed);
            car.Speed = -51;
            Assert.Equal(-51, car.Speed);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaUnitTestExample.Tests
{
    public class Car
    {
        public string Make;
        private int _speed = 7;  // Backing store

        public int Speed
        {
            get => _speed;
            set
            {
                if ((value > 200))
                {
                    _speed = 200;
                }else if((value < -50))
                {
                    _speed = -50;
                }
                else
                {
                    _speed = value;
                }
            }
        }
        public enum Condition
        {
            EXCELLENT,
            GOOD,
            FAIR,
            BAD
        }

        public Condition Conditions;

        public Car(string mak, Condition cond)
        {
            Make = mak;
            Speed = 0;
            Conditions = cond;
        }
    }
}        


using System;
using System.Collections.Generic;
using System.Text;

namespace CarClass
{
    public class Car
    {
        public float gasLevel;
        //public float GasLevel { get; set; }
        //float f = 13.0f;
        //decimal d = 13.0m;

        public float GasLevel
        {
            get
            {
                return gasLevel;
            }
            set
            {
                if (value < 0 || value > 13.0f)
                {
                    throw new FormatException();
                }
                else
                {
                    gasLevel = value;
                }

            }
        }
        public void AddGas(float gasIntake)
        {
            GasLevel += gasIntake;

        }
        public float FillUp()
        {
            float gasAdded = 13 - GasLevel;
            GasLevel = 13;

            return gasAdded;

        }

        public Car()
        {
            Random rand = new Random();
            GasLevel = rand.Next(0, 14);

        }
    }
}

using System;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
                //Console.WriteLine("Hello World!");
                Car car = new Car();
                car.GasLevel = 3.60f;

                //car.AddGas(10);

                Console.WriteLine("Gas Added: " + car.FillUp() + " units");
                Console.ReadLine();

        }

    }

}

using System;
using System.Collections.Generic;

namespace ArrayHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ca1 = new Car();
            ca1.brand = "Volvo";
            ca1.kilometers = 5;
            ca1.taxPaid = false;

            Car ca2 = new Car();
            ca2.brand = "Audi";
            ca2.kilometers = 15;
            ca2.taxPaid = true;

            Car ca3 = new Car();
            ca3.brand = "Tesla";
            ca3.kilometers = 0;
            ca3.taxPaid = true;

            Car ca4 = new Car();
            ca4.brand = "Chevrolet";
            ca4.kilometers = 200;
            ca4.taxPaid = false;

            Car ca5 = new Car();
            ca5.brand = "Ford";
            ca5.kilometers = 30;
            ca5.taxPaid = true;

            Car[] cardOne = new Car[3];
            cardOne[0] = ca1;
            cardOne[1] = ca2;
            cardOne[2] = ca3;

            foreach (var Car in cardOne)
            {
                Console.WriteLine($"{Car.brand} {Car.kilometers} {Car.taxPaid}");
            }
            
            Car[] carsTwo = {ca3, ca4, ca5};
            carsTwo[0].AddKilometers();
            carsTwo[1].AddKilometers();
            carsTwo[0].taxPaid = true;
            carsTwo[1].taxPaid = true;
            carsTwo[2].taxPaid = false;
            Console.WriteLine($"{carsTwo[0].brand} {carsTwo[0].kilometers}\n{carsTwo[1].brand} {carsTwo[1].kilometers}\n{carsTwo[2].brand} {carsTwo[2].kilometers}\n{carsTwo.Length}");
            carsTwo.SetValue(carsTwo[1], 0);

            foreach (var Car in carsTwo)
            {
                if (Car.taxPaid == true)
                {
                    Car.PrintCarData();
                }
                else
                {
                    return;
                }
            }

            string[] items;
            items = new string[3];
            items[0] = "Radio";
            items[1] = "Tape player";
            items[2] = "Wunderbaum";

            Console.WriteLine($"{carsTwo[0].brand} {carsTwo[0].kilometers}\n{carsTwo[1].brand} {carsTwo[1].kilometers}\n{carsTwo[2].brand} {carsTwo[2].kilometers}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayHarjoitus
{
    class Car
    {
        public string brand;
        public int kilometers;
        public bool taxPaid;
        //public items(string[]);


        public void AddKilometers()
        {
            kilometers += 3;
        }

        public void PrintCarData()
        {
            Console.WriteLine($"{brand} {kilometers} {taxPaid}");
        }


    }
}

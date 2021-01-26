using System;
using System.Collections.Generic;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Ulasim> ulasim = new List<Ulasim> {new Uçak(),new Araba(),new Motor()};

            AracManager manager = new AracManager();


            manager.Araclar(ulasim);

        }
    }
}

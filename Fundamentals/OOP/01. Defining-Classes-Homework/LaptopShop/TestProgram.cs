﻿using LaptopShop.Classes;
using System;
namespace LaptopShop
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Battery myBattery = new Battery("Li-Ion, 4-cells, 2550 mAh", 45);
            Laptop firstLaptop = new Laptop("Lenovo Yoga 2 Pro", "Lenovo"
                , "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)"
                , 8
                , "Intel HD Graphics 4400"
                , "128GB SSD"
                , "13.3 (33.78 cm) – 3200 x 1800(QHD +), IPS sensor display"
                , myBattery
                ,2259.00m);
            Laptop secondLaptop = new Laptop("Apple", 1234124.13513m);
            Console.WriteLine(firstLaptop);
            Console.WriteLine(secondLaptop);
        }
    }
}

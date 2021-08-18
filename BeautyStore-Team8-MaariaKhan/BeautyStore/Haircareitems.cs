using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyStore
{
    class Haircareitems
    {
        public string opt3 = "";
        public int qnty = 0;
        public string opt4 = "";

        public void MyHair(string opt2)
        {
            switch (opt2)
            {
                case "1":
                    //SHampoo
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Loreal Professional Serie Expert      ");
                    Console.WriteLine("     2.Mama Earth Rice Water Shampoo       ");
                    Console.WriteLine("     3.Tresemme Keratin Smooth       ");
                    Console.WriteLine("     4.Mamaearth Onion Shampoo      ");
                    Console.WriteLine("     5.Wella Professionals       ");
                    Console.WriteLine("     6.GK Hair Balancing Shampoo      ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "2":
                    //Conditioner
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Loreal Paris Rapid Reviver      ");
                    Console.WriteLine("     2.Sebastian Professional Penetraitt   ");
                    Console.WriteLine("     3.Matrix Opti Care    ");
                    Console.WriteLine("     4.Herbal Essences");
                    Console.WriteLine("     5.Loreal Paris Dream Lengths    ");
                    Console.WriteLine("     6.Dove Intense Repair Conditioner    ");
                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "3":
                    //Hair Oil
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Mamaearth Rice Hair Oil      ");
                    Console.WriteLine("     2.Moroccanoil Treatment Oil   ");
                    Console.WriteLine("     3.Forest Essential Oil    ");
                    Console.WriteLine("     4.Indulekha Bringha Hair Oil     ");
                    Console.WriteLine("     5.Max Care Virgin Coconut Oil   ");
                    Console.WriteLine("     6.Wella Professional Luminous Oil    ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "4":
                    //Hair Serum
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Livion Serum     ");
                    Console.WriteLine("     2.Streax Professional Serum   ");
                    Console.WriteLine("     3. Matrix Opti Care Professional Serum   ");
                    Console.WriteLine("     4.LOreal Paris Total Repair 5 Serum    ");
                    Console.WriteLine("     5.Tresemme Keratin Smooth Hair Serum   ");
                    Console.WriteLine("     6.Matrix Biolage Serum   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "5":
                    //Hair Serum
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Livion Serum     ");
                    Console.WriteLine("     2.Streax Professional Serum   ");
                    Console.WriteLine("     3. Matrix Opti Care Professional Serum   ");
                    Console.WriteLine("     4.LOreal Paris Total Repair 5 Serum    ");
                    Console.WriteLine("     5.Tresemme Keratin Smooth Hair Serum   ");
                    Console.WriteLine("     6.Matrix Biolage Serum   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "6":
                    //Hair Color
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Biotique Herb Hair Color     ");
                    Console.WriteLine("     2.Streax Coffee Collection   ");
                    Console.WriteLine("     3.Revlon Colorsilk Hair Color   ");
                    Console.WriteLine("     4.Godrej Nupur Henna    ");
                    Console.WriteLine("     5.Joves Herbal Henna   ");
                    Console.WriteLine("     6.LOreal Paris Casting Creme Gloss");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "7":
                    //Hair Masks
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Tresemme Deep Smoothing Mask     ");
                    Console.WriteLine("     2.Mamaearth Argan Hair Mask   ");
                    Console.WriteLine("     3.SP Luxe Oil Keratin Restore Mask   ");
                    Console.WriteLine("     4.Wella Professionals Renewing Mask    ");
                    Console.WriteLine("     5.Dove Intense Damage Repair Hair Mask   ");
                    Console.WriteLine("     6.Mamaearth Rice Water Hair Mask");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Sorry you entered the wrong option! ");
                    break;

            }

        }


    }

}
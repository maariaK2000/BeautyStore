using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyStore
{ 
    public class Appliancesitems
    {
         public string opt3 = "";
         public int qnty = 0;
         public string opt4 = "";

        public void MyAppliances(string opt2)
        {
            switch (opt2)
            {
                case "1":
                    //Hair straightner
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Philips Selfie Straightner      ");
                    Console.WriteLine("     2.VEGA Adore Flat Hair Straightner       ");
                    Console.WriteLine("     3.Babyliss Hair Straightner       ");
                    Console.WriteLine("     4.Agaro Instastraight Hair Straightner      ");
                    Console.WriteLine("     5.Dyson Coralle Hair Straightner     ");
                    Console.WriteLine("     6.Philips Advanced KeraShine Straightner      ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;


                case "2":
                    //Hair Dryer
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Ikonic Professional Superstar Hair Dryer      ");
                    Console.WriteLine("     2.Agaro Salon Style Hair Dryer   ");
                    Console.WriteLine("     3.Philips Hair Dryer    ");
                    Console.WriteLine("     4.VEGA Blooming Hair Dryer");
                    Console.WriteLine("     5.Dyson Supersonic Hair Dryer    ");
                    Console.WriteLine("     6.BaByliss Hair Dryer    ");
                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;

                case "3":
                    //Face Epilator continue yaha se
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
                    //Shavers
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
                    //Trimmers
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
                    //Hair Curler
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
                default:
                    Console.WriteLine("Sorry you entered the wrong option! ");
                    break;




            }
        }

    }

}

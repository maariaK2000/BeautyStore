using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyStore
{
    class SkinCare
    {
        /*int tonertotal = 100;
        int cleansertotal = 100;
        int moisturizertotal = 100;
        int masktotal = 100;

        int mytonerqnty;
        int mycleanserqnty;
        int mymoisturizerqnty;
        int mymaskqnty;*/

        /*public string opt3 = "";
        public int qnty = 0;
        public string opt4 = "";*/

        public string Toner { get; set; }
        public string Cleanser { get; set; }

        public string Moisturizer { get; set; }
        public string Mask { get; set; }
        public void MySkin(string opt2)
        {
            
            switch (opt2)
            {
                case "1":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Forest Essentials      ");
                    Console.WriteLine("     2.Tea Tree       ");
                    Console.WriteLine("     3.Mamaearth Vitamin C       ");
                    Console.WriteLine("     4.PIXI Glow Tonic      ");
                    Console.WriteLine("     5.Lakme Absolute Pore Fix Toner      ");
                    Console.WriteLine("     6.Kama Ayurveda      ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "2":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Micellar      ");
                    Console.WriteLine("     2.Moms Co.Natural   ");
                    Console.WriteLine("     3.Neutrogena    ");
                    Console.WriteLine("     4.Cetaphil    ");
                    Console.WriteLine("     5.Plum Green tree    ");
                    Console.WriteLine("     6.Garnier Skin Naturals    ");
                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Simple Kind      ");
                    Console.WriteLine("     2.Revitalift   ");
                    Console.WriteLine("     3.Estee Lauder    ");
                    Console.WriteLine("     4.Minimalist      ");
                    Console.WriteLine("     5.Klairs Freshly Juiced   ");
                    Console.WriteLine("     6.Clinique Moisture Surge    ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "4":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Snail Sheet Mask     ");
                    Console.WriteLine("     2.TonyMolly Mask   ");
                    Console.WriteLine("     3.Innisfree Volcanic Pore Clay   ");
                    Console.WriteLine("     4.The Face Shop Real Nature Red Ginseng Face Mask     ");
                    Console.WriteLine("     5.Prolixr Detoxifying Sea Algae Mask   ");
                    Console.WriteLine("     6.MCaffeine Deep Pore Cleansing Regime   ");

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


    /*enum Toner
    {
        ForestEssentials, TeaTree, MamaearthVitaminC, PIXIGlowTonic, LakmeAbsolutePoreFixToner, KamaAyurveda
    }
    enum Cleanser
    {
         Micellar, MomsCoNatural, Neutrogena, Cetaphil, PlumGreentree, GarnierSkinNaturals
    }
    enum Moisturizer
    {
        SimpleKind, Revitalift, EsteeLauder, Minimalist, KlairsFreshlyJuiced, CliniqueMoistureSurge
    }
    enum Mask
    {
        SnailSheetMask, TonyMollyMask, InnisfreeVolcanicPoreClay, TheFaceShopRealNatureRedGinsengFaceMask, ProlixrDetoxifyingSeaAlgaeMask, MCaffeineDeepPoreCleansingRegime
    }*/

}

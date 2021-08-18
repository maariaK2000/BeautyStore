using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyStore
{
    public class Makeupitems
    {
        public string opt3 = "";
        public int qnty = 0;
        public string opt4 = "";


        public void MyFace(string opt3)
        {
            switch (opt3)
            {
                case "1":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.LOreal Paris Infallible     ");
                    Console.WriteLine("     2.Kay Beauty Hydrating Foundation   ");
                    Console.WriteLine("     3.Maybelline New York Fit me Foundation   ");
                    Console.WriteLine("     4.Huda Beauty Fauxfilter     ");
                    Console.WriteLine("     5.Charlotte Tilbury Hollywood Filter   ");
                    Console.WriteLine("     6.M.A.C Studio Fix Fuild   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    //FoundationCart(opt4, qnty);
                    break;
                case "2":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Maybelline New York Fit me Concealer     ");
                    Console.WriteLine("     2.L.A. Girl   ");
                    Console.WriteLine("     3.Charlotte Tilbury Magic Away Liquid Concealer   ");
                    Console.WriteLine("     4.Smashbox Studio     ");
                    Console.WriteLine("     5.PAC Spotlight Liquid Concealer   ");
                    Console.WriteLine("     6.Swiss Beauty Liquid Concealer   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.BECCA Ignite Liquified Light Hightlighter     ");
                    Console.WriteLine("     2.Huda Beauty 3D Highlighter   ");
                    Console.WriteLine("     3.Kay Beauty Illuminating Hightlighter   ");
                    Console.WriteLine("     4.Swiss Beauty Drop and Glow Liquid Highlighter     ");
                    Console.WriteLine("     5.M.A.C Mineralize Skinfinish  ");
                    Console.WriteLine("     6.Swiss Beauty Brick Highlighter   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "4":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Maybelline New York Fit Me Oil Control     ");
                    Console.WriteLine("     2.Kay Beauty Matte Compact   ");
                    Console.WriteLine("     3.Faces Canada Compact   ");
                    Console.WriteLine("     4.LOreal Paris Infalliable Pro Matte Powder     ");
                    Console.WriteLine("     5.Lakme Absolute Compact  ");
                    Console.WriteLine("     6.Bobbi Brown Sheer Finish Powder   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Sorry you entered the wrong option! ");
                    break;

            }

        }
        public void MyEyes(string opt3)
        {
            switch (opt3)
            {
                case "1":
                    //kajal
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Lakme Eyeconic Kajal     ");
                    Console.WriteLine("     2.Swiss Beauty Deep Black Kajal   ");
                    Console.WriteLine("     3.Maybelline New York Colossal Kajal   ");
                    Console.WriteLine("     4.Chambor Extreme Eyes Kajal     ");
                    Console.WriteLine("     5.Colorbar Intensely Rich Kajal   ");
                    Console.WriteLine("     6.SUGAR Khol Of Honour Intense Kajal   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    return;
                case "2":
                    //liner
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.LOreal Paris Super Liner     ");
                    Console.WriteLine("     2.Kay Beauty Quick Dry Liquid Eyeliner   ");
                    Console.WriteLine("     3.Lakme 9 to 5 Black Impact Eye Liner   ");
                    Console.WriteLine("     4.M.A.C Technakhol Liner     ");
                    Console.WriteLine("     5.Colorbar Waterproof Liquid Eyeliner   ");
                    Console.WriteLine("     6.Maybelline New York Collassal Bold Liner   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());

                    break;
                case "3":
                    //eyeshadow
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Makeup Revolution Eyeshadow Palette     ");
                    Console.WriteLine("     2.SUGAR Blend The Rules Eyeshadow Palette   ");
                    Console.WriteLine("     3.Miss Claire Makeup Studio Eyeshadow Palette    ");
                    Console.WriteLine("     4.Huda Beauty The Nude Eyeshadow Palette     ");
                    Console.WriteLine("     5.Kay Beauty Eyeshadow Palette  ");
                    Console.WriteLine("     6.Huda Beauty Pastel Obsessions Eyeshadow Palette   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Sorry you entered the wrong option! ");
                    break;

            }

        }

        public void MyLips(string opt3)
        {
            switch (opt3)
            {
                case "1":
                    //lipgloss
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.SUGAR Time To Shine Lip Gloss     ");
                    Console.WriteLine("     2.Lime Crime Wet Cherry Lip Gloss   ");
                    Console.WriteLine("     3.Miss Claire Pearly Gloss   ");
                    Console.WriteLine("     4.Bobbi Brown Crushed Oil Infused Gloss     ");
                    Console.WriteLine("     5.Lakme Absolute Plump And Shine Lip Gloss   ");
                    Console.WriteLine("     6.Rimmel London Oh My Gloss!   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "2":
                    //creamylipstick
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.MyGlamm LIT Creamy Matte Lipstick     ");
                    Console.WriteLine("     2.Kiko Milano Gossamer Emotion Creamy Lipstick   ");
                    Console.WriteLine("     3.SERY Say Cheez!   ");
                    Console.WriteLine("     4.Maybelline New York Color Sensational Creamy Lipstick     ");
                    Console.WriteLine("     5.SUGAR X Wonder Woman Creamy Lipstick   ");
                    Console.WriteLine("     6.Stars Cosmetics Lush Creamy Lipstick   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "3":
                    //mattelipstick
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Kay Beauty Long Stay Matte Lipstick     ");
                    Console.WriteLine("     2.Elle 18 Color Pops Matte Lipstick   ");
                    Console.WriteLine("     3.Huda Beauty Power Bullet Matte Lipstick    ");
                    Console.WriteLine("     4.Swiss Beauty Pure Matte Lipstick     ");
                    Console.WriteLine("     5.Insight Cosmetics Matte Lipsticks  ");
                    Console.WriteLine("     6.Masaba Pure Matte Lipstick   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Sorry you entered the wrong option! ");
                    break;


            }

        }

        public void MyNails(string opt3)
        {
            switch (opt3)
            {
                case "1":
                    //SUBTLENAILPOLISH
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Pear Nova Nail Polish     ");
                    Console.WriteLine("     2.Olive and June Nail Polish   ");
                    Console.WriteLine("     3.Paint Box Nail Lacquer   ");
                    Console.WriteLine("     4.Cote Toxin Free Nail Polish     ");
                    Console.WriteLine("     5.Sally Hansen Miracle Gel   ");
                    Console.WriteLine("     6.Essie Sheer Enamel Nail Polish   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "2":
                    //mattenailpolish
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Littmuss Matte Chrome Nail Polish     ");
                    Console.WriteLine("     2.MyGlamm LIT Matte Nail Enamel   ");
                    Console.WriteLine("     3.Bella Voste Matte Nail Paint   ");
                    Console.WriteLine("     4.Eylina Matte Nail Polish    ");
                    Console.WriteLine("     5.Iba Perfect Matte Top Coat   ");
                    Console.WriteLine("     6.Revlon Summer Matte-Ness Nail Enamel   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "3":
                    //glitternailpolish
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Lakme Color Crush Nail Art     ");
                    Console.WriteLine("     2.Bella Voste Glitter Nail Paint   ");
                    Console.WriteLine("     3.Colorbar Nail Lacquer    ");
                    Console.WriteLine("     4.Swiss Beauty Glitter Nail Polish     ");
                    Console.WriteLine("     5.Manish Malhotra Beauty By MyGlamm Nail Lacquer  ");
                    Console.WriteLine("     6.Miss Claire Ultimate Glitter Nail Polish   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
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


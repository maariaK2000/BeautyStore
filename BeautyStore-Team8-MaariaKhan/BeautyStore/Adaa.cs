using System;
using Newtonsoft.Json;
using System.IO;


namespace BeautyStore
{
    class Adaa
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor=ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;

            Makeupitems makeupitems = new Makeupitems();
            Skincareitem skincareitem = new Skincareitem();
            Haircareitems haircareitems = new Haircareitems();
            Fragranceitems fragranceitems = new Fragranceitems();
            Appliancesitems appliancesitems = new Appliancesitems();

            SkinCare skincare1 = new SkinCare()
            {
                Toner = "Forest Essentials",
                Cleanser = "Micellar",
                Moisturizer = "Simple Kind",
                Mask = "Snail Sheet Mask"

            };
            SkinCare skincare2 = new SkinCare()
            {
                Toner = "Tea Tree",
                Cleanser = "Moms Co.Natural",
                Moisturizer = "Revitalift",
                Mask = "TonyMolly Mask"


            };
            SkinCare skincare3 = new SkinCare()
            {
                Toner = "Mamaearth Vitamin C",
                Cleanser = "Neutrogena",
                Moisturizer = "Estee Lauder",
                Mask = "Innisfree Volcanic Pore Clay"


            };
            SkinCare skincare4 = new SkinCare()
            {
                Toner = "PIXI Glow Tonic",
                Cleanser = "Cetaphil",
                Moisturizer = "Minimalist",
                Mask = "The Face Shop Real Nature Red Ginseng Face Mask"


            };
            SkinCare skincare5 = new SkinCare()
            {
                Toner = "Lakme Absolute Pore Fix Toner",
                Cleanser = "Plum Green tree",
                Moisturizer = "Klairs Freshly Juiced",
                Mask = "Prolixr Detoxifying Sea Algae Mask"


            };
            SkinCare skincare6 = new SkinCare()
            {
                Toner = "PIXI Glow Tonic",
                Cleanser = "Garnier Skin Naturals",
                Moisturizer = "Clinique Moisture Surge",
                Mask = "MCaffeine Deep Pore Cleansing Regime"


            };

            Makeup makeup1 = new Makeup()
            {
                Foundation = "LOreal Paris Infallible",
                Concealer = "Maybelline New York Fit me Concealer",
                Highlighter = "BECCA Ignite Liquified Light Hightlighter",
                Compact = "Maybelline New York Fit Me Oil Control",
                Kajal= "Lakme Eyeconic Kajal",
                Liner= "LOreal Paris Super Liner",
                Eyeshadow= "Makeup Revolution Eyeshadow Palette",
                Lipgloss= "SUGAR Time To Shine Lip Gloss",
                Creamylipstick= "MyGlamm LIT Creamy Matte Lipstick",
                Mattelipstick= "Kay Beauty Long Stay Matte Lipstick",
                Subtlenail = "Pear Nova Nail Polish",
                Mattenail = "Littmuss Matte Chrome Nail Polish",
                Glitternail= "Lakme Color Crush Nail Art",
   
            };
            Makeup makeup2 = new Makeup()
            {
                Foundation = "Kay Beauty Hydrating Foundation",
                Concealer = "L.A. Girl",
                Highlighter = "Huda Beauty 3D Highlighter",
                Compact = "Kay Beauty Matte Compact",
                Kajal = "Swiss Beauty Deep Black Kajal",
                Liner = "Kay Beauty Quick Dry Liquid Eyeliner",
                Eyeshadow = "SUGAR Blend The Rules Eyeshadow Palette",
                Lipgloss = "Lime Crime Wet Cherry Lip Gloss",
                Creamylipstick = "Kiko Milano Gossamer Emotion Creamy Lipstick",
                Mattelipstick = "Elle 18 Color Pops Matte Lipstick",
                Subtlenail = "Olive and June Nail Polish",
                Mattenail = "MyGlamm LIT Matte Nail Enamel",
                Glitternail = "Bella Voste Glitter Nail Paint",



            };
            //yaha se change kro!!!
            Makeup makeup3 = new Makeup()
            {
                Foundation = "LOreal Paris Infallible",
                Concealer = "Maybelline New York Fit me Concealer",
                Highlighter = "BECCA Ignite Liquified Light Hightlighter",
                Compact = "Maybelline New York Fit Me Oil Control",
                Kajal = "Lakme Eyeconic Kajal",
                Liner = "LOreal Paris Super Liner",
                Eyeshadow = "Makeup Revolution Eyeshadow Palette",
                Lipgloss = "SUGAR Time To Shine Lip Gloss",
                Creamylipstick = "MyGlamm LIT Creamy Matte Lipstick",
                Mattelipstick = "Kay Beauty Long Stay Matte Lipstick",
                Subtlenail = "Pear Nova Nail Polish",
                Mattenail = "Littmuss Matte Chrome Nail Polish",
                Glitternail = "Lakme Color Crush Nail Art",


            };
            Makeup makeup4 = new Makeup()
            {
                Foundation = "LOreal Paris Infallible",
                Concealer = "Maybelline New York Fit me Concealer",
                Highlighter = "BECCA Ignite Liquified Light Hightlighter",
                Compact = "Maybelline New York Fit Me Oil Control",
                Kajal = "Lakme Eyeconic Kajal",
                Liner = "LOreal Paris Super Liner",
                Eyeshadow = "Makeup Revolution Eyeshadow Palette",
                Lipgloss = "SUGAR Time To Shine Lip Gloss",
                Creamylipstick = "MyGlamm LIT Creamy Matte Lipstick",
                Mattelipstick = "Kay Beauty Long Stay Matte Lipstick",
                Subtlenail = "Pear Nova Nail Polish",
                Mattenail = "Littmuss Matte Chrome Nail Polish",
                Glitternail = "Lakme Color Crush Nail Art",


            };
            Makeup makeup5 = new Makeup()
            {
                Foundation = "LOreal Paris Infallible",
                Concealer = "Maybelline New York Fit me Concealer",
                Highlighter = "BECCA Ignite Liquified Light Hightlighter",
                Compact = "Maybelline New York Fit Me Oil Control",
                Kajal = "Lakme Eyeconic Kajal",
                Liner = "LOreal Paris Super Liner",
                Eyeshadow = "Makeup Revolution Eyeshadow Palette",
                Lipgloss = "SUGAR Time To Shine Lip Gloss",
                Creamylipstick = "MyGlamm LIT Creamy Matte Lipstick",
                Mattelipstick = "Kay Beauty Long Stay Matte Lipstick",
                Subtlenail = "Pear Nova Nail Polish",
                Mattenail = "Littmuss Matte Chrome Nail Polish",
                Glitternail = "Lakme Color Crush Nail Art",


            };
            Makeup makeup6 = new Makeup()
            {
                Foundation = "LOreal Paris Infallible",
                Concealer = "Maybelline New York Fit me Concealer",
                Highlighter = "BECCA Ignite Liquified Light Hightlighter",
                Compact = "Maybelline New York Fit Me Oil Control",
                Kajal = "Lakme Eyeconic Kajal",
                Liner = "LOreal Paris Super Liner",
                Eyeshadow = "Makeup Revolution Eyeshadow Palette",
                Lipgloss = "SUGAR Time To Shine Lip Gloss",
                Creamylipstick = "MyGlamm LIT Creamy Matte Lipstick",
                Mattelipstick = "Kay Beauty Long Stay Matte Lipstick",
                Subtlenail = "Pear Nova Nail Polish",
                Mattenail = "Littmuss Matte Chrome Nail Polish",
                Glitternail = "Lakme Color Crush Nail Art",


            };


            HairCare haircare1 = new HairCare()
            {
                Shampoo = "Loreal Professional Serie Expert",
                Conditioner = "Loreal Paris Rapid Reviver",
                Hairoil = "Mamaearth Rice Hair Oil",
                Hairserum = "Livion Serum",
                Haircolor = "Biotique Herb Hair Color",
                Hairmasks = "Tresemme Deep Smoothing Mask"

            };


            HairCare haircare2 = new HairCare()
            {
                Shampoo = "Mama Earth Rice Water Shampoo",
                Conditioner = "Sebastian Professional Penetraitt",
                Hairoil = "Moroccanoil Treatment Oil",
                Hairserum = "Streax Professional Serum ",
                Haircolor = "Streax Coffee Collection",
                Hairmasks = "Mamaearth Argan Hair Mask"

            };

            HairCare haircare3 = new HairCare()
            {
                Shampoo = "Tresemme Keratin Smooth",
                Conditioner = "Matrix Opti Care ",
                Hairoil = "Forest Essential Oil",
                Hairserum = "Matrix Opti Care Professional Serum",
                Haircolor = "Revlon Colorsilk Hair Color",
                Hairmasks = "SP Luxe Oil Keratin Restore Mask"

            };

            HairCare haircare4 = new HairCare()
            {
                Shampoo = "Mamaearth Onion Shampoo",
                Conditioner = "Herbal Essences",
                Hairoil = "Indulekha Bringha Hair Oil",
                Hairserum = "LOreal Paris Total Repair 5 Serum",
                Haircolor = "Godrej Nupur Henna",
                Hairmasks = "Wella Professionals Renewing Mask "

            };

            HairCare haircare5 = new HairCare()
            {
                Shampoo = "Wella Professionals",
                Conditioner = "Loreal Paris Dream Lengths",
                Hairoil = "Max Care Virgin Coconut Oil",
                Hairserum = "Tresemme Keratin Smooth Hair Serum",
                Haircolor = "Joves Herbal Henna",
                Hairmasks = "Dove Intense Damage Repair Hair Mask"

            };

            HairCare haircare6 = new HairCare()
            {
                Shampoo = "GK Hair Balancing Shampoo",
                Conditioner = "Dove Intense Repair Conditioner",
                Hairoil = "Wella Professional Luminous Oil",
                Hairserum = "Matrix Biolage Serum",
                Haircolor = "LOreal Paris Casting Creme Gloss",
                Hairmasks = "Mamaearth Rice Water Hair Mask"

            };

            //skincare file objects serializing 
            string myskincare1 = JsonConvert.SerializeObject(skincare1);
            File.WriteAllText(@"skincare.json", myskincare1);
            string myskincare2 = JsonConvert.SerializeObject(skincare2);
            File.AppendAllText(@"skincare.json", myskincare2);
            string myskincare3 = JsonConvert.SerializeObject(skincare3);
            File.AppendAllText(@"skincare.json", myskincare3);
            string myskincare4 = JsonConvert.SerializeObject(skincare4);
            File.AppendAllText(@"skincare.json", myskincare4);
            string myskincare5 = JsonConvert.SerializeObject(skincare5);
            File.AppendAllText(@"skincare.json", myskincare5);
            string myskincare6 = JsonConvert.SerializeObject(skincare6);
            File.AppendAllText(@"skincare.json", myskincare6);

            //haircare file objects serialzing
            string myhaircare1 = JsonConvert.SerializeObject(haircare1);
            File.WriteAllText(@"haircare.json", myhaircare1);
            string myhaircare2 = JsonConvert.SerializeObject(haircare2);
            File.AppendAllText(@"haircare.json", myhaircare2);
            string myhaircare3 = JsonConvert.SerializeObject(haircare3);
            File.AppendAllText(@"haircare.json", myhaircare3);
            string myhaircare4 = JsonConvert.SerializeObject(haircare4);
            File.AppendAllText(@"haircare.json", myhaircare4);
            string myhaircare5 = JsonConvert.SerializeObject(haircare5);
            File.AppendAllText(@"haircare.json", myhaircare5);
            string myhaircare6 = JsonConvert.SerializeObject(haircare6);
            File.WriteAllText(@"haircare.json", myhaircare6);

            //makeup file objects serializing
            string mymakeup1 = JsonConvert.SerializeObject(makeup1);
            File.WriteAllText(@"makeup.json", mymakeup1);
            string mymakeup2 = JsonConvert.SerializeObject(makeup2);
            File.AppendAllText(@"makeup.json", mymakeup2);
            string mymakeup3 = JsonConvert.SerializeObject(makeup3);
            File.AppendAllText(@"makeup.json", mymakeup3);
            string mymakeup4 = JsonConvert.SerializeObject(makeup4);
            File.AppendAllText(@"makeup.json", mymakeup4);
            string mymakeup5 = JsonConvert.SerializeObject(makeup5);
            File.AppendAllText(@"makeup.json", mymakeup5);
            string mymakeup6 = JsonConvert.SerializeObject(makeup6);
            File.AppendAllText(@"makeup.json", mymakeup6);



            /*Appliances apl1 = new Appliances()
            {
                Hairdryer=""
                Hairstraightner="jsh,hdk,kgh,kdh,dkdj,ckd",
                Faceepilator="nsb,hdgd,fkfj,kfjf,shsb,dnnd",
                Shavers="sgsg,jgd,kfh,vvs,kdh,kdhd",
                Trimmers="jsgs,djgd,dkdj,kdjd,dkd,abav",
                Haircurler="msbsb,kgfd,skah,ckvl,ettj,akaj"

            };
            string myappliances = JsonConvert.SerializeObject(appliances);
            File.WriteAllText(@"appliances.json", myappliances);*/

            string opt1 = "";
            string opt2 = "";
            string opt3 = "";
            
          
            Console.WriteLine("***************WELCOME TO ADAA BEAUTY CORNER********************");
            Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
            Console.WriteLine();
            Console.WriteLine("      1.MAKEUP               2.SKIN CARE              3.HAIR CARE               4.FRAGRANCES           5.APPLIANCES    ");           
            Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
            Console.WriteLine();
            Console.WriteLine("Select the category by entering the appropriate option number:");
            opt1 = Console.ReadLine();
            MyMenus(opt1);
            void MyMenus(string opt1)
            {
                switch (opt1)
                {
                    case "1":
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.FACES      ");
                        Console.WriteLine("     2.EYES       ");
                        Console.WriteLine("     3.LIPS       ");
                        Console.WriteLine("     4.NAILS      ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt2 = Console.ReadLine();
                        MyMakeup(opt2);
                        break;
                    case "2":
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.TONER      ");
                        Console.WriteLine("     2.CLEANSER   ");
                        Console.WriteLine("     3.MOISTURIZER    ");
                        Console.WriteLine("     4.MASK      ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt2 = Console.ReadLine();
                        skincareitem.MySkin(opt2);

                        break;
                    case "3":
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.SHAMPOO      ");
                        Console.WriteLine("     2.CONDITIONER   ");
                        Console.WriteLine("     3.HAIR OIL    ");
                        Console.WriteLine("     4.HAIR SERUM      ");
                        Console.WriteLine("     5.HAIR COLOUR    ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt2 = Console.ReadLine();
                        haircareitems.MyHair(opt2);
                        break;
                    case "4":
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.WOMEN     ");
                        Console.WriteLine("     2.MEN   ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt2 = Console.ReadLine();
                        MyCustomerGender(opt2);
                        break;
                    case "5":
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.HAIR STRAIGHTNER       ");
                        Console.WriteLine("     2.HAIR DRYER   ");
                        Console.WriteLine("     3.FACE EPILATOR    ");
                        Console.WriteLine("     4.SHAVERS    ");
                        Console.WriteLine("     5.TRIMMERS    ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt2 = Console.ReadLine();
                        appliancesitems.MyAppliances(opt2);
                        break;
                    default:
                        Console.WriteLine("Sorry you entered the wrong option! ");
                        break;

                }
            }

            
            void MyMakeup(string opt2)
            {
                switch (opt2)
                {
                    case "1":
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.FOUNDATION      ");
                        Console.WriteLine("     2.CONCEALER       ");
                        Console.WriteLine("     3.HIGHLIGHTER       ");
                        Console.WriteLine("     4.COMPACT      ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt3 = Console.ReadLine();
                        makeupitems.MyFace(opt3);

                        break;
                    case "2":
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.KAJAL      ");
                        Console.WriteLine("     2.EYE-LINER   ");
                        Console.WriteLine("     3.EYE-SHADOW PALETTE    ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt3 = Console.ReadLine();
                        makeupitems.MyEyes(opt3);
                        break;
                    case "3":
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.LIPGLOSS      ");
                        Console.WriteLine("     2.CREAME-LIPSTICK   ");
                        Console.WriteLine("     3.MATTE LIPSTICK    ");

                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt3 = Console.ReadLine();
                        makeupitems.MyLips(opt3);
                        break;
                    case "4":
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.SUBTLE-NAILPOLISH     ");
                        Console.WriteLine("     2.MATTE-NAILPOLISH   ");
                        Console.WriteLine("     3.GLITTER-NAILPOLISH   ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt3 = Console.ReadLine();
                        makeupitems.MyNails(opt3);
                        break;
                    default:
                        Console.WriteLine("Sorry you entered the wrong option! ");
                        break;

                }

            }

            
            void MyCustomerGender(string opt2)
            {
                switch (opt2)
                {
                    case "1":
                        //Women
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.Perfume      ");
                        Console.WriteLine("     2.Body Mists       ");
                        Console.WriteLine("     3.Deodrants       ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt3 = Console.ReadLine();
                        fragranceitems.MyWomenFragrance(opt3);
                        break;
                    case "2":
                        //Men
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.Perfume      ");
                        Console.WriteLine("     2.Body Mists       ");
                        Console.WriteLine("     3.Deodrants       ");
                        Console.WriteLine("     4.Collagens and after shaves       ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt3 = Console.ReadLine();
                        fragranceitems.MyMenFragrance(opt3);
                        break;
                    default:
                        Console.WriteLine("Sorry you entered the wrong option! ");
                        break;

                }
            }
            
            /*void FoundationCart(string opt4,int qnty)
            {
                Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
                c1 = Convert.ToChar(Console.ReadLine());

                if (c1 == 'y')
                {
                    switch (opt4)
                    {
                        case "1":
                            makeup.foundation = Foundation.LOrealParisInfallible;
                            makeup.foundationqnty = qnty;
                            break;
                        case "2":
                            makeup.foundation = Foundation.KayBeautyHydratingFoundation;
                            makeup.foundationqnty = qnty;
                            break;
                        case "3":
                            makeup.foundation = Foundation.MaybellineNewYorkFitmeFoundation;
                            makeup.foundationqnty = qnty;
                            break;
                        case "4":
                            makeup.foundation = Foundation.HudaBeautyFauxfilter;
                            makeup.foundationqnty = qnty;
                            break;
                        case "5":
                            makeup.foundation = Foundation.CharlotteTilburyHollywoodFilter;
                            makeup.foundationqnty = qnty;
                            break;
                        case "6":
                            makeup.foundation = Foundation.MACStudioFixFuild;
                            makeup.foundationqnty = qnty;
                            break;
                    }
                    Console.WriteLine(makeup.foundationqnty);
                    Console.WriteLine(makeup.foundationtotal);
                    if (makeup.foundationqnty == 0)
                    {
                        //if quantity not set means asked quantity is greater than available
                        Console.WriteLine($"We have only {makeup.foundationtotal} foundations available ....Please buy within or equal to the available stock! ");
                        MyFace(opt3);

                    }
                    else
                    {
                        Orders order = new Orders()
                        {
                            Productname = Convert.ToString(makeup.foundation),
                            Quantity = makeup.foundationqnty

                        };
                        string myorder = JsonConvert.SerializeObject(order);
                        File.WriteAllText(@"order.json", myorder);
                       
                        //quantity asked is within or equal to available quantity
                        Console.WriteLine("Hurrah! Item added successfully in cart!");
                        Console.WriteLine("Press 'y' to view cart or press 'c' to continue shopping:");
                        c2 = Convert.ToChar(Console.ReadLine());
                        if (c2 == 'y')
                        {
                            Console.WriteLine("**************CART ITEMS******************");
                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine();
                            Console.WriteLine("                   Item Name                   Item quantity                   ");
                            Console.WriteLine($"               {makeup.foundation}            {makeup.foundationqnty}         ");
                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine("");

                        }
                        else if (c2 == 'c')
                        {
                            MyFace(opt3);

                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    
                    
                }
                else
                {
                    MyFace(opt3);
                }
            }*/

        }    

    }
}

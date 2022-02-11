using System;

    namespace Rabattstaffel
    {
        class Rechner
        {
            public static void Main(String[] args)
            {
                double height, normweightMale, normweightFemale;
                int gender;
                Console.WriteLine("Gewichtsrechner\n\n");

                Console.WriteLine("Bitte wählen Sie ihr Geschlecht :");
                Console.WriteLine("[1] Weiblich");
                Console.WriteLine("[2] Männlich");
                gender=Convert.ToInt32(Console.ReadLine());

                switch (gender) 
                {
                case 1:
                    Console.Clear();
                    Console.Write("Geben Sie bitte Ihre Körpergröße in cm ein: ");
                    height = Convert.ToDouble(Console.ReadLine());
                    normweightFemale = (height - 100)* 0.85;
                    Console.WriteLine("Ihr Normalgewicht beträgt {0}kg", normweightFemale);
                    break;
                case 2:
                    Console.Clear(); 
                    Console.Write("Geben Sie bitte Ihre Körpergröße in cm ein: ");
                    height = Convert.ToDouble(Console.ReadLine());
                    normweightMale = (height - 100)* 0.9;
                    Console.WriteLine("Ihr Normalgewicht beträgt {0}kg", normweightMale);
                    break;
                default:
                    Console.WriteLine("Bitte wählen sie zwischen 1 und 2");
                    break;
                }

            }
        }
    }
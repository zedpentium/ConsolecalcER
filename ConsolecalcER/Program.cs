using System;

namespace ConsolecalcER
{
    class Program
    {
        static void Main(string[] args)
        {
         

            bool showMenu = true; // hålla smidigt igång menyn tills user trycker 0 i menyn
            while (showMenu)
            {
                showMenu = Menyn();
            }

            static bool Menyn() // själva menyn & val
            {
                Console.Clear();
                Console.WriteLine("----* Välkommen till Eric R's Konsol-kalkylator *----\n");
                Console.WriteLine("Välj räknesätt:");
                Console.WriteLine();
                Console.WriteLine("1) Addition");
                Console.WriteLine("2) Subtraktion");
                Console.WriteLine("3) Division");
                Console.WriteLine("4) Multiplikation");
                Console.WriteLine("0) Avsluta programmet");

                Console.Write("\r\nSkriv in NR på menyval & tryck enter: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        MAddition();
                        return true;
                    case "2":
                        MSubtraktion();
                        return true;
                    case "3":
                        MDivision();
                        return true;
                    case "4":
                        MMultiplikation();
                        return true;
                    case "0":
                        return false;
                    default:
                        return true;
                }
            }

        } // end main


        // My methods
        // Userinput, 2 tal som skall konverteras till int
        static double GetInputFromUser()
        {
            // deklarerar variabel
            double inputTal;

            string userInput = Console.ReadLine();
            while (!double.TryParse(userInput, out inputTal)) // prova om userinput kan konverteras till int
            {
                Console.WriteLine("Det är inte ett tal. Var god skriv in ett heltal:");
                userInput = Console.ReadLine();
            }
            return inputTal;
        }

        static void DoneFunction() // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
        {
            Console.WriteLine("\n\n");
            Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }

        static void MAddition() // Menyval 1
        {
            Console.Clear();
            Console.WriteLine("Räkna Addition");

            Console.WriteLine("\nSkriv in första talet & tryck Enter");
            double userTal1 = GetInputFromUser();

            Console.WriteLine("\nSkriv in andra talet & tryck Enter");
            double userTal2 = GetInputFromUser();

            Console.WriteLine("\nResultat avrundat:" + userTal1 + " + " + userTal2 + " = " + (userTal1 + userTal2));

            DoneFunction();
        }

        static void MSubtraktion() // Menyval 2
        {
            Console.Clear();
            Console.WriteLine("Räkna Subtraktion");

            Console.WriteLine("\nSkriv in första talet & tryck Enter");
            double userTal1 = GetInputFromUser();

            Console.WriteLine("\nSkriv in andra talet & tryck Enter");
            double userTal2 = GetInputFromUser();

            Console.WriteLine("\nResultat avrundat:" + userTal1 + " - " + userTal2 + " = " + (userTal1 - userTal2));

            DoneFunction();
        }

        static void MDivision() // Menyval 3
        {
            Console.Clear();
            Console.WriteLine("Räkna Division");

            Console.WriteLine("\nSkriv in ett tal & tryck Enter");
            double userTal1 = GetInputFromUser();

            double userTal2 = 0; // deklarerar variabel till 0, innför koll om userinputvärdet är värde 0
            while (userTal2 == 0)
            {
                Console.WriteLine("\nSkriv in vad " + userTal1 + " skall delas med, & tryck Enter");
                userTal2 = GetInputFromUser();

                if (userTal2 == 0)
                {
                    Console.WriteLine("OBS! Du kan inte dela med talet 0.");
                }
            }


            Console.WriteLine("\nResultat avrundat: " + userTal1 + " / " + userTal2 + " = " + (userTal1 / userTal2));

            DoneFunction();
        }

        static void MMultiplikation() // Menyval 4
        {
            Console.Clear();
            Console.WriteLine("Räkna Multiplikation");

            Console.WriteLine("\nSkriv in första talet & tryck Enter");
            double userTal1 = GetInputFromUser();

            Console.WriteLine("\nSkriv in andra talet & tryck Enter");
            double userTal2 = GetInputFromUser();

            Console.WriteLine("\nResultat avrundat: " + userTal1 + " * " + userTal2 + " = " + (userTal1 * userTal2));

            DoneFunction();
        }
    }
}

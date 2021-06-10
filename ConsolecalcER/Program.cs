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
                try
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
                            break;
                        case "2":
                            MSubtraktion();
                            break;
                        case "3":
                            MDivision();
                            break;
                        case "4":
                            MMultiplikation();
                            break;
                        case "0":
                            showMenu = false;
                            Environment.Exit(0);
                            break;
                        default:
                            //Console.WriteLine("Det är inte ett giltigt meny nummer!");
                            break;
                    }

                } //End try

                catch
                {
                    //Console.WriteLine("Det är inte ett giltigt meny nummer!");
                }

            } // End while

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

        static void DoMathWithInput(int mChoice) // Method to minimize repeating code for each math choice
        {
            Console.WriteLine("\nSkriv in första talet & tryck Enter");
            double userTal1 = GetInputFromUser();

            Console.WriteLine("\nSkriv in andra talet & tryck Enter");
            double userTal2 = GetInputFromUser();

            string strMathSign = "";
            double intSum = 0;

            if (mChoice == 1)
                {
                strMathSign = "+";
                intSum = userTal1 + userTal2;
                }
            else if (mChoice == 2)
                {
                strMathSign = "-";
                intSum = userTal1 - userTal2;
            }
            else if (mChoice == 3)
                {
                while (userTal2 == 0)
                {
                    //Console.WriteLine("\nSkriv in vad " + userTal1 + " skall delas med, & tryck Enter");
                    //userTal2 = GetInputFromUser();

                    if (userTal2 == 0)
                    {
                        Console.WriteLine("OBS! Du kan inte dela med talet 0.\nVar god skriv in ett tal:");
                        userTal2 = GetInputFromUser();
                    }
                }
                strMathSign = "/";
                intSum = userTal1 / userTal2;
            }
            else if (mChoice == 4)
                {
                strMathSign = "*";
                intSum = userTal1 * userTal2;
            }

            Console.WriteLine($"\nResultat: {userTal1} {strMathSign} {userTal2} = {intSum}");

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

            DoMathWithInput(1);

            DoneFunction();
        }

        static void MSubtraktion() // Menyval 2
        {
            Console.Clear();
            Console.WriteLine("Räkna Subtraktion");

            DoMathWithInput(2);

            /*

            Console.WriteLine("\nSkriv in första talet & tryck Enter");
            double userTal1 = GetInputFromUser();

            Console.WriteLine("\nSkriv in andra talet & tryck Enter");
            double userTal2 = GetInputFromUser();

            Console.WriteLine("\nResultat avrundat:" + userTal1 + " - " + userTal2 + " = " + (userTal1 - userTal2));
            */

            DoneFunction();
        }

        static void MDivision() // Menyval 3
        {
            Console.Clear();
            Console.WriteLine("Räkna Division");

            DoMathWithInput(3);

            /*
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
            */

            DoneFunction();
        }

        static void MMultiplikation() // Menyval 4
        {
            Console.Clear();
            Console.WriteLine("Räkna Multiplikation");

            DoMathWithInput(4);

            /*
            Console.WriteLine("\nSkriv in första talet & tryck Enter");
            double userTal1 = GetInputFromUser();

            Console.WriteLine("\nSkriv in andra talet & tryck Enter");
            double userTal2 = GetInputFromUser();

            Console.WriteLine("\nResultat avrundat: " + userTal1 + " * " + userTal2 + " = " + (userTal1 * userTal2));
            */

            DoneFunction();
        }
    }
}

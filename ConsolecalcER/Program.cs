using System;

namespace ConsolecalcER
{
    class Program
    {
        static void Main(string[] args)
        {
         

            bool showMenu = true; // hålla smidigt igång menyn
            while (showMenu)
            {
                showMenu = Menyn();
            }

            static bool Menyn() // själva menyn
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
                        mAddition();
                        return true;
                    case "2":
                        mSubtraktion();
                        return true;
                    case "3":
                        mDivision();
                        return true;
                    case "4":
                        mMultiplikation();
                        return true;
                    case "0":
                        return false;
                    default:
                        return true;
                }
            }

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

            static void doneFunction() // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
            {
                Console.WriteLine("\n\n");
                Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                }
            }

            static void mAddition() // Menyval 1
            {
                Console.Clear();
                Console.WriteLine("Räkna Addition\n");

                Console.WriteLine("Skriv in första talet & tryck Enter\n");
                double userTal1 = GetInputFromUser();

                Console.WriteLine("Skriv in andra talet & tryck Enter\n");
                double userTal2 = GetInputFromUser();

                Console.WriteLine("\nResultat avrundat:" + userTal1 + " + " + userTal2 + " = " + (userTal1 + userTal2));

                doneFunction();
            }
            
            static void mSubtraktion() // Menyval 2
            {
                Console.Clear();
                Console.WriteLine("Räkna Subtraktion");

                Console.WriteLine("Skriv in första talet & tryck Enter\n");
                double userTal1 = GetInputFromUser();

                Console.WriteLine("Skriv in andra talet & tryck Enter\n");
                double userTal2 = GetInputFromUser();

                Console.WriteLine("\nResultat avrundat:" + userTal1 + " - " + userTal2 + " = " + (userTal1 - userTal2));

                doneFunction();
            }
            
            static void mDivision() // Menyval 3
            {
                Console.Clear();
                Console.WriteLine("Räkna Division");

                Console.WriteLine("Skriv in ett tal & tryck Enter\n");
                double userTal1 = GetInputFromUser();

                double userTal2 = 0; // deklarerar variabel till 0, innför koll om userinputvärdet är värde 0
                while (userTal2 == 0)
                {
                    Console.WriteLine("Skriv in vad " + userTal1 + " skall delas med, & tryck Enter\n");
                    userTal2 = GetInputFromUser();
                    
                    if (userTal2 == 0)
                    {
                        Console.WriteLine("OBS! Du kan inte dela med talet 0.");
                    }
                }


                Console.WriteLine("\nResultat avrundat: " + userTal1 + " / " + userTal2 + " = " + (userTal1 / userTal2));

                doneFunction();
            }
            
            static void mMultiplikation() // Menyval 4
            {
                Console.Clear();
                Console.WriteLine("Räkna Multiplikation");

                Console.WriteLine("Skriv in första talet & tryck Enter\n");
                double userTal1 = GetInputFromUser();

                Console.WriteLine("Skriv in andra talet & tryck Enter\n");
                double userTal2 = GetInputFromUser();

                Console.WriteLine("\nResultat avrundat: " + userTal1 + " * " + userTal2 + " = " + (userTal1 * userTal2));

                doneFunction();
            }
        }
    }
}

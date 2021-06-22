using System;

namespace ConsolecalcER
{
    public class Program
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
                            showMenu = false; // stoppa switch-loopen och gå till slut av Main = slut på programmet
                            break;
                        default:
                            Console.WriteLine("Det är inte ett giltigt meny nummer! Tryck enter och försök igen.");
                            Console.ReadKey();
                            break;
                    }

                } //End try

                catch
                {
                    Console.WriteLine("Det är inte ett giltigt meny nummer! Tryck enter och försök igen.");
                    Console.ReadKey();
                }

            } // End while

        } // end main


        // My methods
        // Userinput, 2 tal som skall konverteras till int

        // Get integers from user
        public static void GetInputFromUser(int mChoice)
        {
            Console.WriteLine("\nSkriv in första talet & tryck Enter");
            double userTal1 = GetInputFromUserValidate();

            Console.WriteLine("\nSkriv in andra talet & tryck Enter");
            double userTal2 = GetInputFromUserValidate();

            DoMathWithInput(mChoice, userTal1, userTal2);
        }

        // Validate the inputs from user of the above method
        public static double GetInputFromUserValidate()
        {
            // deklarerar variabel
            double inputTal;

            string userInput = Console.ReadLine();
            while (!double.TryParse(userInput, out inputTal)) // prova om userinput kan konverteras till double
            {
                Console.WriteLine("Det är inte ett tal. Var god skriv in ett heltal:");
                userInput = Console.ReadLine();
            }
            return inputTal;
        }


        // Do math with userinput userTal1 and userTal2
        public static double DoMathWithInput(int mChoice, double userTal1, double userTal2) // Method to minimize repeating code for each math choice
        {
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
                //while (userTal2 == 0)
                //{
                //Console.WriteLine("\nSkriv in vad " + userTal1 + " skall delas med, & tryck Enter");

                if (userTal2 == 0)
                {
                    Console.WriteLine("OBS! Du kan inte dela med talet 0.\nVar god skriv in ett tal:");
                    // commented out to be able to run xunit test userTal2 = GetInputFromUserValidate();
                }
                //}

                strMathSign = "/";
                try
                {
                    intSum = userTal1 / userTal2;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Du kan inte dela med talet 0. Skriv in på nytt");
                }


            }

            else if (mChoice == 4)
            {
                strMathSign = "*";
                intSum = userTal1 * userTal2;
            }

            Console.WriteLine($"\nResultat: {userTal1} {strMathSign} {userTal2} = {intSum}");
            return intSum;
        }

        // Do plus or minus with input from array
        public static double DoMathWithInput(int mChoice, double[] arrInput) // Method to minimize repeating code for each math choice
        {
            string strMathSign = "";
            double intSum=0;


            if (mChoice == 1)
            {
                strMathSign = "+";
                intSum = arrInput[0];
                for (int i1 = 1; i1 < arrInput.Length; i1++)
                {
                    intSum = intSum + arrInput[i1];
                }
            }
            else if (mChoice == 2)
            {
                strMathSign = "-";
                intSum = arrInput[0];
                for (int i2 = 1; i2 < arrInput.Length; i2++)
                {
                    intSum=
                    intSum = intSum - arrInput[i2];
                }
            }

            //Console.WriteLine($"\nResultat: {userTal1} {strMathSign} {userTal2} = {intSum}");
            return intSum;
        }


        static void DoneFunction() // 2 blanka rader och sedan vänta på enter-tryck för att visa menyn 
        {
            Console.WriteLine("\n\n");
            Console.Write("\nFunktion utförd! Tryck 'Enter' för att komma till menyn...");
            //while (Console.ReadKey().Key != ConsoleKey.Enter)
            //{
            //}
        }

        static void MAddition() // Menyval 1
        {
            Console.Clear();
            Console.WriteLine("Räkna Addition");

            // commented out to be able to run xunit test GetInputFromUser(1);

            DoneFunction();
        }

        static void MSubtraktion() // Menyval 2
        {
            Console.Clear();
            Console.WriteLine("Räkna Subtraktion");

            // commented out to be able to run xunit test GetInputFromUser(2);

            DoneFunction();
        }

        static void MDivision() // Menyval 3
        {
            Console.Clear();
            Console.WriteLine("Räkna Division");

            // commented out to be able to run xunit test
            GetInputFromUser(3);

            DoneFunction();
        }

        static void MMultiplikation() // Menyval 4
        {
            Console.Clear();
            Console.WriteLine("Räkna Multiplikation");

            // commented out to be able to run xunit test GetInputFromUser(4);

            DoneFunction();
        }


      
    }
}

//Ludwig Oleby SUT21
using System;

namespace Individuellt_projekt
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Välkommen till Ludwigs internetbank!");
            userLogin();
        }

        public static void userLogin()

        {
            
            string[,] users = new string[5, 2]; // Deklarerar multidimensionell array med "users" och "password"

            // User 1
            users[0, 0] = "User 1";
            users[0, 1] = "Password 1";
            

            // User 2
            users[1, 0] = "User 2";
            users[1, 1] = "Password 2";
            

            // User 3
            users[2, 0] = "User 3";
            users[2, 1] = "Password 3";
           

            //User 4
            users[3, 0] = "User 4";
            users[3, 1] = "Password 4";
          

            //User 5
            users[4, 0] = "User 5";
            users[4, 1] = "Password 5";
          

            bool loginSucess = false;
            int loginAttempts = 0;
            int currentUser = 0;

            while (loginSucess == false)
            {
                Console.WriteLine("Skriv in ditt användarnamn:");
                string username = Console.ReadLine();
                Console.WriteLine("Skriv in ditt lösenord");
                string password = Console.ReadLine();

                if (username == users[0, 0] && password == users[0, 1])
                {
                    userMenu();
                    currentUser = accountOverview(1);
                    
                }
                else if (username == users[1, 0] && password == users[1, 1])
                {
                    userMenu();
                    currentUser = accountOverview(2);
                    
                }

                else if (username == users[2, 0] && password == users[2, 1])
                {
                    userMenu();
                    currentUser = accountOverview(3);
                    
                }

                else if (username == users[3, 0] && password == users[3, 1])
                {
                    userMenu();
                    currentUser = accountOverview(4);
                    
                }

                else if (username == users[4, 0] && password == users[4, 1])
                {
                    userMenu();
                    currentUser = accountOverview(5);
                    
                }
                else
                {
                    Console.WriteLine("Felaktigt användarnamn eller lösenord, försök igen!");
                }
                loginAttempts++;
                if (loginAttempts > 2)
                {
                    Console.WriteLine("Du har anget felaktigt användarnamn/lösenord 3 gånger, programmet avslutas . . .");
                    Environment.Exit(1);
                }
            }
        }

        public static void userMenu()
        {
            Console.Clear();
            Console.WriteLine("Välj tjänst: \n1. Se dina konton och saldo \n2. Överföring mellan konton \n3. Ta ut pengar \n4. Logga ut");

            int userChoice = Int32.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    accountOverview(0);
                    break;
                case 2:
                    transfer();
                    break;
                case 3:
                    withdraw();
                    break;
                case 4:
                    Console.WriteLine("Du loggas nu ut, tryck på valfri tangent för att fortsätta . . .");
                    userLogin();
                    break;
                default:
                    Console.WriteLine("Ogiltligt val!");
                    break;
            }
        }

        public static int accountOverview(int currentUser) //Skriver ut kontoinformationen som lagras i "userAccount"
        {
            if (currentUser == 1) //User 1
            {
                    string[,] userAccount1 = new string[2, 3];

                    userAccount1[1, 0] = "20000";
                    userAccount1[1, 1] = "2500";
                    userAccount1[1, 2] = "98789.50";

                    userAccount1[0, 0] = "Sparkonto";
                    userAccount1[0, 1] = "Kortkonto";
                    userAccount1[0, 2] = "Pensionskonto";

                for (int amount = 0; amount < userAccount1.GetLength(1); amount++)
                {
                    for (int accname = 0; accname < userAccount1.GetLength(0); accname++)
                    {
                        Console.Write("{0,-15}", userAccount1[accname, amount]);
                    }
                    Console.WriteLine();
                }

                Console.ReadKey();
                userMenu();

            } 
            if (currentUser == 2) //User 2
            {
                    string[,] userAccount2 = new string[2, 2];

                    userAccount2[1, 0] = "45000";
                    userAccount2[1, 1] = "576.40";

                    userAccount2[0, 0] = "Sparkonto";
                    userAccount2[0, 1] = "Kortkonto";

                for (int amount = 0; amount < userAccount2.GetLength(1); amount++)
                {
                    for (int accname = 0; accname < userAccount2.GetLength(0); accname++)
                    {
                        Console.Write("{0,-15}", userAccount2[accname, amount]);
                    }
                    Console.WriteLine();
                }

                Console.ReadKey();
                userMenu();

            }
            if (currentUser == 3) //User 3
            {
                    string[,] userAccount3 = new string[2, 4];

                    userAccount3[1, 0] = "20000";
                    userAccount3[1, 1] = "2500";
                    userAccount3[1, 2] = "150000";
                    userAccount3[1, 3] = "125870";

                    userAccount3[0, 0] = "Sparkonto";
                    userAccount3[0, 1] = "Kortkonto";
                    userAccount3[0, 2] = "Pensionskonto";
                    userAccount3[0, 3] = "Aktiekonto";

                for (int amount = 0; amount < userAccount3.GetLength(1); amount++)
                {
                    for (int accname = 0; accname < userAccount3.GetLength(0); accname++)
                    {
                        Console.Write("{0,-15}", userAccount3[accname, amount]);
                    }
                    Console.WriteLine();
                }

                Console.ReadKey();
                userMenu();
            }
            if (currentUser == 4) //User 4
            {
                    string[,] userAccount4 = new string[2, 2];

                    userAccount4[1, 0] = "23000";
                    userAccount4[1, 1] = "2543.30";


                    userAccount4[0, 0] = "Sparkonto";
                    userAccount4[0, 1] = "Kortkonto";

                for (int amount = 0; amount < userAccount4.GetLength(1); amount++)
                {
                    for (int accname = 0; accname < userAccount4.GetLength(0); accname++)
                    {
                        Console.Write("{0,-15}", userAccount4[accname, amount]);
                    }
                    Console.WriteLine();
                }

                Console.ReadKey();
                userMenu();
            }
            if (currentUser == 5) //User 5
            {
                    string[,] userAccount5 = new string[2, 5];

                    userAccount5[1, 0] = "20000";
                    userAccount5[1, 1] = "2500";
                    userAccount5[1, 2] = "98789.50";
                    userAccount5[1, 3] = "500000";
                    userAccount5[1, 4] = "150000";

                    userAccount5[0, 0] = "Sparkonto";
                    userAccount5[0, 1] = "Kortkonto";
                    userAccount5[0, 2] = "Pensionskonto";
                    userAccount5[0, 3] = "Aktiekonto";
                    userAccount5[0, 4] = "Fonder";

                for (int amount = 0; amount < userAccount5.GetLength(1); amount++)
                {
                    for (int accname = 0; accname < userAccount5.GetLength(0); accname++)
                    {
                        Console.Write("{0,-15}", userAccount5[accname, amount]);
                    }
                    Console.WriteLine();
                }

                Console.ReadKey();
                userMenu();
            }
            return currentUser;

        }

        public static void transfer()
        {

        }

        public static void withdraw()
        {

        }
    }
}
    


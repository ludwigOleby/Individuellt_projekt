﻿using System;

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

            while (loginSucess == false)
            {
                Console.WriteLine("Skriv in ditt användarnamn:");
                string username = Console.ReadLine();
                Console.WriteLine("Skriv in ditt lösenord");
                string password = Console.ReadLine();

                if (username == users[0, 0] && password == users[0, 1])
                {
                    userMenu();
                }
                else if (username == users[1, 0] && password == users[1, 1])
                {
                    userMenu();
                }

                else if (username == users[2, 0] && password == users[2, 1])
                {
                    userMenu();
                }

                else if (username == users[3, 0] && password == users[3, 1])
                {
                    userMenu();
                }

                else if (username == users[4, 0] && password == users[4, 1])
                {
                    userMenu();
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
                    accounts();
                    break;
                case 2:
                    transfer();
                    break;
                case 3:
                    withdraw();
                    break;
                case 4:
                    Console.WriteLine("Du loggas nu ut, tryck på valfri tangent för att fortsätta . . .");
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Ogiltligt val!");
                    break;
            }


        }

        public static void accounts()
        {

        }

        public static void transfer()
        {

        }

        public static void withdraw()
        {

        }
    }
}
    


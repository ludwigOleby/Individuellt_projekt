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

            while (loginSucess == false)
            {
                Console.WriteLine("Skriv in ditt användarnamn:");
                string username = Console.ReadLine();
                Console.WriteLine("Skriv in ditt lösenord");
                string password = Console.ReadLine();
                int currentUser = 0;

                if (username == users[0, 0] && password == users[0, 1])
                {
                    currentUser = 1;
                    userMenu(1);
                }
                else if (username == users[1, 0] && password == users[1, 1])
                {
                    currentUser = 2;
                    userMenu(2);
                }

                else if (username == users[2, 0] && password == users[2, 1])
                {
                    currentUser = 3;
                    userMenu(3);
                }

                else if (username == users[3, 0] && password == users[3, 1])
                {
                    currentUser = 4;
                    userMenu(4);
                }

                else if (username == users[4, 0] && password == users[4, 1])
                {
                    currentUser = 5;
                    userMenu(5);
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

        public static int userMenu(int currentUser)
        {
            Console.Clear();
            Console.WriteLine("Välj tjänst: \n1. Se dina konton och saldo \n2. Överföring mellan konton \n3. Ta ut pengar \n4. Logga ut");

            int userChoice = Int32.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    accountOverview(currentUser);
                    break;
                case 2:
                    transfer(currentUser);
                    break;
                case 3:
                    withdraw(currentUser);
                    break;
                case 4:
                    Console.WriteLine("Du loggas nu ut, tryck på valfri tangent för att fortsätta . . .");
                    Console.ReadKey();
                    userLogin();
                    break;
                default:
                    Console.WriteLine("Ogiltligt val!");
                    break;
            }
            return currentUser;
        }

        public static int accountOverview(int currentUser) //Skriver ut kontoinformationen som lagras i "userAccount"
        {
            if (currentUser == 1) //User 1
            {
                Console.Clear();
                double[] amount1 = new double[3];

                amount1[0] = 20000;
                amount1[1] = 2500;
                amount1[2] = 98789.50;

                
                string[] accName1 = new string[3];

                accName1[0] = "Sparkonto";
                accName1[1] = "Kortkonto";
                accName1[2] = "Pensionskonto";

                for (int i = 0; i < amount1.Length; i++)
                {
                    Console.Write(accName1[i] + ":");
                    Console.Write(amount1[i]);
                    Console.WriteLine();
                }
                Console.WriteLine("Tryck på enter för att komma till huvudmenyn");
                Console.ReadKey();
                userMenu(1);

            }
            if (currentUser == 2) //User 2
            {
                double[] amount2 = new double[2];
                amount2[0] = 45000;
                amount2[1] = 576.40;

                string[] accName2 = new string[2];
                accName2[0] = "Sparkonto";
                accName2[1] = "Kortkonto";

                for (int i = 0; i < amount2.Length; i++)
                {
                    Console.Write(accName2[i] + ":");
                    Console.Write(amount2[i]);
                    Console.WriteLine();
                }
                Console.WriteLine("Tryck på enter för att komma till huvudmenyn");
                Console.ReadKey();
                userMenu(2);

            }
            if (currentUser == 3) //User 3
            {
                double[] amount3 = new double[4];
                amount3[0] = 20000;
                amount3[1] = 2500;
                amount3[2] = 150000;
                amount3[3] = 125870;

                string[] accName3 = new string[4];
                accName3[0] = "Sparkonto";
                accName3[1] = "Kortkonto";
                accName3[2] = "Pensionskonto";
                accName3[3] = "Aktiekonto";

                for (int i = 0; i < amount3.Length; i++)
                {
                    Console.Write(accName3[i] + ":");
                    Console.Write(amount3[i]);
                    Console.WriteLine();
                }
                Console.WriteLine("Tryck på enter för att komma till huvudmenyn");
                Console.ReadKey();
                userMenu(3);
            }
            if (currentUser == 4) //User 4
            {
                double[] amount4 = new double[2];

                amount4[0] = 23000;
                amount4[1] = 2543.30;

                string[] accName4 = new string[2];
                accName4[0] = "Sparkonto";
                accName4[1] = "Kortkonto";

                for (int i = 0; i < amount4.Length; i++)
                {
                    Console.Write(accName4[i] + ":");
                    Console.Write(amount4[i]);
                    Console.WriteLine();
                }
                Console.WriteLine("Tryck på enter för att komma till huvudmenyn");
                Console.ReadKey();
                userMenu(4);
            }
            if (currentUser == 5) //User 5
            {
                double[] amount5 = new double[5];
                amount5[0] = 20000;
                amount5[1] = 2500;
                amount5[2] = 98789.50;
                amount5[3] = 500000;
                amount5[4] = 150000;

                string[] accName5 = new string[5];
                accName5[0] = "Sparkonto";
                accName5[1] = "Kortkonto";
                accName5[2] = "Pensionskonto";
                accName5[3] = "Aktiekonto";
                accName5[4] = "Fonder";

                for (int i = 0; i < amount5.Length; i++)
                {
                    Console.Write(accName5[i] + ":");
                    Console.Write(amount5[i]);
                    Console.WriteLine();
                }
                Console.WriteLine("Tryck på enter för att komma till huvudmenyn");
                Console.ReadKey();
                userMenu(5);
            }
            return currentUser;
        }

        public static int transfer(int currentUser)
        {
            //User 1
            if (currentUser == 1)
            {
                double[] amount1 = new double[3];

                amount1[0] = 20000;
                amount1[1] = 2500;
                amount1[2] = 98789.50;


                string[] accName1 = new string[3];

                accName1[0] = "Sparkonto";
                accName1[1] = "Kortkonto";
                accName1[2] = "Pensionskonto";


                Console.WriteLine("Välj ett konto att flytta pengar ifrån: \n 1." + accName1[0] + " \n 2." + accName1[1] + " \n 3." + accName1[2]);
                int transferAccount = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Välj ett konto att flytta pengar till: \n 1." + accName1[0] + " \n 2." + accName1[1] + " \n 3." + accName1[2]);
                int recieverAccount = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Vilken summa vill du överföra?");
                double sum = Double.Parse(Console.ReadLine());


                if (transferAccount == 1)
                {
                    amount1[0] = amount1[0] - sum;
                }
                else if (transferAccount == 2)
                {
                    amount1[1] = amount1[1] - sum;
                }
                else if (transferAccount == 3)
                {
                    amount1[2] = amount1[2] - sum;
                }

                if (recieverAccount == 1)
                {
                    amount1[0] = amount1[0] + sum;
                }
                else if (recieverAccount == 2)
                {
                    amount1[1] = amount1[1] + sum;
                }
                else if (recieverAccount == 3)
                {
                    amount1[2] = amount1[2] + sum;
                }


                Console.WriteLine("Ditt nya saldor är:");

                for (int i = 0; i < amount1.Length; i++)
                {
                    Console.Write(accName1[i] + ":");
                    Console.Write(amount1[i]);
                    Console.WriteLine();
                }
                Console.WriteLine("Tryck på enter för att komma till huvudmenyn");
                Console.ReadKey();
                userMenu(1);
            }
        

            //User 2
            else if (currentUser == 2)
            {
                double[] amount2 = new double[2];
                amount2[0] = 45000;
                amount2[1] = 576.40;

                string[] accName2 = new string[2];
                accName2[0] = "Sparkonto";
                accName2[1] = "Kortkonto";

                Console.WriteLine("Välj ett konto att flytta pengar ifrån: \n 1." + accName2[0] + " \n 2." + accName2[1]);
                int transferAccount = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Välj ett konto att flytta pengar till: \n 1." + accName2[0] + " \n 2." + accName2[1]);
                int recieverAccount = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Vilken summa vill du överföra?");
                double sum = Double.Parse(Console.ReadLine());

                   
                    if (transferAccount == 1)
                    {
                        amount2[0] = amount2[0] - sum;
                    }
                    else if (transferAccount == 2)
                    {
                        amount2[1] = amount2[1] - sum;
                    }
                    

                    if (recieverAccount == 1)
                    {
                        amount2[0] = amount2[0] + sum;
                    }
                    else if (recieverAccount == 2)
                    {
                        amount2[1] = amount2[1] + sum;
                    }
                    
                Console.WriteLine("Ditt nya saldor är:");

                for (int i = 0; i < amount2.Length; i++)
                {
                    Console.Write(accName2[i] + ":");
                    Console.Write(amount2[i]);
                    Console.WriteLine();
                }
                Console.WriteLine("Tryck på enter för att komma till huvudmenyn");
                Console.ReadKey();
                userMenu(2);
            }

            //User 3
            else if (currentUser == 3)
            {
                double[] amount3 = new double[4];
                amount3[0] = 20000;
                amount3[1] = 2500;
                amount3[2] = 150000;
                amount3[3] = 125870;

                string[] accName3 = new string[4];
                accName3[0] = "Sparkonto";
                accName3[1] = "Kortkonto";
                accName3[2] = "Pensionskonto";
                accName3[3] = "Aktiekonto";

                Console.WriteLine("Välj ett konto att flytta pengar ifrån: \n 1." + accName3[0] + " \n 2." + accName3[1] + " \n 3." + accName3[2] + "\n 4." + accName3[3]);
                int transferAccount = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Välj ett konto att flytta pengar till: \n 1." + accName3[0] + " \n 2." + accName3[1] + " \n 3." + accName3[2] + "\n 4." + accName3[3]);
                int recieverAccount = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Vilken summa vill du överföra?");
                double sum = Double.Parse(Console.ReadLine());


                if (transferAccount == 1)
                {
                    amount3[0] = amount3[0] - sum;
                }
                else if (transferAccount == 2)
                {
                    amount3[1] = amount3[1] - sum;
                }
                else if (transferAccount == 3)
                {
                    amount3[2] = amount3[2] - sum;
                }
                else if (transferAccount == 4)
                {
                    amount3[3] = amount3[3] - sum;
                }

                if (recieverAccount == 1)
                {
                    amount3[0] = amount3[0] + sum;
                }
                else if (recieverAccount == 2)
                {
                    amount3[1] = amount3[1] + sum;
                }
                else if (recieverAccount == 3)
                {
                    amount3[2] = amount3[2] + sum;
                }
                else if (recieverAccount == 4)
                {
                    amount3[3] = amount3[3] + sum;
                }
                Console.WriteLine("Ditt nya saldor är:");

                for (int i = 0; i < amount3.Length; i++)
                {
                    Console.Write(accName3[i] + ":");
                    Console.Write(amount3[i]);
                    Console.WriteLine();
                }
                Console.WriteLine("Tryck på enter för att komma till huvudmenyn");
                Console.ReadKey();
                userMenu(3);
            }

            //User 4
            else if (currentUser == 4)
            {
                double[] amount4 = new double[2];

                amount4[0] = 23000;
                amount4[1] = 2543.30;

                string[] accName4 = new string[2];
                accName4[0] = "Sparkonto";
                accName4[1] = "Kortkonto";

                Console.WriteLine("Välj ett konto att flytta pengar ifrån: \n 1." + accName4[0] + " \n 2." + accName4[1]);
                int transferAccount = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Välj ett konto att flytta pengar till: \n 1." + accName4[0] + " \n 2." + accName4[1]);
                int recieverAccount = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Vilken summa vill du överföra?");
                double sum = Double.Parse(Console.ReadLine());

                if (transferAccount == 1)
                {
                    amount4[0] = amount4[0] - sum;
                }
                else if (transferAccount == 2)
                {
                    amount4[1] = amount4[1] - sum;
                }


                if (recieverAccount == 1)
                {
                    amount4[0] = amount4[0] + sum;
                }
                else if (recieverAccount == 2)
                {
                    amount4[1] = amount4[1] + sum;
                }

                Console.WriteLine("Ditt nya saldor är:");

                for (int i = 0; i < amount4.Length; i++)
                {
                    Console.Write(accName4[i] + ":");
                    Console.Write(amount4[i]);
                    Console.WriteLine();
                }
                Console.WriteLine("Tryck på enter för att komma till huvudmenyn");
                Console.ReadKey();
                userMenu(4);
            }

            //User 5
            else if (currentUser == 5)
            {
                double[] amount5 = new double[5];
                amount5[0] = 20000;
                amount5[1] = 2500;
                amount5[2] = 98789.50;
                amount5[3] = 500000;
                amount5[4] = 150000;

                string[] accName5 = new string[5];
                accName5[0] = "Sparkonto";
                accName5[1] = "Kortkonto";
                accName5[2] = "Pensionskonto";
                accName5[3] = "Aktiekonto";
                accName5[4] = "Fonder";

                Console.WriteLine("Välj ett konto att flytta pengar ifrån: \n 1." + accName5[0] + " \n 2." + accName5[1] + " \n 3." + accName5[2] + "\n 4." + accName5[3] + "\n 5." + accName5[4]);
                int transferAccount = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Välj ett konto att flytta pengar till: \n 1." + accName5[0] + " \n 2." + accName5[1] + " \n 3." + accName5[2] + "\n 4." + accName5[3] + "\n 5." + accName5[4]);
                int recieverAccount = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Vilken summa vill du överföra?");
                double sum = Double.Parse(Console.ReadLine());


                if (transferAccount == 1)
                {
                    amount5[0] = amount5[0] - sum;
                }
                else if (transferAccount == 2)
                {
                    amount5[1] = amount5[1] - sum;
                }
                else if (transferAccount == 3)
                {
                    amount5[2] = amount5[2] - sum;
                }
                else if (transferAccount == 4)
                {
                    amount5[3] = amount5[3] - sum;
                }
                else if (transferAccount == 5)
                {
                    amount5[3] = amount5[3] - sum;
                }

                if (recieverAccount == 1)
                {
                    amount5[0] = amount5[0] + sum;
                }
                else if (recieverAccount == 2)
                {
                    amount5[1] = amount5[1] + sum;
                }
                else if (recieverAccount == 3)
                {
                    amount5[2] = amount5[2] + sum;
                }
                else if (recieverAccount == 4)
                {
                    amount5[3] = amount5[3] + sum;
                }
                else if (recieverAccount == 5)
                {
                    amount5[3] = amount5[3] + sum;
                }

                Console.WriteLine("Ditt nya saldor är:");

                for (int i = 0; i < amount5.Length; i++)
                {
                    Console.Write(accName5[i] + ":");
                    Console.Write(amount5[i]);
                    Console.WriteLine();
                }
                Console.WriteLine("Tryck på enter för att komma till huvudmenyn");
                Console.ReadKey();
                userMenu(5);
            }

            return currentUser;
        }

        public static int withdraw(int currentUser)
        {
            //user 1
            if (currentUser == 1)
            {
                double[] amount1 = new double[3];

                amount1[0] = 20000;
                amount1[1] = 2500;
                amount1[2] = 98789.50;


                string[] accName1 = new string[3];

                accName1[0] = "Sparkonto";
                accName1[1] = "Kortkonto";
                accName1[2] = "Pensionskonto";

                Console.WriteLine("välj vilket konto du vill ta ut pengar ifrån: \n1." + accName1[0] + "\n 2." + accName1[1] + "\n3." + accName1[2]);
                int witdrawAccount = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Hur stor summa vill du ta ut?");
                int sum = Int32.Parse(Console.ReadLine());

                if (witdrawAccount == 1)
                {
                    amount1[0] = amount1[0]- sum;
                }
                else if (witdrawAccount == 2)
                {
                    amount1[1] = amount1[1] - sum;
                }
                else if (witdrawAccount == 3)
                {
                    amount1[2] = amount1[2] - sum;
                }
                Console.WriteLine("Ditt nya saldor är:");

                for (int i = 0; i < amount1.Length; i++)
                {
                    Console.Write(accName1[i] + ":");
                    Console.Write(amount1[i]);
                    Console.WriteLine();
                }
                Console.WriteLine("Tryck på enter för att komma till huvudmenyn");
                Console.ReadKey();
                userMenu(1);
            }

            //user 2
            else if (currentUser == 2)
            {
                double[] amount2 = new double[2];
                amount2[0] = 45000;
                amount2[1] = 576.40;

                string[] accName2 = new string[2];
                accName2[0] = "Sparkonto";
                accName2[1] = "Kortkonto";

                Console.WriteLine("välj ett konto att ta ut pengar ifrån: \n1." + accName2[0] + "\n 2." + accName2[1]);
                int witdrawAccount = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Hur stor summa vill du ta ut?");
                int sum = Int32.Parse(Console.ReadLine());

                if (witdrawAccount == 1)
                {
                    amount2[0] = amount2[0] - sum;
                }
                else if (witdrawAccount == 2)
                {
                    amount2[1] = amount2[1] - sum;
                }
                Console.WriteLine("Ditt nya saldor är:");

                for (int i = 0; i < amount2.Length; i++)
                {
                    Console.Write(accName2[i] + ":");
                    Console.Write(amount2[i]);
                    Console.WriteLine();
                }
                Console.WriteLine("Tryck på enter för att komma till huvudmenyn");
                Console.ReadKey();
                userMenu(2);
            }


            //user 3
            else if (currentUser == 3)
            {
                double[] amount3 = new double[4];
                amount3[0] = 20000;
                amount3[1] = 2500;
                amount3[2] = 150000;
                amount3[3] = 125870;

                string[] accName3 = new string[4];
                accName3[0] = "Sparkonto";
                accName3[1] = "Kortkonto";
                accName3[2] = "Pensionskonto";
                accName3[3] = "Aktiekonto";

                Console.WriteLine("Välj ett konto att ta ut pengar ifrån: \n 1." + accName3[0] + " \n 2." + accName3[1] + " \n 3." + accName3[2] + "\n 4." + accName3[3]);
                int witdrawAccount = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Hur stor summa vill du ta ut?");
                int sum = Int32.Parse(Console.ReadLine());

                if (witdrawAccount == 1)
                {
                    amount3[0] = amount3[0] - sum;
                }
                else if (witdrawAccount == 2)
                {
                    amount3[1] = amount3[1] - sum;
                }
                else if (witdrawAccount == 3)
                {
                    amount3[2] = amount3[2] - sum;
                }
                else if (witdrawAccount == 4)
                {
                    amount3[3] = amount3[3] - sum;
                }
                Console.WriteLine("Ditt nya saldor är:");

                for (int i = 0; i < amount3.Length; i++)
                {
                    Console.Write(accName3[i] + ":");
                    Console.Write(amount3[i]);
                    Console.WriteLine();
                }
                Console.WriteLine("Tryck på enter för att komma till huvudmenyn");
                Console.ReadKey();
                userMenu(3);
            }

            //user 4
            else if (currentUser == 4)
            {
                double[] amount4 = new double[2];

                amount4[0] = 23000;
                amount4[1] = 2543.30;

                string[] accName4 = new string[2];
                accName4[0] = "Sparkonto";
                accName4[1] = "Kortkonto";

                Console.WriteLine("Välj ett konto att ta ut pengar ifrån: \n 1." + accName4[0] + " \n 2." + accName4[1]);
                int witdrawAccount = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Hur stor summa vill du ta ut?");
                int sum = Int32.Parse(Console.ReadLine());

                if (witdrawAccount == 1)
                {
                    amount4[0] = amount4[0] - sum;
                }
                else if (witdrawAccount == 2)
                {
                    amount4[1] = amount4[1] - sum;
                }

                Console.WriteLine("Ditt nya saldor är:");

                for (int i = 0; i < amount4.Length; i++)
                {
                    Console.Write(accName4[i] + ":");
                    Console.Write(amount4[i]);
                    Console.WriteLine();
                }
                Console.WriteLine("Tryck på enter för att komma till huvudmenyn");
                Console.ReadKey();
                userMenu(4);
            }


            //user 5
            else if (currentUser == 5)
            {
                double[] amount5 = new double[5];
                amount5[0] = 20000;
                amount5[1] = 2500;
                amount5[2] = 98789.50;
                amount5[3] = 500000;
                amount5[4] = 150000;

                string[] accName5 = new string[5];
                accName5[0] = "Sparkonto";
                accName5[1] = "Kortkonto";
                accName5[2] = "Pensionskonto";
                accName5[3] = "Aktiekonto";
                accName5[4] = "Fonder";
                Console.WriteLine("Välj ett konto att ta ut pengar ifrån: \n 1." + accName5[0] + " \n 2." + accName5[1] + " \n 3." + accName5[2] + "\n 4." + accName5[3] + "\n 5." + accName5[4]);
                int witdrawAccount = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Hur stor summa vill du ta ut?");
                int sum = Int32.Parse(Console.ReadLine());

                if (witdrawAccount == 1)
                {
                    amount5[0] = amount5[0] - sum;
                }
                else if (witdrawAccount == 2)
                {
                    amount5[1] = amount5[1] - sum;
                }
                else if (witdrawAccount == 3)
                {
                    amount5[2] = amount5[2] - sum;
                }
                else if (witdrawAccount == 4)
                {
                    amount5[2] = amount5[2] - sum;
                }
                else if (witdrawAccount == 5)
                {
                    amount5[2] = amount5[2] - sum;
                }

                Console.WriteLine("Ditt nya saldor är:");

                for (int i = 0; i < amount5.Length; i++)
                {
                    Console.Write(accName5[i] + ":");
                    Console.Write(amount5[i]);
                    Console.WriteLine();
                }
                Console.WriteLine("Tryck på enter för att komma till huvudmenyn");
                Console.ReadKey();
                userMenu(5);
            }

            
            return currentUser;
            
            
        }
      
    }
}
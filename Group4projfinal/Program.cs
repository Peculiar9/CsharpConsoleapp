using System;

namespace BankApp
{
    class First
    {
        //declaring Global Variables
        static string name, mname, lname;
        static int day, month, year, loanoption, moveon, required, option, fundnew, next;
        static float new_balance1, new_balance2, amount, balance, loanam, deposit, withdraw_amount;
        static float funding = 2000;

  
        static void welcome()
        {

            Console.WriteLine("   \n");
            Console.WriteLine("Welcome to LAUTECH BANK\n");
            Console.WriteLine("     \n");
            Console.WriteLine("Press 1 to Create an account\n");
            Console.WriteLine("     \n");
            Console.WriteLine("Press 2 to Deposit\n");
            Console.WriteLine("     \n");
            Console.WriteLine("Press 3 to apply for a loan\n");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                biodata();
            }
            else if (option == 2)
            {
                Console.WriteLine("     \n");
                Console.WriteLine("Deposit menu\n");
                loginrequired();
            }
            else if (option == 3)
            {
                Console.WriteLine("     \n");
                Console.WriteLine("Loan menu\n");
                loanmenu();
            }
            else
            {
                Console.WriteLine("Invalid input\n");
            }

        }


        //Function for the users biodata
        static void biodata()
        {
            Console.WriteLine("   \n");
            Console.WriteLine("Welcome back! Please fill in your biodatas \n");
            Console.WriteLine("Enter First name\n");
            name = Console.ReadLine();
            Console.WriteLine("Enter Last name\n");
            lname = Console.ReadLine();

            Console.WriteLine("Enter mother's middle name\n");
            mname = Console.ReadLine();
            Console.WriteLine("Day of Birth\n");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Month of Birth\n");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Year of birth\n");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first deposit amount\n");
            deposit = int.Parse(Console.ReadLine());

            Console.WriteLine("     \n");
            Console.WriteLine("     \n");

            Console.WriteLine("Kindly check the information you entered for confirmation\n");
            Console.WriteLine("     \n");
            Console.WriteLine("Full name :- {0} {1} ", name, lname + " \n");
            Console.WriteLine("     \n");
            Console.WriteLine("Mother's middle name' :-{0} ", mname + " \n");
            Console.WriteLine("     \n");
            Console.WriteLine("Date Of Birth :-{0}-{1}-{2} ", day, month, year + " \n");
            Console.WriteLine("     \n");
            Console.WriteLine("Opening Balance :- #{0}", deposit + " \n");


            Console.WriteLine("     \n");
            Console.WriteLine("     \n");


            Console.WriteLine("Press 1 to make a deposit\n");
            Console.WriteLine("     \n");
            Console.WriteLine("Press 2 to apply for a loan\n");
            Console.WriteLine("     \n");
            Console.WriteLine("Press 3 to make a withdrawal \n");
            moveon = int.Parse(Console.ReadLine());

            if (moveon == 1)
            {
                Console.WriteLine("Loading Deposit menu.......\n");
                depositmenu();
            }
            else if (moveon == 2)
            {
                Console.WriteLine("Loading Loan menu.......\n");
                loanmenu();
            }
            else if (moveon == 3)
            {
                Console.WriteLine("Loading Withdrawal menu.......\n");
                withdrawal();
            }
            else
            {
                Console.WriteLine(" Error Found!!!");
            }

        }

        //Function for the users deposit
        static void depositmenu()
        {
            Console.WriteLine("Welcome to the deposit menu\n");
            Console.WriteLine("     \n");
            Console.WriteLine("Your current balance is :- #{0}{0}", deposit + " \n");
            Console.WriteLine("     \n");
            Console.WriteLine("To make a deposit press 1\n");
            Console.WriteLine("     \n");
            Console.WriteLine("To apply for loan press 2\n");
            Console.WriteLine("     \n");
            Console.WriteLine("Go back to main menu press 3\n");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Welcome to deposit menu\n");
                    Console.WriteLine("   \n");
                    Console.WriteLine("Please enter amount\n");
                    amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("     \n");
                    Console.WriteLine("     \n");
                    new_balance1 = deposit + amount;
                    Console.WriteLine("   \n");
                    Console.WriteLine("Your new balance is :- #{0}", new_balance1 + " \n");
                    break;
                case 2: loanmenu();
                    break;
                case 3: welcome();
                    break;
            }


        }


        //Function for the withdrawal
        static void withdrawal()
        {

            Console.WriteLine("    \n");
            Console.WriteLine("welcome to Withdrawal menu\n");
            Console.WriteLine("   \n");
            Console.WriteLine("How much did you want to withdraw?\n");
            withdraw_amount = float.Parse(Console.ReadLine());
            Console.WriteLine("Your remaining balance is :{0}", deposit - withdraw_amount + " \n");
            Console.WriteLine("   \n");
            Console.WriteLine("Transaction Successful !!!\n");
            Console.WriteLine("   \n");
            Console.WriteLine("Do you still want to perform another Transaction ?\n");
            Console.WriteLine("   \n");
            Console.WriteLine("Press 1 for a new transaction  \n");
            Console.WriteLine("   \n");
            Console.WriteLine("Press 2 to Exit \n");
            next = int.Parse(Console.ReadLine());
            if (next == 1)
            {
                welcome();
            }
            else if (next == 2)
            {
                Console.WriteLine("Thanks for Banking with us\n");
                Console.ReadKey();
            }

        }

        //Function for the load
        static void loanmenu()
        {
            Console.WriteLine("    \n");
            Console.WriteLine("welcome to loan menu\n");
            Console.WriteLine("   \n");
            Console.WriteLine("There is a interest rate of 1.35% add to loans after month allocated is due \n");
            Console.WriteLine("To apply for a loan you must meet the following requirement!!\n");
            Console.WriteLine("   \n");
            Console.WriteLine("You must have at least " + funding + " in your account\n");
            Console.WriteLine("   \n");
            Console.WriteLine("To continue press 1\n");
            Console.WriteLine("   \n");
            Console.WriteLine("To exit press 2\n");
            loanoption = int.Parse(Console.ReadLine());
            if (loanoption == 1)
            {
                Console.WriteLine("   \n");
                Console.WriteLine("Checking if you meet the loan requirements......\n");
                if (deposit > funding)
                {
                    Console.WriteLine("   \n");
                    Console.WriteLine("you are qualified for the loan\n");
                    Console.WriteLine("   \n");
                    Console.WriteLine("enter amount of loan you need\n");
                    loanam = Convert.ToInt32(Console.ReadLine());
                    new_balance2 = deposit + loanam;
                    Console.WriteLine("   \n");
                    Console.WriteLine("your new balance is : " + new_balance2);
                }
                else
                {
                    Console.WriteLine("   \n");
                    Console.WriteLine("you don't qualify for a loan\n");
                    Console.WriteLine("   \n");
                    Console.WriteLine("your current balance is :" + new_balance1 + " \n");
                    Console.WriteLine("   \n");
                    Console.WriteLine("you need a minimum of  #{0}" + funding + " to apply for a loan\n");
                    Console.WriteLine("   \n");
                    Console.WriteLine("To make a deposit press 1\n");
                    Console.WriteLine("   \n");
                    Console.WriteLine("To exit press 2\n");
                    fundnew = int.Parse(Console.ReadLine());
                    if (fundnew == 1)
                    {
                        loginrequired();
                        depositmenu();
                    }
                    else if (fundnew == 2)
                    {
                        Console.ReadKey();
                    }
                }
            }
            else if (loanoption == 2)
            {

                Console.ReadKey();
            }


        }


        //function to check if the user is register 
        static void loginrequired()
        {
            Console.WriteLine("   \n");
            Console.WriteLine("YOU NEED TO HAVE AN ACCOUNT BEFORE YOU CAN PERFORM THIS OPERATION!!!\n");
            Console.WriteLine("   \n");
            Console.WriteLine("Press 1 to go to registration\n");
            Console.WriteLine("   \n");
            Console.WriteLine("Press 2 to exit\n");
            required = int.Parse(Console.ReadLine());
            if (required == 1)
            {
                biodata();
            }
            else if (required == 2)
            {
                Console.ReadKey(); ;
            }
        }

        static void Main()
        {
            welcome();
        }
    }
}
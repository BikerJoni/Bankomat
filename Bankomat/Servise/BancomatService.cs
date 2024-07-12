using Bankomat.Models;
using System;
namespace Bankomat.BancomatServise;

class BancomatService : Loger
{
    private static object usersCard;

    public void UsingBancomat()
    {
        Model usersCard = new Model();
    }

    private static void usingBancomat()
    {

        string userCoise;
        do
        {

            int myBalance = 100;
            Console.WriteLine($"Hush kelibsiz!  Hisobingizdagi mablag': {myBalance}$");
            Console.WriteLine("choose the operation: \n1=>Take cash money \n2=> Activate sms notification function \n3=> Transactions \n4=> Quit ");
            int userChoiseOperation = Convert.ToInt32(Console.ReadLine());
            switch (userChoiseOperation)
            {
                case 1: TakeCash(); break;
                case 2: ActivateSms(); break;
                case 3: Transactions(); break;
                case 4: Quite(); break;

                default: Console.WriteLine("Please enter the numbers from 1 to 4"); break;

            }
            Console.WriteLine("if you want to continue press +");
            userCoise = Console.ReadLine();
        }
        while (userCoise is "+");
    }

    private static void Quite()
    {
        Console.WriteLine("Close the program");
    }

    private static void ActivateSms()
    {
        Console.WriteLine("Enter the phone number ");
        Console.Write("+998");
        string inputCode = Console.ReadLine();
        int userdCode = Convert.ToInt32(inputCode);
        string inputNumber = Console.ReadLine();
        int usersNumber = Convert.ToInt32(inputNumber);
        if (usersNumber > 1000000 && usersNumber < 9999999 && userdCode > 10 && userdCode < 99)
        {
            Console.WriteLine("Your number succsessfully activated!");
        }
        else
        {
            Console.WriteLine("You entered wrong number try again");
        }
    }


    private static void Transactions()
    {
        Console.Write("Enter resivers card number: ");
        string inputCardNumber = Console.ReadLine();
        decimal usersCardNumber = decimal.Parse(inputCardNumber);
        
        if (1000 < usersCardNumber && usersCardNumber < 9999)
        {
            Console.WriteLine(usersCardNumber);
        }
        else
        {
            Console.WriteLine("Invalit number, try again");
        }
        
    }

    private static void TakeCash()
    {
        Console.WriteLine("Enter password");
        int inputPassword = int.Parse(Console.ReadLine());
        if (inputPassword is usersCard.LoginService && inputPassword != null)
        {

            Console.WriteLine("\n1=> 10$ 2=>\n20$ 3=>50$ \n4=> another amount ");
            string amount = Console.ReadLine();
            int userChoise = Convert.ToInt32(amount);

            switch (userChoise)
            {
                case 1:
                    if (10 <= usersCard.CardBalance)
                    {
                        usersCard.CardBalance = usersCard.CardBalance - 10;
                    }
                    break;
                case 2:
                    if (20 <= usersCard.CardBalance)
                    {
                        usersCard.CardBalance -= 20;
                    }
                    break;
                case 3:
                    if (50 <= usersCard.CardBalance)
                    {
                        usersCard.CardBalance -= 50;
                    }
                    break;
                case 4:
                    Console.Write("Enter the amount:");
                    string inputAmount = Console.ReadLine();
                    int enteredAmount = Convert.ToInt32(inputAmount);
                    if (enteredAmount > 0 && enteredAmount < usersCard.CardBalance)
                    {
                        usersCard.CardBalance -= enteredAmount;
                    }
                    break;

            }
        }
    }

    internal override void LogInformation()
    {
        throw new NotImplementedException();
    }
}



//Class Name: Week 1 Practical
//Version 1
//Author: Aaron Convery







//BuildBankingApp();

void BuildBankingApp()
{
    char choice = 'A';
    double depositAmmount = 0;
    double accountBalance = 0;

    Console.WriteLine("Please choose an option\n=====================\n1 - Deposit or withdraw funds\n2 - View current account information\nPlease choose an option (1-2)");
    choice = Convert.ToChar(Console.ReadLine());

    switch (choice)
    {
        case '1':
            Console.WriteLine("You have chosen to deposit or withdraw funds\nHow much do you want to deposit?\nEnter ammount including pence using a decimal point");
            depositAmmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your original account balance is {accountBalance}");
            accountBalance += depositAmmount;
            Console.WriteLine($"Your new account balance is {accountBalance}");
            break;
        case '2':
            Console.WriteLine("You have chosen to view current account information");
            accountBalance = 1000.00;
            Console.WriteLine($"Your current account balance is {accountBalance}");

            break;
        default:
            Console.WriteLine("Invalid choice, please choose 1 or 2");
            break;

    }
}



//Class Name: Week 1 Practical
//Version 1
//Author: Aaron Convery


Week1Practical();

void Week1Practical()
{
    //Task 1
    Console.WriteLine("Please enter your name: ");
    string name = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Please enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Hello {name}, you will be {age + 5} in 5 years");

    //Task 2
    if (age >= 0 || age <= 110)
    {
        if (age < 13)
        {
            Console.WriteLine("You are a child");
        }
        else if (age >= 13 || age <= 19)
        {
            Console.WriteLine("You are a teenager");
        }
        else if (age > 19)
        {
            Console.WriteLine("You are an adult");
        }
    }
    else
    {
        Console.WriteLine("Invalid age");
    }

    //Task 3
    Console.WriteLine("Please enter an integer: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number < 0)
    {
        Console.WriteLine("This number is negative");
    }
    else if (number > 0)
    {
        Console.WriteLine("This number is positive");
    }
    else
    {
        Console.WriteLine("This number is zero");
    }

    //Task 4
    Console.WriteLine("Please enter a year: ");
    int year = Convert.ToInt32(Console.ReadLine());

    if (year < 0)
    {
        Console.WriteLine("This is not a valid year");
    }
    else if (year % 4 == 0 || year % 100 == 1)
    {
        Console.WriteLine("This is a leap year");
    }
    else
    {
        Console.WriteLine("This is not a leap year");
    }

    //Task 5
    Console.WriteLine("Please enter an integer: ");
    number = Convert.ToInt32(Console.ReadLine());

    if (number % 2 == 0)
    {
        Console.WriteLine("This number is even");
    }
    else
    {
        Console.WriteLine("This number is odd");
    }

    //Task 6
    //Save and Quit

}



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


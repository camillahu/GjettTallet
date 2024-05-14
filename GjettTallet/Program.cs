bool running = true;

Run();

void Run()
{
    Console.WriteLine("Welcome to the number guessing game! \n Please guess a number between 1 and 100.");
    int GeneratedNum = GenerateNum();
    while (running)
    {
        string UserInput = Console.ReadLine();
        int ConvertedUserInput = ConvertUserInput(UserInput);
        Result(GeneratedNum, ConvertedUserInput);
    }
    
}

int GenerateNum()
{
    Random random = new Random();
    int randomNum = random.Next(1, 101);

    return randomNum;

}

int ConvertUserInput(string input)
{
   int parsedInt= int.Parse(input);
   return parsedInt;

}

void Result(int Num, int UserNum)
{
    if (UserNum == Num)
    {
        Console.WriteLine("Correct! Do you want to play again? \n Type 'yes' or 'no");
        string YesOrNo = Console.ReadLine();

        if (YesOrNo == "yes" || YesOrNo == "Yes" || YesOrNo == "YES")
        {
            Run();
        }
        else if (YesOrNo == "no" || YesOrNo == "No" || YesOrNo == "NO")
        {
            Console.WriteLine("Thank you for playing. Goodbye!");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("There was an error reading your input. Exit manually or continue playing.");
            Run();
        }
    }
    else if (UserNum < Num)
    {
        Console.WriteLine("Too Low!");
    }
    else if (UserNum > Num)
    {
        Console.WriteLine("Too High!");
    }
    else
    {
        Console.WriteLine("There was an error reading your input.Please try again.");
    }
}


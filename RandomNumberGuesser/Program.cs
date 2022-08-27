// See https://aka.ms/new-console-template for more information


Random r = new Random();
int winNumber = r.Next(0, 100);
bool win = false;

do
{
    Console.Write("Guess a number between 0 and 100: ");
    string s = Console.ReadLine();


    int i = int.Parse(s);

    if (i > winNumber) {
        Console.WriteLine("Too High!");
    }
    else if (i < winNumber) {
        Console.WriteLine("Too Low!");
    }
    else if (i == winNumber)
    {
        Console.WriteLine("You Win!");
        win = true;
    }

    Console.WriteLine();

} while (win == false);
Console.WriteLine("Thank you for playing the game");
Console.Write("Press any key to finish.");
Console.ReadKey(true);


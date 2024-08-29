using System;


static string[] MakeUnderScores(string word)
{
    string[] underscores = new string[word.Length];

    for (int i = 0; i < underscores.Length; i++)
    {
        underscores[i] = "_";
    }
    return underscores;
}

string word = "Sigma";

List<string> wrongGuesses = new();

string[] hiddenword = MakeUnderScores(word);

// string[] hiddenword = {"_", "_",  "_", "_", "_", };
Console.WriteLine("välkommen till hangman!");
Console.WriteLine("\nGissa en bokstav!");
int lives = 6;

while (wrongGuesses.Count < lives && string.Join("", hiddenword) != word)
{

    Console.WriteLine(String.Join(" ", hiddenword));

    string guess = "";
    while (guess.Length != 1 )
    {
        guess = Console.ReadLine();
    }

    if (word.Contains(guess[0]))

    {
        Console.WriteLine("yay");
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == guess[0])
            {
                hiddenword[i] = guess;
            }
            // if (word == true)
            // {
            //     Console.ReadLine();
            // }
        }

        // int pos = word.IndexOf (guess[0]);
        // hiddenword[pos] = guess;
    }
    else
    {
        Console.WriteLine("boo");
        wrongGuesses.Add(guess);
        if (wrongGuesses.Count == 0)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("   ===");
        }
        else if (wrongGuesses.Count == 1)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine("O   |");
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("   ===");
        }
        else if (wrongGuesses.Count == 2)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine("O   |");
            Console.WriteLine("|   |");
            Console.WriteLine("    |");
            Console.WriteLine("   ===");
        }
        else if (wrongGuesses.Count == 3)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine(" O  |");
            Console.WriteLine("/|  |");
            Console.WriteLine("    |");
            Console.WriteLine("   ===");
        }
        else if (wrongGuesses.Count == 4)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine(" O  |");
            Console.WriteLine("/|\\ |");
            Console.WriteLine("    |");
            Console.WriteLine("   ===");
        }
        else if (wrongGuesses.Count == 5)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine(" O  |");
            Console.WriteLine("/|\\ |");
            Console.WriteLine("/   |");
            Console.WriteLine("   ===");
        }
        else if (wrongGuesses.Count == 6)
        {
            Console.WriteLine("\n+---+");
            Console.WriteLine(" O   |");
            Console.WriteLine("/|\\  |");
            Console.WriteLine("/ \\  |");
            Console.WriteLine("    ===");
        }

    }

}

Console.WriteLine("Spelet är över!");
if (wrongGuesses.Count == 6)
{
    Console.WriteLine("Du är sämst");
}

if (string.Join("", hiddenword) == word)

{
    Console.WriteLine("Du är bäst");
}

Console.ReadLine();



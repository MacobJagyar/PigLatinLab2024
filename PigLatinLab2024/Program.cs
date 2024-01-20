while (true)
{
    Console.Write("Enter a word or phrase to have it changed to Pig Latin: ");
    string input = Console.ReadLine();

    Console.WriteLine("Your word/phrase in Pig Latin: " + ConvertSentence(input));
    Console.Write("\n\nWould you like to restart (y/n)? ");
    string loopChoice = Console.ReadLine().ToUpper();

    if (loopChoice == "Y")
    {
        Console.WriteLine("\nRestarting");
        Thread.Sleep(1500);
        Console.Clear();
    }
    else if (loopChoice == "N")
    {
        Console.WriteLine("\nGoodbye!");
        break;
    }
    else
    {
        Console.WriteLine("\nThat wasn't y or n. Restarting anyway");
        Thread.Sleep(1500);
        Console.Clear();
    }

}

static string ConvertToPigLatin(string word)
{
    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

    if (string.IsNullOrWhiteSpace(word))
    {
        return word;
    }

    word = word.ToLower();
    char firstLetter = word[0];

    if (Array.IndexOf(vowels, firstLetter) != -1)
    {
        return word + "way";
    }
    else
    {
        return word.Substring(1) + firstLetter + "ay";
    }
}

static string ConvertSentence(string sentence)
{
    string[] words = sentence.Split(' ');

    for (int i = 0; i <words.Length; i++)
    {
        words[i] = ConvertToPigLatin(words[i]);
    }

    return string.Join(" ", words);
}

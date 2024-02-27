// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a word!");
string userInput = Console.ReadLine();
Console.WriteLine(mostFrequentCharacter(userInput));

char mostFrequentCharacter(string userInput)
{
    Dictionary<char, int> charCount = new Dictionary<char, int>();
    userInput.ToLower();
    foreach (char character in userInput)
    {
        if (charCount.ContainsKey(character)) {
            charCount[character]++;
        } 
        else
        {
            charCount[character] = 1;
        }
    }
    char mostFrequentChar = ' ';
    int numChar = 0;
    foreach (KeyValuePair<char, int> pair in charCount)
    {
        if (pair.Value > numChar)
        {
            numChar = pair.Value;
            mostFrequentChar = pair.Key;
        }
    }
    return mostFrequentChar;
}
static void SwapArray(char[] inputToArray)
{
    int finalPointer = inputToArray.Length - 1;
    char temp;

    for (int initialPointer = 0; initialPointer < inputToArray.Length; initialPointer++)
    {
        if (initialPointer > finalPointer)
        {
            break;
        }

        temp = inputToArray[initialPointer];

        inputToArray[initialPointer] = inputToArray[finalPointer];

        inputToArray[finalPointer] = temp;

        finalPointer--;
    }
}

string? input;
bool isContinue = true;

while (isContinue)
{
    Console.WriteLine("Enter a string: ");
    input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Input string is null or empty.");
    }
    else
    {
        char[] inputToArray = input.ToCharArray();
        SwapArray(inputToArray);
        Console.WriteLine($"Swap String: {new string(inputToArray)}");
    }

    Console.WriteLine("Do you want to continue? (Y/N)");
    isContinue = Console.ReadLine()?.ToUpper() == "Y";
}


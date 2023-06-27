void FillArray(string[] array)
{
    for (int word = 0; word < array.Length; word++)
    {
        Console.Write($"Enter the word [{word + 1}] = ");
        array[word] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");

    for (int word = 0; word < array.Length; word++)
    {
        if (word == array.Length - 1)
            Console.WriteLine("\"{0}\"]", array[word]);
        else
            Console.Write("\"{0}\", ", array[word]);
    }
}

string[] CreateNewArray(string[] oldArray)
{
    int words = 0;

    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= LimitsConst.charLimit)
            words++;
    }

    string[] newArray = new string[words];
    int n = 0;

    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= LimitsConst.charLimit)
        {
            newArray[n] = oldArray[i];
            n++;
        }
    }

    return newArray;
}

Console.Write("Enter the number of words = ");
int words = Convert.ToInt32(Console.ReadLine());

string[] array = new string[words];

FillArray(array);

string[] newArray = CreateNewArray(array);

Console.WriteLine("\nWords with a length of {0} characters or less:",
                  LimitsConst.charLimit);
PrintArray(newArray);

static class LimitsConst
{
    public const int charLimit = 3;
}
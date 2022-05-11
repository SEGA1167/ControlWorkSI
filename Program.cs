// Контрольная задача

void printArray(string[] arrayToPrint)

{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        System.Console.Write(arrayToPrint[i] + ",");
    }
    Console.Write("]");
    System.Console.WriteLine();
}




string[] Sorted(string[] originalArray)
{
    int count = 0;

    for (int i = 0; i < originalArray.Length; i++)
    {
        if (originalArray[i].Length <= 3)
        {
            count++;
        }
    }

    string[] newArray = new string[count];

    int index = 0;

    for (int i = 0; i < originalArray.Length; i++)
    {
        if (originalArray[i].Length <= 3)
        {
            newArray[index] = originalArray[i];
            index++;
        }

    }
    return newArray;
}
string[] originalArray = { "asvc", "123", "f4", "123rs" };

printArray(originalArray);

Console.WriteLine("");

string[] newArray = Sorted(originalArray);

printArray(newArray);
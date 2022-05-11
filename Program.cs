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

string[] originalArray = { "asvc", "1,3", "f4", "123rs" };


int Sorted(string[] originalArray)
{
    int count = 0;
    for (int i = 0; i < originalArray.Length; i++)
    {
        if (i <= 3)
        {
            count++;
        }
    }
return count;
}

string[] newArray = new string[count];




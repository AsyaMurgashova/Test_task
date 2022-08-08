void PrintStringArray(string[] Array)
{
    int i = 0;
    Console.Write("[ ");
    for (i = 0; i < Array.Length - 1; i++)
    {
        if (Array[i] == string.Empty)
        {
            continue;
        }
        else Console.Write($"{Array[i]}, ");
    }
    Console.Write($"{Array[i]} ]");
    Console.WriteLine();
}


string[] GenerateStringArray(int size)
{
    string[] StringArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите строковый элемент массива {i + 1}: ");
        StringArray[i] = Convert.ToString(Console.ReadLine());
    }
    return StringArray;
}

Console.Write("Задайте длину массива: ");
int PrimaryArrayLength = Convert.ToInt32(Console.ReadLine());
string[] PrimaryArray = GenerateStringArray(PrimaryArrayLength);
Console.Write("Первоначальный массив: ");
PrintStringArray(PrimaryArray);

int count = PrimaryArray.Length;
string[] FinalArray = new string[count];
int j = 0;
Console.Write("Получившийся массив: [ ");
for (int i = 0; i < PrimaryArray.Length; i++)
{
    int StringLength = PrimaryArray[i].Length;
    if (StringLength <= 3)
    {
        FinalArray[j] = PrimaryArray[i];
        Console.Write($"{FinalArray[j]}, ");
        j++;
    }
    count = j - 1;
}
Console.WriteLine("]");

// К сожалению не получилось избавиться от запятой после последнего элемента массива :*(

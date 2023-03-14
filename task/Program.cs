

// string[] array = { "hello", "2", "world", ":-)" }; // - быстрая проверка
string userMessage = "Введите длину массива: ";
int arraySize = UserInput(userMessage);
string[] arrayNew = NewArray(arraySize);
Console.WriteLine();
PrintArray(arrayNew);
Console.WriteLine();
int length = CollectLength(arrayNew);
string[] newArray = ChangedArray(length, arrayNew);
PrintArray(newArray);

// Ввод длины массива пользователем
int UserInput(string message)
{
    Console.WriteLine(message);
    int arrayLength = int.Parse(Console.ReadLine());
    return arrayLength;
}

//Заполнение массива
string[] NewArray(int arrLength)
{
    string[] array = new string[arrLength];
    Console.WriteLine("Введите строки");
    for (int i = 0; i < arrLength; i++)
    {
        array[i] = Console.ReadLine();
    }

    return array;
}

//Печать массива
void PrintArray(string[] inputArray)
{
    Console.Write("[");
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (i < inputArray.Length - 1)
        {
            Console.Write($"{inputArray[i]}, ");
        }
        else if (i == inputArray.Length - 1)
        {
            Console.Write($"{inputArray[i]}]");
        }
    }
}

//Определение длины массива, цикл while
int CollectLength(string[] inputArray)
{
    int count = 0;
    int scorer = 0;
    while (count < inputArray.Length)
    {
        if (inputArray[count].Length <= 3)
        {
            scorer++;
        }
        count++;
    }
    return scorer;
}

//Запись в новый массив, цикл for
string[] ChangedArray(int arraySize, string[] gateArray)
{
    string[] outputArray = new string[arraySize];
    int collect = 0;
    for (int i = 0; i < gateArray.Length; i++)
    {
        if (gateArray[i].Length <= 3)
        {
            outputArray[collect] = gateArray[i];
            collect++;
        }
    }

    return outputArray;
}
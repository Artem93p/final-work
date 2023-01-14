// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] firstArray = new string[5] {"1234", ":)", "computer", "world", "-2"};

string[] NewArray( string [] firstArray)
{
    int count = 0;
    string[] newArray = new string[firstArray.Length];
    for (int i = 0; i < newArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            newArray[count] = firstArray[i];
            count++;   
        }
    }
    return newArray;
}

void ShowArray (string[] array )
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");
    }
}

string [] secondArray = NewArray(firstArray);

ShowArray(firstArray);
System.Console.WriteLine();
ShowArray(secondArray); 
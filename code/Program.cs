using System;
using static System.Console;
using System.Linq;
Clear();

string[] array = GetRandomArray();
string[] result = new string[array.Length];

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        result[count] = array[i];
        count++;
    }
}
PrintArray(array);
Write(" => ");
PrintArray(result);


string[] GetRandomArray()
{
    string[] result;
    int random = new Random().Next(1, 4);
    if (random == 1)
    {
        result = new string[4] { "hello", "2", "world", ":-)" };
    }
    else 
    if (random == 2)
    {
        result = new string[4] { "1234", "1567", "-2", "computer science" };
    }
    else
    {
        result = new string[3] { "Russia", "Denmark", "Kazan" };
    }
    return result;
}

void PrintArray(string[] array)
{
    Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == array.GetLength(0) - 1)
        {
            Write($"{array[i]}");
        }
        else
        {
            Write($"{array[i]}, ");
        }
    }
    Write("]");
}

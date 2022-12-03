/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] GetFinalArray(string[] input, int n)
{
    string[] output = new string[CountSymbolsOfElement(input, n)];
    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}

int CountSymbolsOfElement(string[] input, int k)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= k)
        {
            count++;
        }
    }
    return count;
}

string[] InputArray()
{
    Console.Write("Введите значения для массива через пробел: ");
    return Console.ReadLine().Split(" ");
}

void Execute()
{
    string[] inputArray = InputArray();
    string[] resultArray = GetFinalArray(inputArray, 3);
    Console.WriteLine($" Исходный массив: [{string.Join("; ", inputArray)}]  Итоговый массив: [{string.Join("; ", resultArray)}]");
}
Execute();
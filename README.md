# Программа на C# для фильтрации массива строк по длине

Эта программа создана на языке C# и решает задачу фильтрации элементов массива строк по длине. Программа использует стандартные массивы и LINQ(интегрированный язык запросов) для обработки данных.

## Исходный код

Программа содержит класс `Program` с функцией `Main`, где происходит инициализация начального массива, вызов функции `FilterByLength`, и вывод отфильтрованного массива на экран.

Функция `FilterByLength` принимает на вход массив строк `array` и максимальное значение длины строки `maxLength`. Она возвращает новый массив строк, содержащий только те элементы, длина которых меньше или равна `maxLength`.

```csharp
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] initialArray = { "кот", "собака", "яблоко", "код", "A", "дерево" };
        string[] filteredArray = FilterByLength(initialArray, 3);

        Console.WriteLine("Отфильтрованный массив:");
        foreach (string item in filteredArray)
        {
            Console.WriteLine(item);
        }
    }

    static string[] FilterByLength(string[] array, int maxLength)
    {
        return array.Where(s => s.Length <= maxLength).ToArray();
    }
}
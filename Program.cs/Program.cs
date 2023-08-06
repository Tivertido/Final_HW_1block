// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Задать начальный массив строк
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] initialArray = { "Код", "Схема", "Файл", "С#", "CON", "Буткемп" };

        // Отфильтровать массив строк по длине
        string[] filteredArray = FilterByLength(initialArray, 3);

        // Вывести результат на экран
        Console.WriteLine("Отфильтрованный массив:");
        foreach (string item in filteredArray)
        {
            Console.WriteLine(item);
        }

    // Функция, фильтрующая массив строк по длине
    static string[] FilterByLength(string[] array, int maxLength)
    {
        return array.Where(s => s.Length <= maxLength).ToArray();
    }
    }
}
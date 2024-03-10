/*
Написать программу, которая создает новый массив строк из имеющегося массива, содержащего строки, длина которых меньше или равна 3 символам. 
Массив может быть введен с клавиатуры или задан на старте выполнения программы. При решении необходимо использовать только массивы, без применения коллекций.
*/

using System;

class Program
{
    static void Main()
    {
        // Ввод массива строк с клавиатуры
        Console.WriteLine("Введите элементы массива, разделенные пробелами:");
        string[] inputArray = Console.ReadLine().Split();

        // Формирование нового массива из строк, длина которых <= 3 символам
        string[] resultArray = FilterStrings(inputArray);

        // Вывод результатов
        Console.WriteLine("Новый массив строк:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterStrings(string[] inputArray)
    {
        // Подсчет количества строк, удовлетворяющих условию
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива
        string[] resultArray = new string[count];

        // Заполнение нового массива строками <= 3 символам
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        return resultArray;
    }
}

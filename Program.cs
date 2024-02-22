// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CreateArr()
{
    System.Console.Write("Введите длину массива: ");
    int arrLen = int.Parse(Console.ReadLine());

    string[] sArr = new string[arrLen];

    System.Console.WriteLine("Заполните массив значениями");
    for (int i = 0; i < arrLen; i++)
    {
        System.Console.Write($"{i + 1}: ");
        sArr[i] = Console.ReadLine();
    }
    return sArr;
}

int CountingShortValue(string[] arr, int lenght)
{
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length <= lenght)
            k++;
    return k;
}


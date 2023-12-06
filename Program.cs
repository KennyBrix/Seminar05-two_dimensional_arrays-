// Задача 1. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


// Console.WriteLine("введите номер строки");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[5, 5];
// FillArrayRandomNumbers(numbers);

// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
// }

// PrintArray(numbers);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "  ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }


//Задача 2. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.



// int[,] matrix = new int[5, 5]
//             { { 1, 2, 3, 4, 6 },
//               { 6, 8, 2, 3, 4},
//               { 4, 2, 7, 1, 7 },
//               { 5, 6, 7, 8, 1 },
//               { 6, 2, 8, 2, 9}
//             };       
// for (int i = 0; i < matrix.GetLength(1); i++)
// {
//     int tmp = matrix[4, i];
//     matrix[4, i] = matrix[0, i];
//     matrix[0, i] = tmp;
// }
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();


//Задача 3. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

int SumRowArray(int[,] array)
{
    int[] sumArr = new int[array.GetLength(0)];
    Console.WriteLine($"Сумма по строке:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArr[i] += array[i, j];
        }
        Console.WriteLine($"{i + 1} -> {sumArr[i]}");
    }
    int minSum = sumArr[0];
    int minRow = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (sumArr[i] < minSum)
        {
            minSum = sumArr[i];
            minRow = i + 1;
        }
    }
    return minRow;
}

int[,] array = CreateArray(Prompt("Введите количество строк: "), Prompt("Введите количество столбцов: "));

array = FillArrayRandom(array);

PrintArray(array);

int row = SumRowArray(array);

Console.WriteLine($"Наименьшая сумма в {row} строке.");

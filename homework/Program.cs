// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] CreateArray()
// {
//     int m = new Random().Next(2, 10);
//     int n = new Random().Next(2, 10);
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }

//     }
//     return array;
// }
// int[,] PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }



// int[,] array = CreateArray();
// PrintArray(array);
// Console.WriteLine();

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1) - 1; j++)
//     {
//         for (int z = 0; z < array.GetLength(1) - 1; z++)
//         {
//             if (array[i, z] < array[i, z + 1])
//             {
//                 int tmp;
//                 tmp = array[i, z];
//                 array[i, z] = array[i, z + 1];
//                 array[i, z + 1] = tmp;
//             }
//         }
//     }
// }
// PrintArray(array);

// ============================================================================================

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int Prompt(string text)
// {
//     Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }

// }
// int m = Prompt("Введите колличество строк:");
// int n = Prompt("Введите колличество столбцов:");
// int[,] array = new int[m, n];


// FillArrayRandomNumbers(array);
// PrintArray(array);
// Console.WriteLine();
// int[] newArray = new int[m];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//         sum += array[i, j];
//     Console.WriteLine(sum);
//     Console.WriteLine();
//     newArray[i] = sum;
// }

// int min = newArray[0];


// for (int i = 1; i < newArray.Length; i++)
// {

//     if (min > newArray[i])
//     {
//         min = newArray[i];

//     }

// }
// int indexMin = Array.IndexOf(newArray, min) + 1;


// Console.WriteLine(String.Join(",", newArray));
// Console.WriteLine();


// Console.WriteLine(min);
// Console.WriteLine();

// Console.WriteLine($"Минимильная сумма элементов в " + indexMin + " строке");


// =========================================================================================


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


//  int Prompt(string text)
// {
//     Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }

// }
// int m = Prompt("Введите колличество строк матрицы 1:");
// int n = Prompt("Введите колличество столбцов матрицы 1:");
// int[,] arrayMatrix1 = new int[m, n];
// int b = Prompt("Введите колличество строк матрицы 2:");
// int k = Prompt("Введите колличество столбцов матрицы 2:");
// int[,] arrayMatrix2 = new int[b, k];

// FillArrayRandomNumbers(arrayMatrix1);
// FillArrayRandomNumbers(arrayMatrix2);
// PrintArray(arrayMatrix1);

// Console.WriteLine();

// PrintArray(arrayMatrix2);

// int[,] ArrayMultiplication(int[,] arrayMatrix1, int[,] arrayMatrix2)
//     {       
//         if (arrayMatrix1.GetLength(1) != arrayMatrix2.GetLength(0))
//         {
//             throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
//         }

//         int [,]arrayMatrix3 = new int[arrayMatrix1.GetLength(0), arrayMatrix2.GetLength(1)];

//         for (int i = 0; i < arrayMatrix1.GetLength(0); i++)
//         {
//             for (int j = 0; j < arrayMatrix2.GetLength(1); j++)
//             {
//                 arrayMatrix3[i, j] = 0;

//                 for (int k = 0; k < arrayMatrix1.GetLength(1); k++)
//                 {
//                     arrayMatrix3[i, j] += arrayMatrix1[i, k] * arrayMatrix2[k, j];
//                 }
//             }
//         }

//         return arrayMatrix3;
//     }

// Console.WriteLine();
// int [,] arrayMatrix3 = ArrayMultiplication(arrayMatrix1, arrayMatrix2);
// PrintArray(arrayMatrix3);

// =============================================================================================


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();
Console.WriteLine($"Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void WriteArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.Write($"X({i}) Y({j}) ");
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"Z({k})={array3D[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void CreateArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

// ========================================================================

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Console.Clear();
// Console.WriteLine($"Задача 62: Заполните спирально массив 4 на 4.");

// int n = 4;
// int[,] sqareMatrix = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
//     sqareMatrix[i, j] = temp;
//     temp++;
//     if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
//         j++;
//     else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
//         i++;
//     else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
//         j--;
//     else
//         i--;
// }

// WriteArray(sqareMatrix);

// void WriteArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] / 10 <= 0)
//                 Console.Write($" {array[i, j]} ");

//             else Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
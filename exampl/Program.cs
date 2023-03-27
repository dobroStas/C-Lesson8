// Задача 53: 
// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }

}

void Exchange(int[,] array)
{
    int tmp;
    int LastIndex = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        tmp = array[LastIndex, i];
        array[LastIndex, i] = array[0, i];
        array[0, i] = tmp;
    }
}


// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine("");
//     }
// }


// int m = Prompt("Введите колличество строк:");
// int n = Prompt("Введите колличество столбцов:");
// int[,] array = new int[m, n];

// FillArrayRandomNumbers(array);
// PrintArray(array);
// Console.WriteLine("==================");
// Exchange(array);
// PrintArray(array);






// Задача 55: 
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// int m = Prompt("Введите колличество строк:");
// int n = Prompt("Введите колличество столбцов:");
// int[,] array = new int[m, n];
// int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];


// void ExchangeStringColumn(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             newArray[i, j] = array[j, i];
//         }
// }

// if (n == m)
// {
//     FillArrayRandomNumbers(array);
//     PrintArray(array);
//     Console.WriteLine("==================");
//     ExchangeStringColumn(array);
//     PrintArray(newArray);
// }
// else Console.WriteLine("Fals");



// Задача 57.
// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.


int[,] CreateArray()
{
    int m = new Random().Next(2, 10);
    int n = new Random().Next(2, 10);
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }

    }
    return matrix;
}

int[,] PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return matrix;
}


int[] Array(int[,] matrix)
{
    int k = 0;
    int[] newArray = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newArray[k] = matrix[i, j];
            k++;
        }
    }
    return newArray;
}


int[] SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
                minPosition = j;
        }
    int tmp = array[i];
    array[i] = array[minPosition];
    array[minPosition] = tmp;
    }
    return array;
}


// int[,] matrix = CreateArray();
// PrintArray(matrix);
// Console.WriteLine();
// int[] newArray = Array(matrix);
// Console.WriteLine(String.Join(",", newArray));
// SortArray(newArray);
// Console.WriteLine(String.Join(",", newArray));

// int el = newArray[0];
// int count = 1;
// for (int i = 1; i < newArray.Length; i++)
// {
//     if (el == newArray[i])
//         count++;
//     else
//     {
//         Console.WriteLine($"Число {el} встречается в массиве {count} раз");
//         count = 1;
//         el = newArray[i];
//     }
// }
// Console.WriteLine($"Число {el} встречается в массиве {count} раз");





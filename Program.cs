// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
 double[,] CreateRandom2dArray()
 {
     Console.Write("Введите число строк: ");
     int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное число: ");
    int min = Convert.ToInt32(Console.ReadLine());
     Console.Write("Введите максимальное число: ");
     int max = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows, columns];
    
     for (int i = 0; i < rows; i++)
         for (int j = 0; j < columns; j++)
            array[i,j] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 1);
    
     return array;
 }

void WriteArray(double[,]array)
 {
     for(int i=0; i<array.GetLength(0); i++)
     {
        for(int j=0; j<array.GetLength(1); j++)
             Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

 double[,] myArray = CreateRandom2dArray();
 WriteArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// double[,] CreateRandom2dArray()
// {
//     Console.Write("Введите число строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите число столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное число: ");
//     int min = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное число: ");
//     int max = Convert.ToInt32(Console.ReadLine());
//     double[,] array = new double[rows, columns];
    
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i,j] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 1);
    
//     return array;
// }

// void FindElement(double[,] array)
// {
//     Console.Write("Введите нужную строку: ");
//     int rows = Convert.ToInt32(Console.ReadLine()) - 1;
//     Console.Write("Введите нужный столбец: ");
//     int columns = Convert.ToInt32(Console.ReadLine()) - 1;
//     if(rows > array.GetLength(0) || columns > array.GetLength(1))
//         Console.WriteLine("Нет такого элемента.");
//     else Console.WriteLine($"Нужный элемент - {array[rows, columns]}");
// }

// void WriteArray(double[,]array)
// {
//     for(int i=0; i<array.GetLength(0); i++)
//     {
//         for(int j=0; j<array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// double[,] myArray = CreateRandom2dArray();
// WriteArray(myArray);
// FindElement(myArray);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Введите число строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите число столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное число: ");
//     int min = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное число: ");
//     int max = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, columns];
    
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(min, max + 1);
    
//     return array;
// }

// double[] MeanOfColumns(int[,] array)
// {
//     double[] newArray = new double[array.GetLength(1)];
//     for(int i = 0; i < array.GetLength(1); i++)
//     {
//         double sumOfColumn = 0;
//         double meanOfColumn = 0;
//         for(int j = 0; j < array.GetLength(0); j++)
//         {
//             sumOfColumn += array[j, i];
//         }
//         meanOfColumn = sumOfColumn / array.GetLength(1);
//         newArray[i] = meanOfColumn;
//     }
//     return newArray;
// }

// void Write2dArray(int[,]array)
// {
//     for(int i=0; i<array.GetLength(0); i++)
//     {
//         for(int j=0; j<array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void WriteDouble1dArray(double[]array)
// {
//     for(int i=0; i < array.Length; i++)
//             Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int[,] myArray = CreateRandom2dArray();

// Write2dArray(myArray);

// double[] meanOfColumnsArray = MeanOfColumns(myArray);

// WriteDouble1dArray(meanOfColumnsArray);
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


					
using System;
     
 public partial class Program56
{
 public static void Main()

 {
    int[,] Massiv = new int[3, 4];
    ArrayRandom(Massiv);
    PrintArray(Massiv);
    System.Console.WriteLine("++++++++");
    int minSumIndexRow = MinSumIndexRow(Massiv);
    Console.WriteLine("Min sum in row with index: " + minSumIndexRow);
   
    
 }
 public static void ArrayRandom(int[,] arr)
    {
        Random rnd = new Random();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = rnd.Next(1, 10);
            }
        }

    }
   public static int MinSumIndexRow(int[,] arr)
    {
        if (arr.GetLength(0) == 0){
            return 0;
        }
        int minSum = 0;
        int minSumIndexRow = 0;

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            minSum += arr[minSumIndexRow, j];
        }


        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
            }
            if (sum < minSum)
            {
                minSumIndexRow = i;
            }
        }

        return minSumIndexRow + 1;
    }
    public static void PrintArray(int[,] array)
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
   
}
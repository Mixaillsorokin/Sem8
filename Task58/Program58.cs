// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
					
using System;
     
 public partial class Program58
{
 public static void Main()
 {
  int[,] result = Pow2Matrix();
  for(int i = 0; i < result.GetLength(0); i++) {
   string row = "";
   for(int j = 0; j < result.GetLength(1); j++) {
    row += result[i,j] + " ";
   }
   Console.WriteLine(row);
  }
 }
 
 public static int[,] Pow2Matrix()
 {

  int[,] matrix1 = new int[2,2]
  {
	  {2,4} , 
	  {3,2}
  };
  int[,] matrix2 = new int[2,2]
  {
    {3,4 } , 
	  {3,3}
  
  };
  int[,] result = new int[2,2]
  {
    { 0, 0 },
    { 0, 0 }
  };
  
  for(int i = 0; i < matrix1.GetLength(0); i++) {
   int sum = 0;
   for(int j = 0; j < matrix1.GetLength(1); j++) {
    for(int k = 0; k < matrix2.GetLength(1); k++) {
     sum += matrix1[i,k] * matrix2[k,j]; 
    }
    result[i,j] = sum;
    sum = 0;
   }
  }
  return result;
 }
}
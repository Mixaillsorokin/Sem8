
					
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
    // [0][0] = matrix1[0][0] * matrix2[0][0] + matrix1[0][1] * matrix2[1][0]
    // [0][1] = matrix1[0][0] * matrix2[1][0] + matrix1[0][1] * matrix2[1][1]
    result[i,j] = sum;
    sum = 0;
   }
  }
  return result;
 }
}
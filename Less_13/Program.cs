
string[,] table = new string[2, 5];
// String.Empty
// table[0,0] table[0,1] table[0,2] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,4]

// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//   for (int columns = 0; columns < 5; columns++)
//   {
//     Console.WriteLine($"-{table[rows, columns]}-");
//   }
// }

// int[,] matrix = new int[10, 5];

// for (int i = 0; i < 10; i++) // В место 10-пишем matrix.GetLength(0)
// {
//   for (int j = 0; j < 5; j++) // В место 5-пишем matrix.GetLength(1) 
//                               // будет тоже самое
//   {
//     Console.Write($"{matrix[i, j]} ");
//   }
// Console.WriteLine();  
// }

void PrintArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
      for (int j = 0; j < matr.GetLength(1); j++) 
      {
        Console.Write($"{matr[i, j]} ");
      }
    Console.WriteLine();  
  }
}

void FillArray(int[,] matr)
{
  for( int i = 0; i< matr.GetLength(0); i++)
  {
    for( int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = new Random().Next(1,10); // [1,10)
    }
  }
}

int[,] matrix = new int[2, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
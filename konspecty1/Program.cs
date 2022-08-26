// 
//string[,] table = new string[2, 5];
//                      строки,столбцы


//table[0,0] table[0,1] table[0,2] table[0,3] table[0,4] 
//table[1,0] table[1,1] table[1,2] table[1,3] table[1,4] 
//table[1,2] = "слово";

//for (int rows = 0; rows < 2; rows++)
//{
    //for (int columns = 0; columns < 5; columns++)
    //{
     //   Console.WriteLine($"-{table[rows, columns]}-");
    //}
//}


int[,] matrix = new int[3,3];
void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[j, i]} ");
    }
    Console.WriteLine();

}
}

void FillArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(1,10);
    }
    Console.WriteLine();

}
}
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
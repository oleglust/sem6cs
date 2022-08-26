// перевернет одномерный массив. первое число переходит в конец и наоборот
int[] array = GetArray(10, 0, 10);

int[] GetArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max +1);
    }
    return res;
}


void reversARRAY(int[] localArray)
{ 
   for (int i = 0; i < localArray.Length/2; i++) //делим на 2, для оптимизации
   {
     int k = localArray[i];
     localArray[i] = localArray[localArray.Length - i - 1];
     localArray[localArray.Length - i - 1] = k;
   }
}
Console.WriteLine(String.Join(" ", array));
Console.WriteLine();
reversARRAY(array);
Console.WriteLine(String.Join(" ", array));//чередование введеных даннных

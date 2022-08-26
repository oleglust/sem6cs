//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write($"Укажи, сколько чисел ты хочешь ввести  : ");
int M = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[M];

void InputNumbers(int M){
for (int i = 0; i < M; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] arrayNumbers)
{
  int count = 0;
  for (int i = 0; i < arrayNumbers.Length; i++)
  {
    if(arrayNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(M);

Console.WriteLine($"Введено чисел больше 0: {Comparison(arrayNumbers)} ");
// принимает 3 числа и принимает, может ли существовать треугольник со сторорнами такой длины
void check_Triangle(int a, int b, int c)
{
    if ((a + b) > c && (b+c)>a && (c+a)>b )
    {
        Console.WriteLine("DA");
    }
    else
    {
        Console.WriteLine("NO");
    }
}

Console.WriteLine("ВВЕДИТЕ 3 числа через пробел");
string[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);//
int a = int.Parse(array[0]);
int b = int.Parse(array[1]);
int c = int.Parse(array[2]);

check_Triangle(a,b,c);
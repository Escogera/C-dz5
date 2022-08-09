// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

Console.WriteLine("введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];
int sub = 0;
for (int i = 0; i < massive.Length; i++)
{
    massive[i] = new Random().Next(-99,100);
  
}
int max = massive[0];
int min = massive[0];
for (int i = 0; i < massive.Length; i++)
{
    if (massive[i]>max) max = massive[i];
    else if (massive[i]<min) min = massive[i];
}
  
sub=Math.Abs(max)-Math.Abs(min);   

PrintArray(massive);
Console.WriteLine();
Console.WriteLine($"максимальное число = {max}, мнимальное число = {min}");
Console.WriteLine("Разница между максимальным и минимальным элементов массива равна: " + sub);
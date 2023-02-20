// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Создаем двумерный массив случайных чисел
Console.Write("Введите высоту массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] doubleArray = new int [m, n];
int [,] sumArray = new int [m, n-(n-1)];
int sum = 0;
int i = 0;



Random rnd = new Random();

for (i = 0; i < doubleArray.GetLength(0); i++)
{
    for (int j = 0; j < doubleArray.GetLength(1); j++)
    {
        doubleArray[i, j] = rnd.Next(0, 10);
        sum = sum + doubleArray[i, j];
        sumArray[i, 0] = sum;
        Console.Write($"{doubleArray[i, j]} ");
    }
    sum = 0;
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine($"Сумма строк заданного массива: ");

int minrow = sumArray[0, 0];
int l = 0;
int k = 0;
for (i = 0; i < sumArray.GetLength(0); i++)
{
    for (int j = 0; j < sumArray.GetLength(1); j++)
    {
        Console.Write($"{sumArray[i, j]} ");
        if (sumArray[i, j] < minrow)
        {
            minrow = sumArray[i, j];
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"Номера строк с наименьшей суммой элементов: ");
for (i = 0; i < sumArray.GetLength(0); i++)
{
    for (int j = 0; j < sumArray.GetLength(1); j++)
    {
         if (sumArray[i, j] == minrow)
        {
            l = i + 1;
            Console.Write(l);
            Console.WriteLine();
        }  
    }
}    
Console.WriteLine();


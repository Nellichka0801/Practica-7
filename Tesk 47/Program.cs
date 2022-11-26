// Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] CreateArray(int rows, int columns)
{
    var random = new Random();
    double[,] array = new double[rows, columns];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.NextDouble() + random.Next (-100, 100);
                        
        }
    }
    return array;
}

void PrintArray(double[,] input) {
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(input[i, j], 2)}");
            if (j != input.GetLength(1) - 1)
            Console.Write(", ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество колонок ");
int columns = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Массив");
double[,] array = CreateArray(rows, columns);
PrintArray(array);
System.Console.WriteLine();


//  Задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] CreateArray(int rows, int columns)
{
    var random = new Random();
    int[,] array = new int[rows, columns];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 50);
        }
    }

return array;
}

void PrintArray(int[,] input) {
for (var i = 0; i < input.GetLength(0); i++)
{
for (var j = 0; j < input.GetLength(1); j++)
{
    Console.Write(input[i, j]);

    if (j != input.GetLength(1) - 1)
    Console.Write(", ");
}
Console.WriteLine();
}
}

void ArithmeticMeanOfColumns (int[,] array)
{
    double result = 0;
    double sum = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        { 
          sum = sum + array[i,j];
        }
        result = sum/array.GetLength(0);
        System.Console.Write(result);
        if (j != array.GetLength(1) - 1) Console.Write(", ");
        sum = 0;
    }
}



    
var array = CreateArray(4, 3);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Среднее арефмитическое столбцов:");
ArithmeticMeanOfColumns (array);

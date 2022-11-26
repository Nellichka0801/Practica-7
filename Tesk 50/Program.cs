// Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
Console.WriteLine("Введите количество строк ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество колонок ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число для проверки ");
int numbers = int.Parse(Console.ReadLine()!);

int[,] CreateArray(int rows, int columns)
{
    var random = new Random();
    int[,] array = new int[rows, columns];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 5);
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

void ItemPosition(int[,] array, int numbers)
{
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          
          if(numbers == array[i, j]) 
          {
            row = i; column = j;
          }
        }     
    }
    if (numbers == array[row, column])
    {
        System.Console.WriteLine("Позиция элемента " + (row,column));
    }
    else
    {
        Console.WriteLine($"Числа {numbers} в данном массиве нет.");
        Console.WriteLine();
    }
    
 }

int[,] array = CreateArray(rows, columns);
PrintArray(array);
ItemPosition(array, numbers);



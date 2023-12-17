// Задача 4*(не обязательная):
//Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец,
//на пересечении которых расположен наименьший элемент массива.
//Под удалением понимается создание нового двумерного массива
// без строки и столбца

int[,] FillArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}
int[] FindMinIndex(int[,] arr)
{
    int[] result = new int[2];
    int min = arr[0,0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] < min)
            {
                min = arr[i,j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}
int[,] DelRowColumn(int[,] arr, int row, int column)
{
    int[,] result = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (i>= row)
            {
                if (j>=column)
                {
                    result[i,j] = arr[i+1, j+1];
                }
                else result[i,j] = arr[i+1, j];
            }
            else if (j>=column) result[i,j] = arr[i, j+1];
            else result[i, j] = arr[i, j];
        }
    }
    return result;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == arr.GetLength(1)-1)
            {
                Console.WriteLine($"{arr[i,j]}]");
            }
            else Console.Write($"{arr[i,j]}, ");
        }
    }
}
int[,] array = FillArray(5, 5, 10, 100);
PrintArray(array);
int[] minIn = FindMinIndex(array);
Console.WriteLine();
int[,] resArray = DelRowColumn(array, minIn[0], minIn[1]);
PrintArray(resArray);
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
            result[i,j] = new Random().Next(minValue, maxValue+1);
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
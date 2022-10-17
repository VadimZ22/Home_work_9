/*Доп задача
Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). 
В массиве data хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, 
которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
входные данные: data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }  info = {2, 3, 3, 1 } выходные данные: 1, 7, 0, 1*/


using System.ComponentModel;

Console.Clear();
int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = {2, 3, 3, 1 };
PrintNumbers(BinToDec(data, info));


double[] BinToDec(int[] data, int[] info)
{
    int[][] dataInfo = Split(data, info);
    ReverseArray(dataInfo);
    double[] decNumbers = new double[dataInfo.Length];
    
    for (int i = 0; i < dataInfo.Length; i++)
    {
        double result = 0;
        for (int j = 0; j < dataInfo[i].Length; j++)
        {
            result = result + Math.Pow(2, j) * dataInfo[i][j];
        }
        decNumbers[i] = result;
    }
    return decNumbers;
}

int[][] Split(int[] data, int[] info)
{
    int[][] dataInfo = new int[info.Length][];

    for (int i = 0; i < dataInfo.Length; i++)
    {
        dataInfo[i] = new int[info[i]];
    }
    
    int count = 0;
    for (int i = 0; i < dataInfo.Length; i++)
    {
        int count2 = 0;
        for (int j = 0; j < dataInfo[i].Length; j++)
        {
            dataInfo[i][j] = data[j + count];
            count2++;
        }
        count += count2;
    }
    return dataInfo;
}

void ReverseArray(int[][] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Array.Reverse(arr[i]);
    }
}

void PrintNumbers(double[] arr)
{
    foreach(int item in arr)
    {
        Console.Write($"{item}, ");
    
    }
}











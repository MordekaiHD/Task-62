// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void Print2DMassive(int[,] massive)                              
{
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for(int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i,j]}\t");
        }
        Console.WriteLine();
    }
}
int[,] Create2DMassiv(int[,] massive)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= massive.GetLength(0) * massive.GetLength(1))
    {
        massive[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < massive.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= massive.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > massive.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return massive;
}

int[,] massive = new int[4, 4];
Create2DMassiv(massive);
Print2DMassive(massive);
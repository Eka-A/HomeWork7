//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Random random = new Random();
int rows = random.Next(3,4);
int columns = random.Next(4,4);
int[,] array = new int[rows,columns];

FillArray(array);
PrintArray(array);
Console.WriteLine();
AvgArray(array);


static void FillArray(int[,] array, int startNumber = 0, int finishNumber = 10)
{
    finishNumber++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i<rows; i++)
    {
        for(int j = 0; j<columns; j++)
        {
            array[i,j]= random.Next(startNumber,finishNumber);

        }
    }
}


static void PrintArray(int [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i<rows; i++)
    {
        for(int j = 0; j<columns; j++)
        {
            Console.Write(array[i,j] + "\t");
        }

        Console.WriteLine();
    }
}

void AvgArray(int[,] array)
{
    int columns = array.GetLength(1);
    int rows = array.GetLength(0);
    double[] avg = new double[columns];
    
        for (int j = 0; j < columns; j++)
        {
            for (int i = 0; i < rows; i++)
                {
                avg[j] += array[i, j];
                }

            Console.WriteLine($"Среднее арифметическое {avg[j]} = {avg[j] = Math.Round((avg[j] /rows), 1)}");
            Console.WriteLine();
        }

}

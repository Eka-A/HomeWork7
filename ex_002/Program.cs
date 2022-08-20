//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Random random = new Random();
int rows = random.Next(3,4);
int columns = random.Next(4,4);
int[,] array = new int[rows,columns];
FillArray(array,4,9);
PrintArray(array);
CheckArray(array);

    void CheckArray(int[,] array)
    {    
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
                
        Console.Write($"Введите номер строки:");
        int a = Convert.ToInt32(Console.ReadLine())-1;
        Console.Write($"Введите номер столбца:");
        int b = Convert.ToInt32(Console.ReadLine())-1;

        if ((a>= 0 && a < rows) && (b>= 0 && b < columns))
        {
            Console.WriteLine($"Элемент =  {array[a, b]}");
        }
        else
        {
            Console.WriteLine($"Элемента не существует");
        }
    }



void FillArray(int[,] array, int startNumber = 0, int finishNumber = 10)
{
    finishNumber++;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i=0; i<rows; i++)
    {
        for (int j=0; j<columns; j++)
        {
            array[i,j]= random.Next(startNumber,finishNumber);

        }
    }
}

void PrintArray(int[,] array)
{

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i=0; i<rows; i++)
    {
        for (int j=0; j<columns; j++)
        {
            Console.Write(array[i,j]+" ");

        }
        
        Console.WriteLine();
    }
}






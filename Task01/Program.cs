Console.Clear();

int DataEntry(string message)
{
    System.Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

double[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange) + new Random().NextDouble();
            array[i, j] = Math.Round(array[i, j], 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int rows = DataEntry("Enter the value of rows: ");
int columns = DataEntry("Enter the value of columns: ");
double[,] matrix = CreateRandomArray(rows, columns, -9, 10);
PrintArray(matrix);
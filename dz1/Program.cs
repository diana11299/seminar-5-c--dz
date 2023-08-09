//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    int count = 0;
    for (int i = 0; i < size; i ++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
            if(array[i] > 99 && array[i] < 1000)
            {
                count++;
            }
    }
    if(count > 0) return array;
    else
    {
        int[]anotherAr = new int[0];
        return anotherAr;
    }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int EventNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count ++;
    }
    return count;
}

Console.Write("Enter a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, minValue, maxValue);
WriteArray(myArray);

Console.WriteLine("Even numbers in array " + EventNum(myArray));
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    int count = 0;
    for (int i = 0; i < size; i ++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
            if(array[i] > -100 && array[i] < 100)
            {
                count++;
            }
    }
    if(count > 0) return array;
    else
    {
        int[]anotherAr = new int[0];
        return anotherAr;
    }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int EventNum(int[] array)

{
    int sum = 0;
    int i = 0;
    while (i < array.Length)
    {
        sum = sum + array[i];
        i = i + 2;
    }
return sum;
}

Console.Write("Enter a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, minValue, maxValue);
WriteArray(myArray);
Console.WriteLine (EventNum(myArray));
*/

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size, double minv, double maxv)
{
    double[] array = new double [size];
    for (int i = 0; i < size; i ++)
    {
        array[i] = Math.Round((new Random().NextDouble()*(maxv - minv )+ minv), 2);  
    }
    return array;
}

void WriteArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double MinMaxNum (double[] array)
{
    double res = 0;
    double minv = array[0];
    double maxv = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(maxv < array[i]) maxv = array[i];
        if(minv > array[i]) minv = array[i];
    }
    res = maxv-minv; 
    return res;       
}

Console.Write("Enter a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the min possible value: ");
double mi = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the max possible value: ");
double ma = Convert.ToDouble(Console.ReadLine());

double[] myArray = CreateRandomArray(length, mi,ma);
WriteArray(myArray);
Console.WriteLine (MinMaxNum(myArray));

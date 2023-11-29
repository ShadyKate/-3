Console.Clear();
double [] FillArray(int size) 
{
    Random random = new Random();
    double [] array = new double [size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble() * 1000; // так как нет указания из какого промежутка должны быть числа, оставляю до 1000
    }
    return array;
}
void PrintArray(double [] madeUpArray)
{
    for (int i = 0; i < madeUpArray.Length; i++)
    {
        Console.WriteLine(madeUpArray[i] + " ");
    }
    Console.WriteLine();
}
void FindDiffMaxAndMin (double [] arrayWeHave)
{
    
    int i = 0;
    double max = arrayWeHave[i];
    double min = arrayWeHave [i];
    for(i = 0; i < arrayWeHave.Length; i++)
        {
            if (max > arrayWeHave[i])
            {
               min = arrayWeHave[i];

            }
            else 
                if(arrayWeHave[i] > min)
                    {
                        max = arrayWeHave[i];
                    }

        
        
        }
double diff = max - min;
Console.WriteLine($"Разница между максимальным и минимальным значением массива равна {diff}");
}

int arraySize = 10;
double [] arr = FillArray(arraySize);
PrintArray(arr);

FindDiffMaxAndMin(arr);

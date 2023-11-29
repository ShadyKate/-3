Console.Clear();
int [] FillArray(int size)
{
    int[] array = new int [size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int [] madeUpArray)
{
    for(int i =  0; i < madeUpArray.Length; i++)
    {
        Console.Write(madeUpArray[i] + " ");
    }
    Console.WriteLine();

}

void findCountOfNumbers(int [] arrayWeHave)
{
    int count = 0;
    for(int i = 0; i < arrayWeHave.Length; i++)
    {
        if(arrayWeHave[i] > 20 || arrayWeHave [i] < 90)
        {
            count++;
        }

    }
    Console.WriteLine(count);
}


int arraySize = 10;
int [] arr = FillArray(arraySize);
PrintArray(arr);
findCountOfNumbers(arr);
Console.Clear();
int [] FillArray(int size = 10)
{
    int [] array = new int [10];
    for (int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(-100, 100); // в условии задачи не задан промежуток, от себя добавила именно такой
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
void FindCountOfEvenNumbers (int [] arrayWeHave)
{
    int count = 0;
    for (int i = 0; i < arrayWeHave.Length; i++)
    {
        if (arrayWeHave [i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Колличество чётных чисел в заданном массиве равно {count}");
}

int [] arr = FillArray(10);
PrintArray(arr);
FindCountOfEvenNumbers(arr);
//попыталась решить через перевод числа в строку и строку перевела в массив. но не уверена вообще... по сути то числа выводятся на консоль
Console.Clear();
Console.WriteLine("Введите число от 1 до 100000: ");
int Number = int.Parse(Console.ReadLine()!);
while(Number < 1 || Number > 100000)
{
    Console.WriteLine("Вы ошиблись!\nВведите число от 1 до 100000");
    Number = int.Parse(Console.ReadLine()!);
}
string NumberWeHave = Number.ToString();
char [] charArray = NumberWeHave.ToCharArray();
foreach (char ch in charArray)
{
    Console.Write($"{ch} ");
}
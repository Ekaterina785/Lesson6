Console.WriteLine("Введите элементы");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int y = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        y++;
    }
}
Console.WriteLine(y);
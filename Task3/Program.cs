// *Напишите программу, которая задаёт массив из N элементов и выводит их на экран.*v
// N = 5, получаем массив [1, 2, 5, 7, 19]
// N = 3, получаем массив [6, 1, 33]
Console.WriteLine("Введите число от 1 : ");
int num = Convert.ToInt32(Console.ReadLine());
while(num < 1)
{
    Console.WriteLine("Ошибка, введите число от 1: ");
    num = Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    int i=0;
    int count = array.Length;
    while (i < array.Length)
    {
        array[i] = new Random().Next(1, num);
        i++;
    }
}

void PrintArray(int[] array)
{
    int i = 0;
    int count = array.Length;
    while (i < array.Length)
    {
        Console.Write(array[i]);
        i++;
    }
}
int[] array = new int [num];
FillArray(array);
PrintArray(array);

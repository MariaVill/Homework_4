// Задача 25: Напишите метод, который принимает на вход два числа (A и B)
//  и возводит число A в целую степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Method(int number, int Y)
{
    int i;
    int result = 1;
    for (i = 1; i <= Y; i++)
    {
        result = result * number;
    }
    return result;
}
int res = Method(2, 4);
Console.WriteLine(res);



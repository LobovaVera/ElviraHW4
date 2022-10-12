// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//В от 1 до +оо инт

/*3, 5 -> 243 (3⁵)
2, 4 -> 16*/


//programm
int a, b;
ReceiveTwoNumbers( out a, out b);
//Console.WriteLine( $" A = {a} B = {b}");
RaizeAToTheBPowerB(a, b);

// methods
void ReceiveTwoNumbers( out int A, out int B)
{
    Console.WriteLine("Введите число А");
    A = int.Parse(Console.ReadLine()!);

     Console.WriteLine("Введите число B");
    B = int.Parse(Console.ReadLine()!);

}

void RaizeAToTheBPowerB (int A, int B)
{
    int poweredResult = A;
    for (int i = 1; i < B; i ++)
    {
        poweredResult *= A;
    }
  Console.WriteLine(poweredResult);
}
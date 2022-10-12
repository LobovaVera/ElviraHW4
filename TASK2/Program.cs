//усложненная версия первой задачи



Console.Clear();

uint a, b;
ReceiveTwoNumbers(out a, out b);
//Console.WriteLine( $" A = {a}, B = {b}");
RaizeAToTheBPowerB(a, b);



//методы
//1. проверка на натуральность (строка, символы и  отрицат)
void testIncomDataForError( string str, out uint checkedNumber)
{
bool testIncomeForError = uint.TryParse(str, out checkedNumber);
if (testIncomeForError/*|| uint.Parse(str) == 0*/)
{
    //Console.WriteLine("Это натуральное число");
   checkedNumber = uint.Parse(str);

if (int.Parse(str) == 0)
{
    Console.WriteLine("Неправильный ввод данных - попробуйте ввести натуральное число еще раз. Натуральное число не дробное и больше нуля!");
    Environment.Exit(0);
}
}
else
{
    Console.WriteLine("Неправильный ввод данных - попробуйте ввести натуральное число еще раз. Натуральное число не дробное и больше нуля!");
    Environment.Exit(0);
}
}

//2. получаем два числа от пользователя и сразу проверяем на ошибки ввода
void ReceiveTwoNumbers( out uint A, out uint B)
{
    Console.WriteLine("Введите число А");
    string one = Console.ReadLine()!;
    testIncomDataForError(one, out A);

     Console.WriteLine("Введите число B");
    string two = Console.ReadLine()!;
     testIncomDataForError(two, out B);

}


// 3. возведение А в степень В
void RaizeAToTheBPowerB (uint A, uint B)
{
    uint poweredResult = A;
    for (int i = 1; i < B; i ++)
    {
        poweredResult *= A;
    }
  Console.WriteLine($"{A} в степени {B} = {poweredResult}");
}

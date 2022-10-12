//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*452 -> 11
82 -> 10
9012 -> 12*/
Console.Clear();
Console.WriteLine("Введите число");
int ourNumber = int.Parse(Console.ReadLine()!);
int length = numberLength(ourNumber);
//Console.WriteLine($" число цифр в числе = {numberLength(ourNumber)}");
Console.WriteLine ($" the summ of all digits of the number {ourNumber} = {SummAllDigits(ourNumber, length)}");

int numberLength (int num)
{
    int count = 0;
    for(int i = 1; num > 0; i++)
    {
        num /= 10;
         count = i;
    }
   
    return count;

}

int SummAllDigits (int num, int numLength)
{
    int result = 0;
    int[] ourArray = new int[numLength];
    for (int i = 0; i <numLength; i++)
    {   
            ourArray[i]= num%10;
            num /= 10;
        
    }
    for ( int i =0; i <numLength; i++)
    {
        result += ourArray[i];
    }
   
return result;
}


// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number = number * -1;
}

    if (number < 100)
    {
        Console.WriteLine("No third digit!");
       
    }
    else
    {
        if (number > 99 && number < 1000)
        {
            int result = number % 10;
            Console.WriteLine("Third digit is " + result);
        }
        if (number > 999 && number < 10000)
        {
            int result = number / 10 % 10;
            Console.WriteLine("Third digit is " + result);
        }
        if (number > 9999 && number < 100000)
        {
            int result = number / 100 % 10;
            Console.WriteLine("Third digit is " + result);
        }
        if (number > 99999)
        {
            Console.WriteLine("Please, enter a number up to 99999.");
        }
    }

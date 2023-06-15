// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number < 1)
    {
       Console.WriteLine("Enter a number from 1 to 8!");
    }

if (number<6 && number>0)
    {
        Console.WriteLine("Weekday");
    }
if (number>5 && number<8)
    {
        Console.WriteLine("Weekend");
    }
     

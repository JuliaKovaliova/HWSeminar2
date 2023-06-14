// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

Console.WriteLine("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int numb2 ()
{
    if (number > 99 && number < 1000) 
    {
        int dec = number/10;
        int result = dec % 10;
        return result;
    }
    else
    {
        int result = -1;
        return result;
    }
}
if (numb2() == -1)
{
    Console.Write("You need to enter a three-digit number!");
}
else
{
    Console.WriteLine("Result is " + numb2());    
}         




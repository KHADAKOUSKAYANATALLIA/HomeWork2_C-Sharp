/* Напишите программу, которая принимает на вход трехзначное число
 и на выходе показывает вторую цифру этого числа. */

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 1; 


if (number > 99 && number < 1000){
    Console.WriteLine("Введено трехзначное число");

    int secondDigit = number / 10;        

    result = secondDigit % 10;}

else
{
    Console.WriteLine("Число не трехзначное: ");
    return;
}
    
    
Console.WriteLine("Вторая цифра трехзначного числа: " + result);




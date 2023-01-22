/* Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет. */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

int result = 1;

if (number >= 100)
{                  
    int thirdDigit = number;  // number / 10; 
    result = thirdDigit % 10;
}

else
{
    Console.WriteLine("Третьей цифры нет");
    return;
} 

    
Console.WriteLine("Третья цифра заданного числа: " + result);


/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным. */

Console.Write("Введите номер дня недели (от 1 до 7): ");
int NumberDay = Convert.ToInt32( Console.ReadLine() );

switch (NumberDay){
    case 1:        
    Console.Write("Понедельник"); 
    break;
    case 2:        
    Console.Write("Вторник"); 
    break;
    case 3:        
    Console.Write("Среда"); 
    break;
    case 4:        
    Console.Write("Четверг"); 
    break;
    case 5:        
    Console.Write("Пятница"); 
    break;
    case 6:        
    Console.Write("Суббота"); 
    break;
    case 7:        
    Console.Write("Воскресенье"); 
    break;
    default:
    Console.Write("В неделе 7 дней, введите цифру от 1 до 7: "); 
    break;
}


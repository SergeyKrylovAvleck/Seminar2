// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели");
    int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
        Console.WriteLine(" 1 -> Не выходной");
        break;
        
    case 2:
        Console.WriteLine(" 2 -> Не выходной");
        break;

    case 3:
        Console.WriteLine(" 3 -> Не выходной");
        break;
        
    case 4:
        Console.WriteLine(" 4 -> Не выходной");
        break;

    case 5:
        Console.WriteLine(" 5 -> Не выходной");
        break;

    case 6:
        Console.WriteLine(" 6 -> Выходной");
        break;

    case 7:
        Console.WriteLine(" 7 -> Выходной");
        break;
}
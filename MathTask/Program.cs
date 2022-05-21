/*/*
Напишите программу, которая принимает на вход координаты точки (X и Y),
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

            |
    2       |       1
            |
 -----------0----------->
            |
    3       |       4
            |
*/


int getQuarter(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    else if(x > 0 && y < 0)
        return 4;
    else if( x < 0 && y < 0)
        return 3;
    else 
        return 2;
}

int GetNumber(string msg)
{
    while(true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();
        if(int.TryParse(valueFromConsole, out int number))
        {
            if(number != 0)
                return number;
            else
            {
                Console.WriteLine("Введите число неравное нулю.");
            }
        }
        else 
        {
            Console.WriteLine("Вы ввели не число. Введите число отличное от нуля.");
        }
    }
}
string messageX = "Введите число x";
string messageY = "Введите число y";

int x = GetNumber(messageX);
int y = GetNumber(messageY);

int quater = getQuarter(x, y);

Console.WriteLine($"Точка лежит в {quater} четверти.");
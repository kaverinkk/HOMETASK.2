/*Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).

            |
    2       |       1
            |
 -----------0----------->
            |
    3       |       4
            |

*/




int GetQuarter()
{
    while (true)
    {
        Console.WriteLine("Введите номер четверти: ");
        int quater = Convert.ToInt32(Console.ReadLine());
        if (quater != 1 && quater != 2 && quater != 3 && quater != 4)
        {
            Console.WriteLine("Введите корректный номер четверти: ");
        }
        else
            return quater;
    }
}


void GetRange(int quater)
{
        if (quater == 1)
    {
        Console.WriteLine("x > 0 && y > 0");
    }
        else if (quater == 2)
    {
        Console.WriteLine("x < 0 && y > 0");
    }
        else if (quater == 3)
    {
        Console.WriteLine("x < 0 && y < 0");
    }
        else
    {
        Console.WriteLine("x > 0 && y < 0");
    }

}

int a = GetQuarter();
GetRange(a);

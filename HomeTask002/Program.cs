



int GetNumber(string msg)
{
    while(true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if(int.TryParse(valueFromConsole, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Введите число.");
        }
    }
}

double GetLenghtVector(double x, double x1, double x2, double y, double y1, double y2)
{
    double difx = Math.Pow((x - x1 - x2), 2);
    double dify = Math.Pow((y - y1 - y2), 2);
    double lenght = Math.Sqrt(difx + dify);
        return lenght;
}

int x = GetNumber("Введите значение координаты по x");
int x1 = GetNumber("Введите значение координаты по x");
int x2 = GetNumber("Введите значение координаты по x");
int y = GetNumber("Введите значение координаты по y");
int y1 = GetNumber("Введите значение координаты по y");
int y2 = GetNumber("Введите значение координаты по y");

double result = GetLenghtVector(x, x1, x2, y, y1, y2);
Console.WriteLine(result);
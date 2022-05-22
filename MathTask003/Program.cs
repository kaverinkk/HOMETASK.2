/*Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

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
            Console.WriteLine("Вы ввели не число. Введите число отличное от нуля.");
        }
    }
}

double GetLenghtVector(double x,double x1, double y, double y1)
{
    double difx = Math.Pow((x - x1), 2);
    double dify = Math.Pow((y - y1), 2);
    double lenght = Math.Sqrt(difx + dify);
        return lenght;
}

int x = GetNumber("Введите значение первой координаты по x");
int x1 = GetNumber("Введите значение второй координаты по x");
int y = GetNumber("Введите значение первой координаты по y");
int y1 = GetNumber("Введите значение первой координаты по y");

double resault = GetLenghtVector(x, x1, y, y1);
Console.WriteLine(resault);
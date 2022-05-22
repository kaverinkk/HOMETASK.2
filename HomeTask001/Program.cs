/* Напишите программу, которая на вход принимает 
пятизначное число и проверяет является ли оно палиндромом
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
            Console.WriteLine("Вы ввели не число, пожалуйста введите число.");
        }
    }
}

string getPalindrom(string number)
{
    number = new Random().Next(10000, 100000);
    if(number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} является палиндромом");
    }
    else
    {
        Console.WriteLine("Поменяйте цифры в числе так, чтобы число стало палиндромом.");
    }
}

string number = GetNumber("Введите число являющеесе палиндромом");
int result = getPalindrom(number);
Console.WriteLine(result);

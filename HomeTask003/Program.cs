/* Напишите программу, которая принимает на вход число (N), и выдает таблицу кубов чисел от 1 до N
*/

void getSquar(int N)
{
    foreach(int ind in Enumerable.Range(1, N))
    Math.Pow((ind), 3);
    Console.WriteLine(ind);
}

    


int GetNumber(string msg)
{
    while(true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();
        if(int.TryParse(valueFromConsole, out int number))
        {
            if(number > 0)
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

string message = "Введите N от 1, N = ";
int sqr = GetNumber(message);

getSquar(sqr);
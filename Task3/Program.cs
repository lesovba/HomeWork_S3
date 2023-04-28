/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int n = Math.Abs(Prompt("Введите число N: "));
int currentNum = 1;

int Prompt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

void cubicTable(int num)
{
    while (currentNum <= num)
    {
        Console.WriteLine(Math.Pow(currentNum, 3));
        currentNum++;
    }
}

cubicTable(n);
Console.ReadLine();
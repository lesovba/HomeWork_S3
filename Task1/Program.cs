/*Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

int fiveDigigtNumber = Prompt("Введите пятизначное число: ");

int Prompt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

void CheckPalindrome(int num)
{
    string fiveDigit = Convert.ToString(num);

    if (fiveDigit.Length == 5)
    {
        if (fiveDigit[0] == fiveDigit[4] && fiveDigit[1] == fiveDigit[3])
        { Console.WriteLine($"Число {num} является палиндромом"); }

        else
        { Console.WriteLine($"Число {num} НЕ является палиндромом"); }
    }
    else
        Console.WriteLine("Вы ввели не пятизначное число");
}

CheckPalindrome(fiveDigigtNumber);
/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/


int GetCorrect (string message) 

{
    int result = 0;
    bool isCorrect = false;
    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >=10000 && result <100000)
           isCorrect = true;
        else
           Console.WriteLine("Число не пятизначное");
    }
    return result;
}
int GetPolindtom(int result)
{
    int newNumeric = result;
    string numericAsString = newNumeric.ToString();
    int result0 = int.Parse(numericAsString[0].ToString());
    int result1 = int.Parse(numericAsString[1].ToString());
    int result3 = int.Parse(numericAsString[3].ToString());
    int result4 = int.Parse(numericAsString[4].ToString());
    if (result0==result4 && result1==result3)
    {
         Console.WriteLine($"Число {newNumeric} палиндром");
    }
    else 
    Console.WriteLine($"Число {newNumeric} не палиндром");

return newNumeric; 
}

int result = GetCorrect("Введите пятизначное число :");
GetPolindtom(result);



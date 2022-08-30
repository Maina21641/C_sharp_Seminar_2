// "Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23".

bool check (int num) 
{ 
    return num % 7 == 0 && num % 23 == 0;
} 
System.Console.WriteLine(check (160));
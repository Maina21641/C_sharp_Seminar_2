﻿/*int randomNumber = new Random().Next(10,1000);

int result = (randomNumber / 100) * 10 + randomNumber % 10;

System.Console.WriteLine($"число до преобразований - {randomNumber}");
System.Console.WriteLine($"число до преобразований - {result}");*/

int GetNumber(int Number){
    return (Number / 100) * 10 + Number % 10;
}
System.Console.WriteLine(GetNumber(new Random().Next(100, 1000)));
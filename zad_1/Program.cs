int randomNumber = new Random().Next(10,1000);

int result = (randomNumber / 100) * 10 + randomNumber % 10;

System.Console.WriteLine($"число до преобразований - {randomNumber}");
System.Console.WriteLine($"число до преобразований - {result}");
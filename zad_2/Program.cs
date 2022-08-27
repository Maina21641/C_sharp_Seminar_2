/*int a = 12;
int b = 4;

if (a % b == 0){
    System.Console.WriteLine("Кратно");
}
else{
    System.Console.WriteLine($"Не кратно, остаток - {a % b}");
}*/

void Check(int a, int b){
    if (a % b == 0){
        System.Console.WriteLine ("Кратно");
    }
    else{
    System.Console.WriteLine ($" не кратно, остаток: {a % b}");   
    }
}
Check (17, 7);
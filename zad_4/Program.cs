bool check (int a, int b)
{
     if (a * a == b){
        return true;
    } 
    else if (b * b == a){
        return true;
    }
    else{
        return false;
    }
}
System.Console.WriteLine(check (7, 14));
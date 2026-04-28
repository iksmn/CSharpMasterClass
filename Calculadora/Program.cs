Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
string firstNumber = Console.ReadLine();
int x = int.Parse(firstNumber);


Console.WriteLine("Input the second number:");
string secondNumber = Console.ReadLine();
int y = int.Parse(secondNumber);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
string userOption = Console.ReadLine();

Console.WriteLine("Press any key to close.");
Console.ReadKey();



if (userOption == 'A' || 'a')
{
    int Add(int x, int y)
    {
        return x + y;
    }
}
else if (userOption == "S" || "s")
{

}

int Subtract (int x, int y) 
{
    return x - y; 
}
int Multiply (int x, int y) 
{
    return x * y; 
}
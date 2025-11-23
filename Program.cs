
int A = 100;
System.Console.WriteLine("Hello World! " + A );
if (A < 100) 
{
    Console.WriteLine("true!");
}
else 
{
    Console.WriteLine("test");
}

double cena = 69.99;
Console.WriteLine("Rohlíky " + cena + " int A " + A );

void test()
{
    Console.WriteLine("TEST funkce! ");
}

test();

ConsoleColor puvodniBarva = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Switch funkce");
Console.ForegroundColor = puvodniBarva;
switch (A)

{
    default: Console.WriteLine("non of those!");
    break;
    case 1:
         Console.WriteLine("Case 1");   
    break;
    case 5:
         Console.WriteLine("Case 5"); 
    break;
}

 
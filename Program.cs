Console.Write("Введите число 1 =>");
string inputedString = Console.ReadLine(); 
Console.Write("Введите число 2 =>"); 
string inputedString2 = Console.ReadLine(); 
int number1 = Convert.ToInt32(inputedString);
int number2 = Convert.ToInt32(inputedString2);
int max=number1;
int min=number2;
if (max>min)
{
    Console.WriteLine("Большее число " + number1);
    Console.WriteLine("Меньшое число " + number2 );

}
else 
Console.WriteLine("Большее число " + number2);
    Console.WriteLine("Меньшое число " + number1 );

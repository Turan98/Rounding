// rounding
decimal value ;
int n;
Console.WriteLine("enter num which you want to rounding: ");
value = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("write approximation: ");
n = Convert.ToInt32(Console.ReadLine());
decimal math = decimal.Round(value, n, MidpointRounding.ToEven);
Console.WriteLine("your arrounding number: " + math);


Console.WriteLine("Введите числа :");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max=a;
if(a<b) max=b;
if(b<c) max=c;
Console.WriteLine("Самое большое число:");
Console.Write(max);
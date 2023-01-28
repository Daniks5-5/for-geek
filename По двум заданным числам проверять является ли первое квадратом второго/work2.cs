Console.WriteLine("Введите два числа : ");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
Console.WriteLine(a);
double c = a*a;
if(c==b){
    Console.WriteLine("первое число является квадратом второго числа");
}
else {
    Console.WriteLine("первое число не является квадротома второго");
}
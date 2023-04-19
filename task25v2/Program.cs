System.Console.WriteLine("Введите первое число ");
int number1 = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число ");
int number2 = int.Parse(System.Console.ReadLine());

int Quatro(int number3)
{
int summ = 1;
for(int i = 0; i != number2; i++)
{
    summ = summ * number1;
}
return summ;
}

System.Console.WriteLine(Quatro(number1));
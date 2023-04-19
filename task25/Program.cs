int x = Print("Введите первое число ");
int y = Print("Введите второе число ");

int Quatro(int number3)
{
    int summ = 1;
    for(int i = 0; i != y; i++)
    {
        summ = summ * x;
    }
return summ;
}

int Print(string arg1)
{
    System.Console.Write(arg1);
    int i;
    while(!int.TryParse(System.Console.ReadLine(), out i))
    {
        System.Console.WriteLine("its not a number");
    }
    return i;
}

System.Console.WriteLine(Quatro(x));


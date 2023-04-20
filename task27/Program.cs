// Задача 27: Напишите программу, которая 
// принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число ");

int num = 0;
while(!int.TryParse(System.Console.ReadLine(), out num))
{
    System.Console.WriteLine("Не число ");
}


int Function (int sum)
{
    string count = num.ToString();
    int number = count.Length;
    int number1 = 0;
    int i = 0;
    int summ = 0;
    
    while(i < number)
    {
        summ = summ + int.Parse(count[number1].ToString());
        i++;
        number1++;
    }
    return summ;
}

System.Console.WriteLine(Function(num));

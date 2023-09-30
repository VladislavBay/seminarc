using System.Diagnostics;

// int num = new Random().Next(100,1000);
// Console.WriteLine(num);
// int num1 = num/100;
// int num2 = num%10;

// int result = num1*10+num2;

// Console.WriteLine(result);


 


// if (num1>num2)
// {
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.WriteLine(num2);
// }
Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1%num2==0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно" + num1%num2+ "s"); // Канкатинация
    Console.WriteLine($"{num1}Не кратно  {num1%num2} s"); // Интерполяция
}
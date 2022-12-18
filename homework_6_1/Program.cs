/* Задача 1: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
Не использовать массив.
M=5 ; 0, 7, 8, -2, -2 -> 2
M=5 ; -1, -7, 567, 89, 223 -> 3 */

Console.WriteLine("Сколько чисел планируете сравнить? ");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
for(int i = 0; i < M; i++)
{
    Console.Write("Введите число " + (i+1) + ": ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num > 0)
    {
        count = count + 1;
        
    }
}
Console.Write("Количество положительных чисел: ");
Console.WriteLine(count);
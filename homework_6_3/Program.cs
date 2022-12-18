/* Задача 3*. Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Если кол-во элементов нечетное, то элемент посередине не учитывать.
Результат сложения вывести на экран.
1, 3, 8, 3, 2 -> 11
8, 3, 4, 2 -> 28 */

void FillArray (int [] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array [i] = rnd.Next(1, 10);
    }
}

void PrintArray (int [] array)
{
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Введите число элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[N];

FillArray(arr);
PrintArray (arr);

int sum = 0;
int prodact = 1;
for(int i = 0; i < arr.Length/2; i++)
{
    int fst = arr [i];
    int sec = arr [arr.Length-1-i];
    prodact = fst * sec;
    sum = sum + prodact;
}
Console.WriteLine(sum);
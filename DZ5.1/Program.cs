/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */



int[] array = new int [4];
Random rnd = new Random();

for (int i=0; i<4; i++)
 {
     array[i] = rnd.Next(100,999);
     Console.Write($"{array[i]} ");
 }

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < 4; i++)
    {
        if (array[i] % 2 == 0)
        count ++;
    }
    return count;
}

Console.WriteLine($" в массиве {Count(array)} четных числа.");


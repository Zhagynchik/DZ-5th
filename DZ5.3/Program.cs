/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76   */


int[] array = new int [4];
Random rnd = new Random();

for (int i=0; i<4; i++)
 {
     array[i] = rnd.Next(0,99);
     Console.Write($"{array[i]} ");
 }

int max = array[0];
int min = array[0];
for (int i = 0; i < 4; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

Console.Write($" разница между максимальным и минимальным значением = {max-min}");





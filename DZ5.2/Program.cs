/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */



int[] array = new int [4];
Random rnd = new Random();

for (int i=0; i<4; i++)
 {
     array[i] = rnd.Next(-99,99);
     Console.Write($"{array[i]} ");
 }

int summ = 0;
        for (int i = 1; i < 4 ; i= i+2)
        {
                summ = summ + array[i];
        }
     Console.WriteLine($" -> сумма элементов на нечетных позициях равна {summ}");


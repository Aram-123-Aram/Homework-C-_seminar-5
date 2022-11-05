/* Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] array = new int[8];

int Sum_nech_el = 0;
Console.Write("array= [");
for(int i = 0; i < array.Length; i++ )
{
    array[i] = new Random().Next(-100, 100);
    Console.Write(array[i] + ", ");
    
    if(i % 2 != 0) {Sum_nech_el = Sum_nech_el + array[i]; }
}
Console.Write("] -> " + Sum_nech_el);

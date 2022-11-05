/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] array = new int[10];

int Sum_chot = 0;
Console.Write("array= { ");
for(int i = 0; i < array.Length; i++ )
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + ", ");
    
    if(array[i] % 2 == 0) {Sum_chot = Sum_chot + 1; }
}
Console.Write(" } -> " + Sum_chot);

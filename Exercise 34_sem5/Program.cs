/* Задача 33.
Задайте массив. Задайте определенное число. Напишите программу,
который определяет-есть лы такое число в массиве.

int[] array = new int[5];

Console.Write("Сгенерируем массив: array= { ");
for(int i = 0; i < array.Length; i++)
{array[i] = new Random().Next(-9,10); 
Console.Write(array[i] + ", "); }
Console.WriteLine("}");

Console.Write("Enter the number a= ");
int.TryParse(Console.ReadLine(),out int a);

for(int i = 0; i < array.Length;i++)
{
    if(array[i] == a) {Console.Write($"{a}: -> Да,есть в массиве!"); break;}
    else {Console.Write($"{a}: -> Нет в массиве!"); }
}*/

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 

int[] array = new int[10];
int Sum_chot = 0;
Console.Write("array= { ");
for(int i = 0; i < array.Length; i++ )
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + ", ");
    
    if(array[i] % 2 == 0) {Sum_chot = Sum_chot + 1; }
}
Console.Write(" } -> " + Sum_chot); */

/* Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 

int[] array = new int[8];
int Sum_nech_el = 0;
Console.Write("array= [");
for(int i = 0; i < array.Length; i++ )
{
    array[i] = new Random().Next(-100, 100);
    Console.Write(array[i] + ", ");
    
    if(i % 2 != 0) {Sum_nech_el = Sum_nech_el + array[i]; }
}
Console.Write("] -> " + Sum_nech_el); */

/* Задача 38: 
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] array = new double[5];
double Roznita = 0;
Console.Write("Сгенерируем массив: array= { ");
for(int i = 0; i < array.Length; i++)
{array[i] = new Random().Next(100); 
Console.Write(array[i] + ", "); }
Console.WriteLine(" }");

void MaxMin(double[] array)
{double max = array[0];
double min = array[0];
    for(int i = 0; i < array.Length; i++) {if(array[i] > max) max = array[i];
                                           if(array[i] < min) min = array[i];}
Console.WriteLine($"Максимальное -> {max}"); Console.WriteLine($"Минимальное -> {min}");
Roznita = max - min; 
Console.Write($"Разница между макс. и мин. элементов: -> {Roznita}");                            
}
MaxMin(array);

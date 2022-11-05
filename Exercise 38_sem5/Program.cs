/* Задача 38: 
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] array = new double[10];
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

// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

/* Console.WriteLine ("Введите количество числе в массиве: ");
int size =  int.Parse(Console.ReadLine()!); 
int[] array = GetArray(size, 100, 1000);
Console.WriteLine ($"[{String.Join (" / ", array)}]");
int count = 0;

for (int i = 0; i < size; i++) 
{
    if (array [i] % 2 == 0)
    count ++;
}

Console.WriteLine ($"Количество чётных чисел в массиве равно {(count)} ");
*/

 // Задайте одномерный массив, заполненный случайными числами.
 // Найдите сумму элементов, стоящих на нечётных индексах.

 Console.WriteLine ("Введите количество числе в массиве: ");
int sizemas =  int.Parse(Console.ReadLine()!); 
Console.WriteLine ("Введите минимальную границу массива: ");
int minValue =  int.Parse(Console.ReadLine()!); 
Console.WriteLine ("Введите максимальную границу массива: ");
int maxValue =  int.Parse(Console.ReadLine()!); 

int[] array2 = GetArray(sizemas, minValue, maxValue+1);
Console.WriteLine ($"[{String.Join (" / ", array2)}]");
int sum = 0;

for (int i = 0; i < sizemas; i = i + 2)
{
 sum = sum + array2[i]; 
}

Console.WriteLine ($"Сумма элементов на нечетных индексах равна {(sum)} ");


// ------ Метод задача  1, 2, 3 --------

int[] GetArray (int size, int minVal, int maxVal)
{
    int[] res  = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next (minVal, maxVal);
    }
    return res;
}

// ------ Метод дазача 2 --------


// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

/* Console.WriteLine ("Введите количество чисел в массиве: ");
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
/*
Console.WriteLine ("Введите количество чисел в массиве: ");
int sizemas =  int.Parse(Console.ReadLine()!); 
Console.WriteLine ("Введите минимальную границу массива: ");
int minValue =  int.Parse(Console.ReadLine()!); 
Console.WriteLine ("Введите максимальную границу массива: ");
int maxValue =  int.Parse(Console.ReadLine()!); 

int[] array2 = GetArray(sizemas, minValue, maxValue+1);
Console.WriteLine ($"[{String.Join (" / ", array2)}]");
int sum = 0;

for (int i = 1; i < sizemas; i = i + 2)
{
 sum = sum + array2[i]; 
}

Console.WriteLine ($"Сумма элементов на нечетных индексах равна {(sum)} ");
*/


// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

Console.WriteLine ("Введите количество чисел в массиве: ");
int sizemas2 =  int.Parse(Console.ReadLine()!); 
Console.WriteLine ("Введите минимальную границу массива: ");
int minValue2 =  int.Parse(Console.ReadLine()!); 
Console.WriteLine ("Введите максимальную границу массива: ");
int maxValue2 =  int.Parse(Console.ReadLine()!); 

int[] array3 = GetArray(sizemas2, minValue2, maxValue2+1);

Console.WriteLine ($"[{String.Join (" / ", array3)}]");


int countmasFinal = sizemas2 / 2; // понятно что ошибка здесь, т.к. размер массива целочеисленное деление и при нечтеном исходном не получим верного

int[] arrayFinal  = new int[countmasFinal];

   for (int i = 0; i < countmasFinal; i++ )
{
    arrayFinal [i] = array3[i] * array3 [sizemas2 - 1 -i];
}

Console.WriteLine ($"[{String.Join (" / ", arrayFinal)}]");


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




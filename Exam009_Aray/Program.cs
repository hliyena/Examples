﻿// Поиск максимума из девяти. Число в указанном элементе массива и максимальное число в массиве

int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if (arg2 > result) result = arg2;
if (arg3 > result) result = arg3;
return result;
}
int[] array = { 1, 2, 31, 4, 5, 6, 7, 8, 9 };
array[0] = 0;
Console.WriteLine(array[4]);

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);

// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке
//  [20,90].

// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 101);
// }
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] >= 20 && array[i] <= 90)
//         count++;
// }
// Console.WriteLine($"Рандомный массив:[{string.Join("; ", array)}]");
// Console.WriteLine($"Колличество элементов массива в отрезке от 20 до 90: {count}");




//  Задача 2: Задайте массив на 10 целых чисел. Напишите программу,
//  которая определяет количество чётных чисел в массиве. 

// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 101);
// }
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//         count++;
// }
// Console.WriteLine($"Рандомный массив:[{string.Join("; ", array)}]");
// Console.WriteLine($"Колличество четных чисел: {count}");




// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.

// Console.Write("Задайте размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[size];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Math.Round(new Random().NextDouble() * new Random().Next(1001), 2);
// }
// double max = array[0];
// double min = array[0];
// for (int i = 1; i < array.Length; i++)
// {
//     if (array[i] > max) max = array[i];
//     if (array[i] < min) min = array[i];
// }
// Console.WriteLine($"Массив: [{string.Join("; ", array)}]");
// Console.WriteLine($"Максимальное число: {max}, минимальное число: {min}, разница чисел: {max - min}");



// Задача 4: Дано натуральное число в диапазоне от 1 до 100 000.
// Создайте массив, состоящий из цифр этого числа.
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем.
// Размер массива должен быть равен количеству цифр.

// Console.Write("Задайте число от 1 до 100 000");
// int number = Convert.ToInt32(Console.ReadLine());
// int temp = number;
// int size = 0;
// while (number > 0)
// {
//     number /= 10;
//     size++;
// }
// int[] array = new int[size];
// for (int i = array.Length - 1; i >= 0; i--)
// {
//     array[i] = temp % 10;
//     temp /= 10;
// }
// Console.WriteLine($"Массив:[{string.Join(";", array)}]");
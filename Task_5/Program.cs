int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("  ");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1.Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. ");
    Console.WriteLine("2. Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
    Console.WriteLine("3.Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    programm = Convert.ToInt32(Console.ReadLine());
    switch(programm)
    {
        case 1:
            //Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
                Console.WriteLine("Введите массив: ");
                int number = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[number];
                GetRandomNumber(array);
                GetEvenNumber(array);
                PrintArray(array);
                void GetRandomNumber(int[] array)
                {
                    for (int i = 0; i < number; i++)
                    {
                        array[i] = new Random().Next(100, 1000);
                    }
                }
                void GetEvenNumber(int[] array)
                {
                    int count = 0;
                    for (int i = 0; i < array.Length; i ++)
                    {
                        if (array[i] % 2 == 0)
                        {
                           count++;
                        }

                    }
                    Console.WriteLine($"из {array.Length} чисел, {count} четных");
                }
                void PrintArray(int[] array)
                {
                    Console.Write("[ ");
                    for(int i = 0; i < array.Length; i++)
                        {
                             Console.Write(array[i] + " ");
                        }
                    Console.Write("]");
                    Console.WriteLine();
                }
            break;
        case 2:
            // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
                Console.WriteLine("Введите массив: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                int[] array1 = new int[number1];
                GetRandomNumber1(array1);
                GetNumberNoneven(array1);
                PrintArray1(array1);
                void GetRandomNumber1(int[] array)
                {
                    int NumberFirst = 1;
                    int NumberSecond = 100;
                    for (int i = 0; i < number1; i++)
                    {
                        array1[i] = new Random().Next(NumberFirst, NumberSecond);
                    }
                }
                void GetNumberNoneven(int[] array, int sum = 0)
                {
                    int count = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sum +=array[i];
                            count++;
                        }
                    }
                    Console.WriteLine($"Сумма элементов в нечетных позициях равна {sum}");
                }
                void PrintArray1(int[] array)
                {
                    Console.Write("[ ");
                    for(int i = 0; i < array.Length; i++)
                        {
                             Console.Write(array[i] + " ");
                        }
                    Console.Write("]");
                    Console.WriteLine();
                    
                }
            
            break;
        case 3:
            // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            Console.WriteLine("Введите массив: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            double[] array2 = new double[number2];
            FillRandomNumber2(array2);
            PrintArray2(array2);
            GetNumberMaxAndMin(array2);
            void FillRandomNumber2(double[] array)
            {
                int NumberFirst = 100;
                int NumberSecond = 1000;
                for (int i = 0; i < array2.Length; i++)
                {
                    array[i] = Convert.ToDouble(new Random().Next(NumberFirst, NumberSecond)) / 100;
                }
            }
            void GetNumberMaxAndMin(double[] array)
            {
                double max = Int32.MinValue;
                double min = Int32.MaxValue;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
                double diff = max - min;
                Console.WriteLine($"всего {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
                Console.WriteLine($"Разница между максимальным и минимальным значением = {diff:f2}");
            }

            void PrintArray2(double[] array)
            {
                    Console.Write("[ ");
                    for(int i = 0; i < array.Length; i++)
                        {
                             Console.Write(array[i] + " ");
                        }
                    Console.Write("]");
                    Console.WriteLine();
            }
        break;
        default:
             begin = false;
             break;
        
    }
}



// Console.WriteLine("Ввндите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// RandNumberArray(array);
// DecitionArray(array);
// PrintArray(array);
// void RandNumberArray(int[] array)
// {
//     for (int i = 0; i < size; i++)
//     {
//          array[i] = new Random().Next(-9, 9);

//     }
// }
// void DecitionArray(int[] array, int sum = 0, int sub = 0)
// { 
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             sum += array[i];
            
//         }
//         else 
//         {
//             sub -= array[i];
            

//         }
//     }
//     Console.WriteLine($"Сумма положительных чисел в массиве равен {sum}, сумма отрицательных чисел равен {sub}");

// }
// void PrintArray(int[] array)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


//Console.Clear();
//Console.Write("Введите первое положительное число: ");
//int m = Convert.ToInt32(Console.ReadLine());

//string rec (int n)
//{
//    if (n==m)
//    {
//        return "";
//   }
//    return rec(n-1)+$"{n} ";
//}

//Console.Write("Введите второе положительное число: ");
//int n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(rec(n-1));
//-------------------------------------------------
//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//Console.Clear();
//Console.Write("Введите первое число: ");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int n = Convert.ToInt32(Console.ReadLine());

//int akk(int m, int n)
//{
//    if (m == 0)
//    {
//        return n + 1;
//    }
//    else if (n == 0)
//    {
//        return akk(m - 1, 1);
//    } else
//    {
//        return akk(m - 1, akk(m, n - 1));
//    }
//}
//Console.Write($"Равно= {akk(m,n)} ");

//-------------------------------------------------
//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
//Console.Clear();
//Console.Write("Введите количество элементов массива: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int [] array = new int[n];
//int i;
//for(i=0; i<array.Length; i++)
//    array[i]=new Random().Next(1,9999);
///Console.WriteLine(string.Join(" ",array));

//Запуталась в типах данных и не смогла решить задачу с массивами
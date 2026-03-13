using System;
/*
 1. Създайте методи за задаване на стойности и извеждане на масив от цели
числа. Методите за задаване на стойности да са три варианта - 1) за
генериране на масива със случайни цели числа, 2) void метод за въвеждане от
клавиатурата, 3) метод за въвеждане от клавиатурата, който връща масива от
числа като резултат.
2. Създайте методи за намиране на най-малка и най-голяма стойност на масив.
3. Създайте метод за намиране на сумата от всички елементи в масив.
4. Създайте метод, който намира средното аритметично на елементите в масив
от цели числа. Резултатьт да е от тип реално число.
5. Създайте метод, който обръща елементите на масив отзад-напред и връща
обърнатия масив като резултат.
Тествайте всеки от създадените методи в Main()
 */
namespace _12._03._2026_uprProgramirane
{
    class Program
    {
        #region 9a
        //public static void CreateRandomArray(int[] array)
        //{
        //    Random r = new Random();
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        array[i] = r.Next(-50, 50);
        //    }
        //}
        //public static void InputArrayValues(int[] array)
        //{            
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write("Enter next element: ");
        //        array[i] = int.Parse(Console.ReadLine());
        //    }
        //}
        //public static int[] CreateArray(int n)
        //{
        //    int[] array = new int[n];
        //    Random r = new Random();
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        array[i] = r.Next(-100, 100);
        //    }
        //    return array;
        //}
        //static int SumArray(int[] array)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        sum += array[i];
        //    }
        //    return sum;
        //}
        //public static void DisplayArray(int[] array)
        //{
        //    foreach (var item in array)
        //    {
        //        Console.WriteLine("Next element: {0}", item);
        //    }
        //}
        #endregion
        #region 9b
        public static void StoreRandomData(int[] array)
        {
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-50, 50);
            }
        }
        public static void StoreConsoleData(int[] array)
        {
            Console.WriteLine("Enter array values from the console:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"array[{i}] = ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void DisplayArray(int[] array)
        {
            Console.WriteLine("Array elements: ");
            foreach (var item in array)            
            {               
                Console.WriteLine(item);
            }
        }
        public static void DsplayArrayWithIndexes(int[] array)
        {
            Console.WriteLine("Array elements:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }
        }
        public static int[] CreateRandomArray(int length)
        {
            int[] array = new int[length];

            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-50, 50);
            }
            return array;
        }
        public static int Sum(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }
        #endregion
        static void Main(string[] args)
        {
            #region 9a
            //Console.Write("Enter array count: ");
            //int count = int.Parse(Console.ReadLine());

            //int[] array1 = new int[count];
            //CreateRandomArray(array1);
            //Console.WriteLine("First array:");            
            //DisplayArray(array1);
            //Console.WriteLine("Elements sum: " + SumArray(array1));

            //int[] array2 = new int[10];
            //CreateRandomArray(array2);
            //Console.WriteLine("Second array:");
            //DisplayArray(array2);
            //Console.WriteLine("Elements sum: " + SumArray(array2));
            ////int[] array3 = new int[count];
            ////InputArrayValues(array3);
            ////Console.WriteLine("Third array:");
            ////DisplayArray(array3);

            //int[] array4 = CreateArray(4);
            //Console.WriteLine("Forth array:");
            //DisplayArray(array4);
            //Console.WriteLine("Elements sum: " + SumArray(array4));
            #endregion
            #region 9b
            int[] arr = CreateRandomArray(7);
            DsplayArrayWithIndexes(arr);
            Console.WriteLine("Sum array elements: {0}", Sum(arr));
            Console.WriteLine();

            int[] array1 = new int[5];
            StoreRandomData(array1);
            DsplayArrayWithIndexes(array1);
            Console.WriteLine("Sum array elements: {0}", Sum(array1));
            Console.WriteLine();

            Console.Write("Enter second array length: ");
            int n = int.Parse(Console.ReadLine());
            int[] array2 = new int[n];
            StoreRandomData(array2);
            DisplayArray(array2);
            Console.WriteLine("Sum array elements: {0}", Sum(array2));
            Console.WriteLine();

            int[] array3 = new int[3];
            StoreConsoleData(array3);
            DisplayArray(array3);
            Console.WriteLine("Sum array elements: {0}", Sum(array3));
            #endregion

        }
    }
    }


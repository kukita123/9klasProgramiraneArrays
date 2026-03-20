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
        //static double AverageArray(int[] array)
        //{
        //    return (double)SumArray(array) / array.Length;
        //}
        //public static void DisplayArray(int[] array)
        //{
        //    foreach (var item in array)
        //    {
        //        Console.WriteLine("Next element: {0}", item);
        //    }
        //}
        //public static void DisplayElements(int[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.WriteLine("Element [{0}] = {1}", i, array[i]);
        //    }
        //}
        //public static int Min(int[] array)
        //{
        //    int min = array[0];  //min = int.MaxValue и for трябва да започва от 0
        //    for (int i = 1; i < array.Length; i++)
        //    {
        //        if (array[i] < min)
        //            min = array[i];
        //    }
        //    return min;
        //}
        //public static int Max(int[] array)
        //{
        //    int max = array[0]; //max = int.MinValie и for трябва да започва от 0
        //    for (int i = 1; i < array.Length; i++)
        //    {
        //        if (array[i] > max)
        //            max = array[i];
        //    }
        //    return max;
        //}
        //public static int[] ReverceArray(int[] array)
        //{
        //    int[] newArray = new int[array.Length];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        newArray[i] = array[array.Length - 1 - i];
        //    }
        //    return newArray;
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
        public static int Min(int[] array)
        {
            int min = array[0]; // min = int.MaxValue, for (int i = 0; ...)
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }
        public static int Max(int[] array)
        {
            int max = array[0]; // min = int.MinValue, for (int i = 0; ...)
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
        public static double Average(int[] array)
        {
            return (double)Sum(array) / array.Length;
        }
        public static int[] ReverseArray1(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[array.Length - 1 - i];
            }
            return newArray;
        }
        public static int[] ReverseArray2(int[] array)
        {            
            for (int i = 0; i < array.Length / 2; i++)
            {
                //array[i] swap with array[array.Length - 1 - i]:
                int swap;
                swap = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = swap;
            }
            return array;
        }
        //Задача последна:
        //Напишете програма, която въвежда масив А, съдържащ n на брой(3 < n< 20)
        //цели числа и определя колко пъти в него се повтаря максималния му елемент.
        public static int CountMax(int[] array)
        {
            int max = Max(array);
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                    count++;
            }
            return count;
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
            //DisplayElements(array1);
            //Console.WriteLine("Min = {0}", Min(array1));
            //Console.WriteLine("Max = {0}", Max(array1));
            //int[] revercedArray = ReverceArray(array1);
            //DisplayElements(revercedArray);


            ////DisplayArray(array1);
            //Console.WriteLine("Elements sum: " + SumArray(array1));
            //Console.WriteLine("Elements average: "+ AverageArray(array1));

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
            #region ZadachPosledna
            Console.Write("Enter n between 3 and 20:  ");
            int N = int.Parse(Console.ReadLine());
            while(N < 3 || N > 20)
            {
                Console.Write("Wrong value, enter again n between 3 and 20:  ");
                N = int.Parse(Console.ReadLine());
            }
            int[] arrayLast = new int[N];

            StoreConsoleData(arrayLast);
            Console.WriteLine("Count of max value: {0}", CountMax(arrayLast));

            #endregion

            int[] arr = CreateRandomArray(10);
            DsplayArrayWithIndexes(arr);
            Console.WriteLine("Sum array elements: {0}", Sum(arr));
            Console.WriteLine("Average value: {0}", Average(arr));
            Console.WriteLine("Max element is: {0}", Max(arr));
            Console.WriteLine("Min element is: {0}", Min(arr));

            int[] reversed1 = ReverseArray1(arr);
            Console.WriteLine("Reversed - first algorithm:");
            DsplayArrayWithIndexes(reversed1);

            int[] reversed2 = ReverseArray2(arr);
            Console.WriteLine("Reversed - second algorithm:");
            DsplayArrayWithIndexes(reversed2);
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


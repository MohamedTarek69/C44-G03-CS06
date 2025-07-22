using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session_6
{
    internal class Program
    {

        //-------------------------------------------- Part 07 --------------------------------------------
        // Types of Method
        // 1. Class Member Function [static Function]
        // 2. Object Member Function [Non-static Function]
        // Employee => static Print , Non-static Select
        // Employee.Print
        // Employee Emp01 = new Employee();
        // Emp01.Select
        #region Methods
        public static void PrintShape()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(":)");
            }
        }

        public static void PrintShape(int Count = 5 , string Pattern =":(" )
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(Pattern);
            }
        }

        //-------------------------------------------- Part 08 --------------------------------------------
        public static void Swap(int X , int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }

        //-------------------------------------------- Part 09 --------------------------------------------
        public static void Swap(ref int X , ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }
        //-------------------------------------------- Part 10 --------------------------------------------
        public static int SumArray(int[] Arr)
        {
            int Sum = 0;
            Arr[0]=100;
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }

        public static int SumArray(ref int[] Arr)
        {
            int Sum = 0;
            Arr[0]=100;
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }
        //-------------------------------------------- Part 11 --------------------------------------------
        public static int SumArray2(int[] Arr)
        {
            int Sum = 0;
            //Arr[0] = 100;
            Arr = new int[] { 10, 20, 30, 40 };
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }

        public static int SumArray2(ref int[] Arr)
        {
            int Sum = 0;
            //Arr[0] = 100;
            Arr = new int[] { 10, 20, 30, 40 };
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }

        //-------------------------------------------- Part 12 --------------------------------------------
        public static void SumSub(int x, int y, out int Sum, out int Sub)
        {
            Sum = x + y;
            Sub = x - y;

            //return new int[] {Sub,Sum};
            //return [Sum, Sub];
            //return new {Sum, Sub};
        }

        #endregion

        static void Main(string[] args)
        {
            //-------------------------------------------- Part 02 --------------------------------------------
            #region Arrays

            #region 1D Array
            #region Example 01
            //int[] Numbers;
            //Numbers = new int[3];

            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;

            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);
            //// 2 * 4 bytes = 8 + 0x0000 = 0x0008

            //Console.WriteLine(Numbers.Length);
            //Console.WriteLine(Numbers.Rank);

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Array Creation Ways
            //int[] Numbers01 = new int[3];
            //int[] Numbers02 = new int[3] { 1, 2, 3 };
            //int[] Numbers03 = new int[] { 1, 2, 3 };
            //int[] Numbers04 = { 1, 2, 3 };

            #endregion

            #endregion

            //-------------------------------------------- Part 03 --------------------------------------------
            #region 2D Array[Rectangular]
            //int[,] Marks = new int[2, 5] { { 100, 90, 30, 50, 40 },
            //                               { 20, 10, 60, 77, 80 } };

            //Marks[0, 0] = 100;
            //Marks[0, 1] = 90;
            //Marks[0, 2] = 40;
            //Marks[0, 3] = 80;
            //Marks[0, 4] = 60;
            //Marks[1, 0] = 99;
            //Marks[1, 1] = 80;
            //Marks[1, 2] = 44;
            //Marks[1, 3] = 40;
            //Marks[1, 4] = 98;

            //Console.WriteLine(Marks.Length);
            //Console.WriteLine(Marks.Rank);
            //Console.WriteLine(Marks.GetLength(0));
            //Console.WriteLine(Marks.GetLength(1));

            //int[,] Marks = new int[2, 5];

            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"The Grade Of Student Number {i + 1}");
            //    for (int j = 0; j < Marks.GetLength(1); /*j++*/)
            //    {
            //        Console.Write($"Subject Number {j + 1} : ");
            //        //Marks[i,j] = Console.ReadLine();
            //        bool isParse = int.TryParse(Console.ReadLine(), out Marks[i, j]);

            //        if (isParse)
            //            j++;
            //    }
            //    Console.WriteLine("============================");
            //}
            ////Print
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"The Grade Of Student Number {i + 1}");
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Subject Number {j + 1} : {Marks[i,j]}");
            //    }
            //    Console.WriteLine("============================");
            //}
            //-------------------------------------------- Part 04 --------------------------------------------
            //for (int i = 0; i < Marks.Length; i++)
            //{
            //    Console.WriteLine(Marks[i / Marks.GetLength(1), i % Marks.GetLength(1)]);
            //}

            #endregion

            //-------------------------------------------- Part 05 --------------------------------------------
            #region Jagged Array
            //int[][] JaggedArr = new int[3][];

            //JaggedArr[0] = new int[3] { 1, 2, 3 };
            //JaggedArr[1] = new int[2] { 4, 5 };
            //JaggedArr[2] = new int[1] { 6 };

            ////JaggedArr[0][1] = 5;

            //for (int i = 0; i < JaggedArr.Length; i++)
            //{
            //    for (int j = 0; j < JaggedArr[i].Length; j++)
            //    {
            //        Console.WriteLine(JaggedArr[i][j]);
            //    }
            //}

            #endregion

            #endregion

            //-------------------------------------------- Part 06 --------------------------------------------
            #region Array Methods
            //int[] Numbers = { 5, 3, 2, 4, 1 };

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //Console.WriteLine("After Sorting: ");
            //Array.Sort(Numbers);

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //Console.WriteLine("After Reversing: ");
            //Array.Reverse(Numbers);

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            ////Console.WriteLine("After Clearing: ");
            ////Array.Clear(Numbers);

            ////for (int i = 0; i < Numbers.Length; i++)
            ////{
            ////    Console.WriteLine(Numbers[i]);
            ////}

            //// 5 , 3 , 2 , 4 , 1 
            //Console.WriteLine("After Clearing: ");
            //Array.Clear(Numbers,2,2);

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //Console.WriteLine(Array.IndexOf(Numbers,5));
            //Console.WriteLine(Array.LastIndexOf(Numbers,5));

            //Array.Resize(ref Numbers, 10);
            //Array.

            #endregion

            //-------------------------------------------- Part 07 --------------------------------------------
            #region Functions

            #region Function Prototype
            //PrintShape();

            //PrintShape(10, ":)");
            //PrintShape(Pattern:":)",Count:10);
            //PrintShape(10, "123");
            //PrintShape(Pattern:"+L+");
            //PrintShape(Pattern:@"/*\");

            //Console.WriteLine("Welcome Mostafa\nHello Amr");
            //Console.WriteLine("Welcome Mostafa\tHello Amr");
            //Console.WriteLine("Welcome Mostafa\rHello Amr");
            //Console.WriteLine("Welcome Mostafa\\Hello Amr");
            //Console.WriteLine("Welcome Mostafa\bHello Amr");

            //D:\Course .NET\02 C# Basics\Session 06\Answer\C44-G03-C#06\Session 6\Session 6.csproj
            //Console.WriteLine("D:\\Course .NET\\02 C# Basics\\Session 06\\Answer\\C44-G03-C#06\\Session 6\\Session 6.csproj");
            //Console.WriteLine(@"D:\Course .NET\02 C# Basics\Session 06\Answer\C44-G03-C#06\Session 6\Session 6.csproj");



            #endregion

            //-------------------------------------------- Part 08 --------------------------------------------
            #region Function Parameters[Value Type]

            #region Passing by Value
            //int A = 9;
            //int B = 4;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Console.WriteLine("After Swapping: ");
            //Swap(A, B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            #endregion

            //-------------------------------------------- Part 09 --------------------------------------------
            #region Passing by Reference
            //int A = 9;
            //int B = 4;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Console.WriteLine("After Swapping: ");
            //Swap(ref A, ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            #endregion

            #endregion

            //-------------------------------------------- Part 10 --------------------------------------------
            #region Function Parameters[Reference Type]

            #region Passing By Value
            //int[] Numbers = { 1, 2, 3 };

            ////int[] Arr = Numbers;

            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);



            #endregion

            #region Passing By Reference
            //int[] Numbers = { 1, 2, 3 };

            ////int[] Arr = Numbers;

            //Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers[0]);


            #endregion

            //-------------------------------------------- Part 11 --------------------------------------------
            #region Passing By Value
            //int[] Numbers = { 1, 2, 3 };

            ////int[] Arr = Numbers;

            //Console.WriteLine(SumArray2(Numbers));
            //Console.WriteLine(Numbers[0]);



            #endregion

            #region Passing By Reference
            //int[] Numbers = { 1, 2, 3 };

            ////int[] Arr = Numbers;

            //Console.WriteLine(SumArray2(ref Numbers));
            //Console.WriteLine(Numbers[0]);


            #endregion

            #endregion

            //-------------------------------------------- Part 12 --------------------------------------------
            #region Function Parameters[Passing By out]
            //SumSub(10, 5, out int S, out int B);

            //Console.WriteLine(S);
            //Console.WriteLine(B);

            #endregion

            #region Function Parameters[Params]


            #endregion

            #endregion

        }
    }
}

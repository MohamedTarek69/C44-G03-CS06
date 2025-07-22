namespace Session_6
{
    internal class Program
    {
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

            #endregion


        }
    }
}

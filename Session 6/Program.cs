namespace Session_6
{
    internal class Program
    {
        #region Q1-(Methods) Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
        public static void IncrementNumber(int num)
        {
            num+=10;
        }
        public static void IncrementNumber(ref int num)
        {
            num += 10;
        }

        #endregion


        static void Main(string[] args)
        {
            #region Q1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            /*
             * Passing by value: means that a copy of the variable is passed to the method
             * so changes made to the value inside the method don't affect the original variable
             */
            /*
             * Passing by reference: means that a reference to the original variable is passed to the method (the actual variable is passed)
             * so changes made to the value inside the method affect the original variable
             */

            //int number;
            //Console.Write("Please enter a number: ");
            //bool isParse = int.TryParse(Console.ReadLine(), out number);
            //if (isParse)
            //{
            //    Console.WriteLine($"Your number is: {number}");
            //    // Passing by value
            //    IncrementNumber(number);
            //    Console.WriteLine($"After passing the number by value: {number}");
            //    // Passing by reference
            //    IncrementNumber(ref number);
            //    Console.WriteLine($"After passing the number by reference: {number}");   
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid number.");
            //}

            #endregion

        }
}
}

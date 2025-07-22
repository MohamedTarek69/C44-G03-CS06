namespace Session_6
{
    internal class Program
    {
        #region Methods

        #region Q1-(Method) Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
        // Passing by value
        public static void IncrementNumber(int num)
        {
            num+=10;
        }
        // Passing by reference
        public static void IncrementNumber(ref int num)
        {
            num += 10;
        }

        #endregion

        #region Q2-(Method) Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
        public static void IncrementArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 10;
            }
            // Reassigning the array inside the method will NOT affect the original array
            // So this will not affect the original array
            arr = new int[] { 100, 200, 300 };
        }
        public static void IncrementArray(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 10;
            }
            // Reassigning the array will affect the original array since we're using ref
            // So this will affect the original array
            arr = new int[] { 100, 200, 300 };
        }
        #endregion

        #region Q3-(Method) Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers.
        public static void Calculate(int[] Arr, out int sum, out int sub)
        {
            sum = Arr[0];
            sub = Arr[0];
            for (int i = 1; i < Arr.Length; i++)
            {
                sum += Arr[i];
                sub -= Arr[i];
            }
        }
        #endregion

        #region Q4-(Method) Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number
        /*
         Output should be like 
         Enter a number: 25                                                                                            
         The sum of the digits of the number 25 is: 7
        */

        public static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        #endregion

        #region Q5-(Method) Create a function named "IsPrime", which receives an integer number and returns true if it is prime, or false if it is not
        public static bool IsPrime(int number)
        {
            if (number <= 1) 
                return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        #endregion

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

            #region Q2- Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            /*
             * Passing by value: means that a copy of the reference to the array is passed to the method
             * so changes made to the elements inside the method affect the original array
             * and in the method stack frame it create a variable that have the the same address to the heap as the orginal variable
             * but if you try to reassign the array to a new array inside the method it will not affect the original array
             */
            /*
             * Passing by reference: means that a reference to the original array is passed to the method
             * so changes made to the elements inside the method affect the original array
             * and in the method stack frame it doesn't create a variable that have the the same address to the heap as the orginal variable
             * instead it uses the orginal variable directly
             * here if you try to reassign the array to a new array inside the method it will affect the original array
             */

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Original array: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}
            //// Passing by value
            //IncrementArray(numbers);
            //Console.WriteLine("\nAfter passing the array by value: ");
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}
            //// Passing by reference
            //IncrementArray(ref numbers);
            //Console.WriteLine("\nAfter passing the array by reference: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}


            #endregion

            #region Q3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers.
            //Console.WriteLine("Please enter 4 numbers: ");
            //int[] numbers = new int[4];

            //for (int i = 0; i < numbers.Length;)
            //{
            //    Console.Write($"Number {i + 1}: ");
            //    bool isParse = int.TryParse(Console.ReadLine(), out numbers[i]);
            //    if (isParse)
            //    {
            //        i++;

            //    }
            //}
            //int sum, sub;
            //Calculate(numbers, out sum, out sub);
            //Console.WriteLine($"The summation of the numbers is: {sum}");
            //Console.WriteLine($"The subtraction of the numbers is: {sub}");


            #endregion

            #region Q4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number
            /*
             Output should be like 
             Enter a number: 25                                                                                            
             The sum of the digits of the number 25 is: 7
             */

            //Console.Write("Please enter a number to calculate the sum of its digits: ");
            //bool isParse = int.TryParse(Console.ReadLine(), out int number);
            //if (isParse)
            //{
            //    int sum = SumOfDigits(number);
            //    Console.WriteLine($"The sum of the digits of the number is: {sum}");
            //}


            #endregion

            #region Q5- Create a function named "IsPrime", which receives an integer number and returns true if it is prime, or false if it is not
            //Console.Write("Please enter a number to check if it is prime: ");
            //int number;
            //bool isParse = int.TryParse(Console.ReadLine(), out number);
            //if (isParse)
            //{
            //    bool isPrime = IsPrime(number);
            //    if (isPrime)
            //    {
            //        Console.WriteLine($"{number} is a prime number.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{number} is not a prime number.");
            //    }
            //}
            #endregion
        }
    }
}
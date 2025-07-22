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
        public static void Calculate(int num1, int num2, out int sum, out int sub)
        {
            sum = num1 + num2;
            sub = num1 - num2;
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

        #region Q6-(method) Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
        public static void MinMaxArray(ref int[] arr, ref int min, ref int max)
        {
            min = arr[0];
            max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];

                if (arr[i] > max)
                    max = arr[i];
            }
        }
        #endregion

        #region Q7-(method) Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
        public static int Factorial(int number)
        {
            int result = 1;
            for (int i = 2; i <= number; i++)
                result *= i;
            return result;
        }
        #endregion

        #region Q8-(method) Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
        public static string ChangeChar(string input, int position, char newChar)
        {
            if (position < 0 || position >= input.Length)
                return input;

            char[] chars = input.ToCharArray();
            chars[position] = newChar;
            return new string(chars);
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
            //Console.WriteLine("Please enter 2 numbers: ");
            //int num1, num2, num3, num4;
            //Console.Write("Number 1: ");
            //int.TryParse(Console.ReadLine(), out num1);
            //Console.Write("Number 2: ");
            //int.TryParse(Console.ReadLine(), out num2);
            //int sum, sub;
            //Calculate(num1, num2, out sum, out sub);
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

            #region Q6- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //Console.WriteLine("Please enter 5 numbers: ");
            //int[] numbers = new int[5];

            //for (int i = 0; i < numbers.Length;)
            //{
            //    Console.Write($"Number {i + 1}: ");
            //    bool isParse = int.TryParse(Console.ReadLine(), out numbers[i]);
            //    if (isParse)
            //    {
            //        i++;

            //    }
            //}
            //int min = 0, max = 0;
            //MinMaxArray(ref numbers, ref min, ref max);
            //Console.WriteLine($"The minimum value in the array is: {min}");
            //Console.WriteLine($"The maximum value in the array is: {max}");

            #endregion

            #region Q7- Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //int number;
            //retry:
            //Console.Write("Please enter a number to calculate its factorial: ");
            //bool isParse = int.TryParse(Console.ReadLine(), out number);
            //if (isParse && number > 0)
            //{
            //    int factorial = Factorial(number);
            //    Console.WriteLine($"The factorial of {number} is: {factorial}");
            //}
            //else
            //{
            //    goto retry;
            //}

            #endregion

            #region Q8- Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            //Console.Write("Please enter a string: ");
            //string? input = Console.ReadLine();
            //retry:
            //Console.Write("Please enter the position of the character to change (0 based): ");
            //int position;
            //bool isParse = int.TryParse(Console.ReadLine(), out position);
            //if (isParse && position >= 0 && position < input?.Length)
            //{
            //    Console.Write("Please enter the new character: ");
            //    char newChar;
            //    char.TryParse(Console.ReadLine(), out newChar);
            //    string modifiedString = ChangeChar(input, position, newChar);
            //    Console.WriteLine($"Modified string: {modifiedString}");
            //}
            //else
            //{
            //    goto retry;
            //}

            #endregion

        }
    }
}
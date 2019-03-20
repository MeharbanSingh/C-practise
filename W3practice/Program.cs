using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // displayRectangle();
            //Console.Write(swap("mehar"));
            // Console.WriteLine(checkString("wwrj"));
            //Console.WriteLine(countNumber(3));
            //patteren();
            // Console.WriteLine(checkStartString("hello how are you"));
            //reverseLetter();
            //user();
            Console.WriteLine(fibonacci());
            //int num;

            //Console.Write("\n\nRecursive Function : To calculate the Fibonacci number of a specific term :\n");
            //Console.Write("-------------------------------------------------------------------------------\n");
            //Console.Write("Enter a number: ");
            //num = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("\nThe Fibonacci of {0} th term  is {1} \n", num, Fib(num));
        }

        //Write a program in C# Sharp to create a recursive function to calculate the Fibonacci number of a specific term. Go to the editor
        //Test Data :
        //Enter a number: 10
        //Expected Output :
        //The Fibonacci of 10 th term is 55
        //1,1,2,3,5,8,13,21,34,55,89


            //Recursive
        public static int Fib(int n1)
        {
            //if ( (n1 == 1) || (number == 2) )
            if (n1 <= 2)
                return 1;
            else
                return Fib(n1 - 1) + Fib(n1 - 2);
            
        }

        //iterartive

        public static string fibonacci()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            int[] fibarray = new int[number];

            int a = 0, b = 1, c = 0;
            for (int i = 0; i < number; i++)
            {
                c = a + b;
                fibarray[i] = c;
                a = b;
                b = c;
            }

            string result = $"The Fibonacci of {number} th term is {fibarray[number-2]}";
            return result;
        }



//        Write a program in C# Sharp to create a user define function. Go to the editor
//Expected Output :
//Welcome Friends!
//Have a nice day!

        public static void user()
        {
            string welcome = "Welcome Friends!";
            string greet = "Have anice day!";

            Console.WriteLine($"{welcome} \n {greet}");
        }

//        Write a C# Sharp program that takes three letters as input and display them in reverse order. Go to the editor
//Test Data
//Enter letter: b
//Enter letter: a
//Enter letter: t
//Expected Output :
//t a b

        public static void reverseLetter()
        {
            char letter1, letter2, letter3;
            Console.WriteLine("Enter letter 1:");
            letter1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter letter 2:");
            letter2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter letter 3:");
            letter3 = Convert.ToChar(Console.ReadLine());


            Console.Write($"{letter1},{letter2},{letter3}");

            
        }

            // Write a C# Sharp program to create a new list from a given list of integers removing those values end with 7.

            public static List<int>listGenerate(List<int> basic){

            return basic.Where(x=>x!=7).ToList();

        }

        public static bool checkStartString(string word)
        {
            if (word.StartsWith("hello"))
                return true;
            else
                return false;
        }


        // Name pattern

            public static void patteren()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j > 1 && j < 8 && i == 0 | i == 4)
                        Console.Write(" ");
                    else if (j > 2 && j < 7 && i == 1)
                        Console.Write(" ");
                    else if (j > 3 && j < 6 && i == 2)
                        Console.Write(" ");
                    else if (j > 1 && j < 8 && i == 3)
                        Console.Write(" ");
                    else if (j == 4 && i == 3)
                        Console.Write("M");
                    else
                        Console.Write("M");
                }

                Console.WriteLine(" ");

            }
        }
        public static int matrixSum(int [][]array)
        {
            int sum = 0;
            for (int i = 0; i < array[0].Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j][i] > 0)
                        sum += array[j][i];

                }

            }
            return sum;

        }

// Write a C# program to count a specified number in a given array of integers. Go to the editor
//Test Data:
//Input an integer: 5
//Sample Output
//Number of 5 present in the said array: 2 

            public static int countNumber(int number)
        {
            int count = 0;
            int[] array = new int[] {3,5,3,1,2,3,4,5,6,7,8,9,10 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                    count++;

            }
            return count;
        }

//Write a C# program to check if a given string starts with "w" and immediately followed by two "ww". Go to the editor
//Test Data:
//Input a string : www
//Sample Output
//False

            public static bool checkString(string word)
        {
            return (word.Substring(0,3) == "www") ? true: false;
        }



        public static string swap(string word) {

            
            string firstWord = word.Substring(0,1);
            string lastWord = word.Substring(word.Length-1);

           string format = word.Substring(1,word.Length-2);
            word = string.Format("{0}{1}{2}",lastWord,format,firstWord);

            return word;

        }

//        Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit. Go to the editor
//Test Data:
//Enter a number: 5
//Expected Output:
//555
//5 5
//5 5
//5 5
//555

        public static void displayRectangle()
        {
            int a = 5;
            for (int b = 0; b < 5; b++)
            {
               // Console.WriteLine("  ");
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < b; k++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("$");
                }

               
            }

        }
    }
}

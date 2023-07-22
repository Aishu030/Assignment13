using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignment
{
    //Assignment 13
    //Basic C# Concepts and Programming
    internal class Program
    {
        //static long CalculateFactorial(int n )
        //{
        //    if (n == 0)
        //        return 1;
        //    return n * CalculateFactorial(n - 1);
        //}
        static void Main(string[] args)
        {
            //Task1 : Hello World
            Console.WriteLine("Hello World!");

            //Task2 : Variables and User Input
            Console.WriteLine("Enter your Name:");
            String name = Console.ReadLine();
            Console.WriteLine($"Welcome {name} !!!");

            //Task 3: Basic Arithmetic
            //Console.WriteLine("Enter first number:");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number:");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Addition : " + (num1 + num2));
            //Console.WriteLine("Subtraction: " + (num1 - num2));
            //Console.WriteLine("Multiplication: " + (num1 * num2));
            //Console.WriteLine("Division: " + (num1 / num2));
            //if (num2 != 0)
            //{
            //    double quotient = (double)num1 / num2;
            //    Console.WriteLine($"Division: {num1} / {num2} = {quotient}");
            //}
            //else
            //{
            //    Console.WriteLine("Division by zero is not allowed.");
            //}
            //Console.WriteLine("Modulus: " + (num1 % num2));


            ////Task 4: Control Strructures
            //Console.WriteLine("Enter a Number: ");
            //int num = int.Parse( Console.ReadLine() );
            //if( num % 2==0 ) {
            //    Console.WriteLine("The Given Number is EVEN!!");
            //}
            //else
            //{
            //    Console.WriteLine("The  Given Number is ODD !!!");
            //}

            ////Task 5: Loops
            //Console.WriteLine("Numbers from 1 to 10:");
            //for (int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Task 6: Arrays
            //int[] arr = new int[5];
            //Console.WriteLine("Enter Five numbers");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int sum = 0;
            //foreach (int i in arr)
            //{
            //    sum += i;
            //}

            //Console.WriteLine("Sum of elements in the array : " + sum);

            //double average = (double)sum / arr.Length;
            //Console.WriteLine("Average of elements in the array : " + average);

            //Task 7: Methods
            //Console.WriteLine("Enter a  positive integer: ");
            //int number = int.Parse(Console.ReadLine());
            //if(number < 0)
            //{
            //    Console.WriteLine("Cant find the factorial of negative number");
            //}
            //else 
            //{
            //    long factnum = CalculateFactorial(number);
            //    Console.WriteLine($"Factorial of {number} is {factnum}");
            //}

            //Task 8 : Exception Hnadling
            //int age = 0;
            //bool isValidInput = false;
            //while (!isValidInput)
            //{
            //    Console.Write("Enter your age: ");
            //    string input = Console.ReadLine();

            //    if (int.TryParse(input, out age))
            //    {
            //        isValidInput = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid!!! Please enter a valid age");

            //    }

            //}

            //try
            //{
            //    if (age < 0)
            //    {
            //        throw new Exception("Age can't be negative!!!");
            //    }
            //    else if (age < 18)
            //    {
            //        Console.WriteLine("********You are a minor******");
            //    }
            //    else if (age >= 18 && age < 65)
            //    {
            //        Console.WriteLine("**********You are an adult*********");
            //    }
            //    else
            //    {
            //        Console.WriteLine("*********You are a senior*********");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error!!!!" + ex.Message);
            //}
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
       

       
    }
}

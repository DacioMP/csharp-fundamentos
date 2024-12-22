using System;
using System.ComponentModel.Design;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      MyCalc();
    }

    static void MyCalc()
    {
      Console.Clear();
      Console.WriteLine("What would you like to do?");
      Console.WriteLine("1 - Sum");
      Console.WriteLine("2 - Subtraction");
      Console.WriteLine("3 - Division");
      Console.WriteLine("4 - Multiplication");
      Console.WriteLine("5 - Exit");

      try
      {
        Console.WriteLine("-----------------");
        Console.WriteLine("Select an option:");
        short opt = short.Parse(Console.ReadLine());
        float[] numbers;

        Console.Clear();

        switch (opt)
        {
          case 1:
            numbers = GetNumbers();
            Sum(numbers[0], numbers[1]);
            break;
          case 2:
            numbers = GetNumbers();
            Sub(numbers[0], numbers[1]);
            break;
          case 3:
            numbers = GetNumbers();
            Div(numbers[0], numbers[1]);
            break;
          case 4:
            numbers = GetNumbers();
            Mult(numbers[0], numbers[1]);
            break;
          case 5:
            System.Environment.Exit(0);
            break;
          default:
            Console.WriteLine("Invalid option. Try again or press 5 to exit.");
            Thread.Sleep(2000);
            MyCalc();
            break;
        }
      }
      catch (FormatException)
      {
        Console.WriteLine("Enter a valid number or press 5 to exit.");
        Thread.Sleep(2000);
        MyCalc();
      }
    }

    static float[] GetNumbers()
    {
      try
      {
        Console.WriteLine("First number: ");
        float n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Second number: ");
        float n2 = float.Parse(Console.ReadLine());
        return [n1, n2];
      }
      catch
      {
        throw new FormatException();
      }
    }

    static void Sum(float number1, float number2)
    {
      Console.WriteLine($"Result: {number1 + number2}");
      Console.ReadKey();
      MyCalc();
    }

    static void Sub(float number1, float number2)
    {
      Console.WriteLine($"Result: {number1 - number2}");
      Console.ReadKey();
      MyCalc();
    }

    static void Div(float number1, float number2)
    {
      Console.WriteLine($"Result: {number1 / number2}");
      Console.ReadKey();
      MyCalc();
    }

    static void Mult(float number1, float number2)
    {
      Console.WriteLine($"Result: {number1 * number2}");
      Console.ReadKey();
      MyCalc();
    }
  }
}
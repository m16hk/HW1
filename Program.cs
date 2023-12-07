
 // First Progamming Assignment 1 
 // Efren Ortiz 
 // MEE 381
 // 12/07/2023 

 using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int n = 800000; // number of random numbers to generate 
        double[,] numbers;
        float[,] floatNumbers;
        double[] doubles = GenRandomDoubles(n);
        double[] results = new double[n];
        Stopwatch timer = new Stopwatch();

        // Array Manipulation (Addition and Casting)
        numbers = GenRandomNumbers(n);
        floatNumbers = new float[n, 3]; // Create an array for floats

        timer.Start();
        AddNumbers(numbers, n);
        timer.Stop();
        Console.WriteLine("Additions (Doubles)");
        Console.WriteLine("Elapsed time = " +
            timer.ElapsedMilliseconds + " ms " +
            timer.ElapsedTicks + " ticks\n");
        double addTicksDoubles = (float)timer.ElapsedTicks;

        timer.Restart();
        AddFloats(floatNumbers, numbers, n);
        timer.Stop();
        Console.WriteLine("Additions (Floats)");
        Console.WriteLine("Elapsed time = " +
            timer.ElapsedMilliseconds + " ms " +
            timer.ElapsedTicks + " ticks\n");
        double addTicksFloats = (float)timer.ElapsedTicks;

        Console.WriteLine("Ratio (Addition) = " + addTicksDoubles / addTicksFloats);

        // Compute Square (Direct Multiplication)
        timer.Restart();
        SquareDoublesDirectly(doubles, results);
        timer.Stop();
        Console.WriteLine("Direct Multiplication ");
        Console.WriteLine("Elapsed time = " +
            timer.ElapsedMilliseconds + " ms " +
            timer.ElapsedTicks + " ticks\n");
        double directMultiplicationTicks = (float)timer.ElapsedTicks;

        // Using Math.Pow to Square
        timer.Restart();
        SquareDoublesWithMathPow(doubles, results);
        timer.Stop();
        Console.WriteLine("Using Math.Pow ");
        Console.WriteLine("Elapsed time = " +
            timer.ElapsedMilliseconds + " ms " +
            timer.ElapsedTicks + " ticks\n");
        double mathPowTicks = (float)timer.ElapsedTicks;

        // Using Math.Sqrt to Compute Square Root
        timer.Restart();
        ComputeSquareRootWithMathSqrt(doubles, results);
        timer.Stop();
        Console.WriteLine("Using Math.Sqrt (Square Root)");
        Console.WriteLine("Elapsed time = " +
            timer.ElapsedMilliseconds + " ms " +
            timer.ElapsedTicks + " ticks\n");
        double mathSqrtTicks = (float)timer.ElapsedTicks;

        
    }

    // Function to generate an array of random numbers
    static double[,] GenRandomNumbers(int count)
    {
        Random rand = new Random();
        double[,] num = new double[count, 3];
        for (int i = 0; i < count; ++i)
        {
            num[i, 0] = 10000.0 * rand.NextDouble();
            num[i, 1] = 10000.0 * rand.NextDouble();
        }

        return num;
    }

    // Function to generate an array of random doubles
    static double[] GenRandomDoubles(int count)
    {
        Random rand = new Random();
        double[] doubles = new double[count];
        for (int i = 0; i < count; ++i)
        {
            doubles[i] = 10000.0 * rand.NextDouble();
        }
        return doubles;
    }

    // Function that adds numbers in the supplied 2D array (Doubles)
    static void AddNumbers(double[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = nums[i, 0] + nums[i, 1];
        }
    }

    // Function that adds numbers in the supplied 2D array (Floats)
    static void AddFloats(float[,] floats, double[,] doubles, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            floats[i, 2] = (float)(doubles[i, 0] + doubles[i, 1]);
        }
    }

    // Function that multiplies numbers in the supplied 2D array (Doubles)
    static void MultiplyNumbers(double[,] nums, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            nums[i, 2] = nums[i, 0] * nums[i, 1];
        }
    }

    // Function that multiplies numbers in the supplied 2D array (Floats)
    static void MultiplyFloats(float[,] floats, double[,] doubles, int count)
    {
        for (int i = 0; i < count; ++i)
        {
            floats[i, 2] = (float)(doubles[i, 0] * doubles[i, 1]);
        }
    }

    // Function to square doubles directly
    static void SquareDoublesDirectly(double[] doubles, double[] results)
    {
        for (int i = 0; i < doubles.Length; ++i)
        {
            results[i] = doubles[i] * doubles[i];
        }
    }

    // Function to square doubles using Math.Pow
    static void SquareDoublesWithMathPow(double[] doubles, double[] results)
    {
        for (int i = 0; i < doubles.Length; ++i)
        {
            results[i] = Math.Pow(doubles[i], 2);
        }
    }

    // Function to compute square root using Math.Sqrt
    static void ComputeSquareRootWithMathSqrt(double[] doubles, double[] results)
    {
        for (int i = 0; i < doubles.Length; ++i)
        {
            results[i] = Math.Sqrt(doubles[i]);
        }
    }
}

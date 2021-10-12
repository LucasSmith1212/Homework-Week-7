/// Week 7 Project 1
/// File Name: week7project1.cs
/// Author: Lucas Smith
/// Date:  October 11, 2021
///
/// Problem Statement: Creates a counter class that can be used in Main. Main program will update the counter inside the counter class.
/// 
/// 
/// Overall Plan:
/// 1) Declare public class Counter
/// 2) Declare the methods inside, along with the private scope variable count that will be used inside.
/// 3) Use each method in main to change the counter variable in Counter

using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter count = new Counter();

            count.setCounter();
            Console.WriteLine(count.displayCount());

            count.incCounter();
            Console.WriteLine(count.displayCount());

            count.incCounter();
            Console.WriteLine(count.displayCount());

            Counter countTwo = new Counter();
            countTwo.setCounter();
            countTwo.incCounter();
            Console.WriteLine("Counter is " + count.getCount());
            Console.WriteLine("Equals method used: " + count.Equals(countTwo));

            count.dscCounter();

            Console.WriteLine("Counter is " + count.toString());
            Console.WriteLine("Second Counter is " + countTwo.toString());

            Console.WriteLine("Equals method used again: " + count.Equals(countTwo));
            
        }
    }
}

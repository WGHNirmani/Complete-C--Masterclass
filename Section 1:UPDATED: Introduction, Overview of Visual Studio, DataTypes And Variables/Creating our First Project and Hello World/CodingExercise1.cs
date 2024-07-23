// Coding Exercise 1: Simple Variables Introduction

/*

Simple Variables Introduction

Simple Variables Introduction

#########################################

Please, avoid changing the given source code for the exercise! So only add code, don't modify unless it is instructed to do so!

#########################################

Create a simple C# program that declares an integer variable, assigns it the value 10, and prints the value to the console.


Alert!

The result of execution for the default string should be:


"10"

*/

// Answer:

using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintNumber()
        {
            // TODO
            int age;
            age = 10;
            Console. WriteLine(age);
        }
    }
}

/*

HintL

1. Remember to declare your variable within the method.

2. Ensure it is the correct data type for storing whole numbers.

*/


/*

Solution Explanation:

We first declared the int type variable myNumber, and assigned the value 10 to it.

Then, we simply used a Console.WriteLine method to print the value to the screen.

    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public void PrintNumber()
            {
                int myNumber = 10; // Declare an integer variable and assign it the value "10"
                Console.WriteLine(myNumber); // Print the variable to the console
            }
        }
    }

  */

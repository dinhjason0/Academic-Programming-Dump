using System;
using System.Collections.Generic;
using System.Text;

namespace QuizProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // As per the assignment, the program will (in a nutshell) calculate A % B, ask the
            // user for the answer, and tell the user if their answer is correct.  The program
            // can also do A + B, A * B, etc, etc

            int userChoiceOperator; // holds a number that represents which operator the user
            // want to be quizzed on.

            int A;      // this will be the randomly generated value for A, in A % B = C
            int minA;   // smallest value of A that the program WILL generate
            int maxA;   // largest value of A that the program WILL generate

            int B;      // this will be the randomly generated value for B, in A % B = C
            int minB;   // smallest value of B that the program WILL generate
            int maxB;   // largest value of B that the program WILL generate

            int C;      // used in (A / B ) % C
            int minC;
            int maxC;

            int numTimesToQuiz; // how many times does the user want to be quizzed?

            int answer; // holds the answer to A % B (or A + B, etc)
            int usersAnswer; // holds the user's answer to A % B (or A + B, etc)
            Random rand = new Random(); // this will be used to generate the random numbers

            Console.WriteLine("Welcome to The Quiz Program!");
            Console.WriteLine("You can be quizzed on any of the following operators:");
            Console.WriteLine("1) %   (modulus, or 'remainder')");
            Console.WriteLine("2) *   (multiplication)");
            Console.WriteLine("3) /   (integer division)");
            Console.WriteLine("4) / % (integer division & modulus in a combined challenge!");
            Console.Write("Type the number of the operator that you wish to be quizzed on: ");

            // COMMENT: The code that follows is an example of how bad it is to duplicate code.  The
            // program works, but it was created with some copy-and-pasting (meaning that it's easy to 
            // miss typos), will be hard to maintain (if you find a bug in one block of code, you'll
            // have to check for it in every other block - and what happens if the author copy-and-pasted
            // the buggy code into another program?  You'd have to know to go looking for it), and overall,
            // this is an "inelegant" solution.
            // Wouldn't you rather figure it out once, write a routine/function/procedure/whatever you 
            // call it just once, and then reuse it a bunch of times?
            // That's why we like to use functions / methods in computer programming :)

            // COMMENT: Note that we've got a lot of 'magic numbers' in the code, which is another
            // bad programming practice.  If you want to add another operator to your quiz program,
            // you'll need to go through & make sure that everything else still works, or that
            // you have updated everything correctly.

            userChoiceOperator = 0;
            while (userChoiceOperator < 1 || userChoiceOperator > 4)
            {
                if (Int32.TryParse(Console.ReadLine(), out userChoiceOperator) == false)
                {
                    Console.WriteLine("You need to type in a whole number, between 1 and 4: ");
                }
                else if (userChoiceOperator < 1)
                {
                    Console.WriteLine("You need to type in a number that is 1 or greater: ");
                }
                else if (userChoiceOperator > 4)
                {
                    Console.WriteLine("You need to type in a number that is 4 or less: ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("I will ask you to tell me the result of");
            Console.WriteLine();
            switch (userChoiceOperator)
            {
                case 1:
                    Console.WriteLine("     A % B");
                    break;
                case 2:
                    Console.WriteLine("     A * B");
                    break;
                case 3:
                    Console.WriteLine("     A / B (integer division)");
                    break;
                case 4:
                    Console.WriteLine("     (A / B ) % C (integer division, then modulus)");
                    break;
            }
            Console.WriteLine();
            Console.Write("What is the smallest value of A: ");
            minA = Int32.MinValue;
            while (minA == Int32.MinValue)
            {
                if (Int32.TryParse(Console.ReadLine(), out minA) == false)
                {
                    minA = Int32.MinValue; // reset minA, so we'll go through the loop again

                    Console.WriteLine("You need to type in a whole number: ");
                }
                else if (minA == Int32.MinValue)
                {
                    minA = Int32.MinValue; // reset minA, so we'll go through the loop again

                    Console.WriteLine("I'm sorry, but {0} is a reserved value, and you're not allowed to use that - try {1}, instead: ", Int32.MinValue, Int32.MinValue + 1);
                }
                else if (minA == Int32.MaxValue)
                {
                    minA = Int32.MinValue; // reset minA, so we'll go through the loop again

                    Console.WriteLine("I'm sorry, but you can't choose integer values larger than {0}, and {1} is a value reserved for use by this program, so in order to be able to have larger values for A, you'll need to choose {2} or smaller for the minimum value: ", Int32.MaxValue, Int32.MaxValue, Int32.MaxValue - 2);
                }
            }

            Console.Write("What is the largest value of A: ");
            maxA = Int32.MaxValue;
            while (maxA == Int32.MaxValue)
            {
                if (Int32.TryParse(Console.ReadLine(), out maxA) == false)
                {
                    Console.WriteLine("You need to type in a whole number: ");
                    maxA = Int32.MaxValue; // reset maxA, so we'll go through the loop again
                }
                else if (maxA == Int32.MaxValue)
                {
                    maxA = Int32.MaxValue; // reset maxA, so we'll go through the loop again

                    Console.WriteLine("I'm sorry, but {0} is a reserved value, and you're not allowed to use that - try {1}, instead: ", Int32.MaxValue, Int32.MaxValue - 1);
                }
                else if (maxA <= minA)
                {
                    maxA = Int32.MaxValue; // reset maxA, so we'll go through the loop again

                    Console.WriteLine("The largest value of A must be larger than the smallest value of A (you chose the smallest value to be {0}): ", minA);
                }
            }


            Console.Write("What is the smallest value of B: ");
            minB = Int32.MinValue;
            while (minB == Int32.MinValue)
            {
                if (Int32.TryParse(Console.ReadLine(), out minB) == false)
                {
                    minB = Int32.MinValue; // reset minB

                    Console.WriteLine("You need to type in a whole number: ");
                }
                else if (minB == Int32.MinValue)
                {
                    minB = Int32.MinValue; // reset minB

                    Console.WriteLine("I'm sorry, but {0} is a reserved value, and you're not allowed to use that - try {1}, instead: ", Int32.MinValue, Int32.MinValue + 1);
                }
                else if (minB == Int32.MaxValue)
                {
                    minB = Int32.MinValue; // reset minB

                    Console.WriteLine("I'm sorry, but you can't choose integer values larger than {0}, and {1} is a value reserved for use by this program, so in order to be able to have larger values for B, you'll need to choose {2} or smaller for the minimum value: ", Int32.MaxValue, Int32.MaxValue, Int32.MaxValue - 2);
                }
            }

            Console.Write("What is the largest value of B: ");
            maxB = Int32.MaxValue;
            while (maxB == Int32.MaxValue)
            {
                if (Int32.TryParse(Console.ReadLine(), out maxB) == false)
                {
                    maxB = Int32.MaxValue; // reset maxB

                    Console.WriteLine("You need to type in a whole number: ");
                }
                else if (maxB == Int32.MaxValue)
                {
                    maxB = Int32.MaxValue; // reset maxB

                    Console.WriteLine("I'm sorry, but {0} is a reserved value, and you're not allowed to use that - try {1}, instead: ", Int32.MaxValue, Int32.MaxValue - 1);
                }
                else if (maxB <= minB)
                {
                    maxB = Int32.MaxValue; // reset maxB

                    Console.WriteLine("The largest value of B must be larger than the smallest value of B (you chose the smallest value to be {0}): ", minB);
                }
            }

            minC = maxC = 0;
            if (userChoiceOperator == 4) // user chose (A / B) % C
            {
                Console.Write("What is the smallest value of C: ");
                minC = Int32.MinValue;
                while (minC == Int32.MinValue)
                {
                    if (Int32.TryParse(Console.ReadLine(), out minC) == false)
                    {
                        minC = Int32.MinValue; // reset minC

                        Console.WriteLine("You need to type in a whole number: ");
                    }
                    else if (minC == Int32.MinValue)
                    {
                        minC = Int32.MinValue; // reset minC

                        Console.WriteLine("I'm sorry, but {0} is a reserved value, and you're not allowed to use that - try {1}, instead: ", Int32.MinValue, Int32.MinValue + 1);
                    }
                    else if (minC == Int32.MaxValue)
                    {
                        minC = Int32.MinValue; // reset minC

                        Console.WriteLine("I'm sorry, but you can't choose integer values larger than {0}, and {1} is a value reserved for use by this program, so in order to be able to have larger values for C, you'll need to choose {2} or smaller for the minimum value: ", Int32.MaxValue, Int32.MaxValue, Int32.MaxValue - 2);
                    }
                }

                Console.Write("What is the largest value of C: ");
                maxC = Int32.MaxValue;
                while (maxC == Int32.MaxValue)
                {
                    if (Int32.TryParse(Console.ReadLine(), out maxC) == false)
                    {
                        maxC = Int32.MaxValue; // reset maxC

                        Console.WriteLine("You need to type in a whole number: ");
                    }
                    else if (maxC == Int32.MaxValue)
                    {
                        maxC = Int32.MaxValue; // reset maxC

                        Console.WriteLine("I'm sorry, but {0} is a reserved value, and you're not allowed to use that - try {1}, instead: ", Int32.MaxValue, Int32.MaxValue - 1);
                    }
                    else if (maxC <= minC)
                    {
                        maxC = Int32.MaxValue; // reset maxC

                        Console.WriteLine("The largest value of C must be larger than the smallest value of C (you chose the smallest value to be {0}): ", minB);
                    }
                }
            }

            Console.WriteLine();
            Console.Write("How many times do you wish to be quizzed: ");
            Console.WriteLine();
            numTimesToQuiz = 0;
            while (numTimesToQuiz < 1)
            {
                if (Int32.TryParse(Console.ReadLine(), out numTimesToQuiz) == false)
                {
                    Console.WriteLine("You need to type in a whole number: ");
                }
                else if (numTimesToQuiz < 1)
                {
                    Console.WriteLine("You can't be quizzed zero/negative times - you need to choose at least one: ");
                }
            }

            Console.WriteLine();
            Console.Write("Ok, we're ready to go!");
            Console.WriteLine();

            for (int iQuiz = 0; iQuiz < numTimesToQuiz; iQuiz++)
            {

                A = rand.Next(minA, maxA + 1); // Next only goes up to, BUT DOES NOT INCLUDE the second 
                B = rand.Next(minB, maxB + 1); // parameter, so we need to add 1 to include the max param
                C = rand.Next(minC, maxC + 1);

                ///////////////////////////////////////////////////////////////////
                // STUDENTS: YOU NEED TO FILL IN THE FOLLOWING WITH YOUR CODE:
                ///////////////////////////////////////////////////////////////////

                /// NOTE NOTE: In order to get full credit for this assignment, you need to 
                /// demonstrate that you know how to use
                /// 
                /// 1) if statements
                /// 2) if...else statements
                /// 3) switch statements
                /// 
                /// in order to get full credit for this assignment, you'll need to implement 
                /// this code THREE times - 
                /// the first time, you'll use just 'if statements'. Run the program, make sure 
                /// that everything works,then comment out that solution (but leave the code in, 
                /// commented out, so that your instructor can see it!),
                /// for your second you'll write your code using if...else statements.  Run the 
                /// program, make sure everything works, comment it out, and then solve 
                /// this problem one more time, this time using at least one switch statement
                /// NOTENOTE: The assignment references these line numbers exactly (214-228),so
                /// if the above description has moved, change the assignment, too!

                // STUDENTS: YOUR SOLUTION USING 'IF STATEMENTS' SHOULD START HERE  //

                // blah
                // blah 
                // blah

                // STUDENTS: YOUR SOLUTION USING 'IF STATEMENTS' SHOULD END HERE  //


                // STUDENTS: YOUR SOLUTION USING 'IF/ELSE STATEMENTS' SHOULD START HERE  //

                // blah
                // blah 
                // blah

                // STUDENTS: YOUR SOLUTION USING 'IF/ELSE STATEMENTS' SHOULD END HERE  //


                // STUDENTS: YOUR SOLUTION USING 'SWITCH STATEMENTS' SHOULD START HERE  //


                // STUDENTS: YOUR SOLUTION USING 'SWITCH STATEMENTS' SHOULD END HERE  //


                ///////////////////////////////////////////////////////////////////
                // STUDENTS: YOU NEED TO FILL IN THE ABOVE WITH YOUR CODE:
                ///////////////////////////////////////////////////////////////////

            }

            Console.WriteLine("Thank you for using this program - have a nice day!");
            Console.WriteLine("Press the 'Return' key to exit");
            Console.ReadLine();
        }

    }
}
using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code is used by the first exercise
            // It is left here, uncommented, so that it's easy for you to run
            // Once you complete it, feel free to comment these lines out
            // That way, you won't have every single exercise being run, each and
            // every time :)

            Basic_Console_IO bcio = new Basic_Console_IO();
            bcio.RunExercise(); // you will need to uncomment this line!

            // The two lines of code below are used by the next exercise.
            // When you decide to do that exercise, you'll need to uncomment
            // these two lines.
            Basic_Arithmetic_Operators bao = new Basic_Arithmetic_Operators();
            bao.RunExercise();

            // Similarly, you'll need to uncomment these lines...
            Comparison_Operators co = new Comparison_Operators();
            co.RunExercise();

            Define_An_Instance_Method daim = new Define_An_Instance_Method();
            daim.RunExercise();

            HelloPrinter HP = new HelloPrinter();
            HP.printHello();

            NumberPrinter NP = new NumberPrinter();
            NP.printTwoNumbers();

            ThisIsAJoke TIAJ = new ThisIsAJoke();
            TIAJ.Joke();
        }
    }

    class Basic_Console_IO
    {
        public void RunExercise()
        {
            string szInput;
            int x;
            double y;
            Console.Write("Type a value for X here: ");
            szInput = Console.ReadLine();
            Int32.TryParse(szInput, out x);
            Console.WriteLine("You typed: " + x);
            Console.Write("Type a value for Y here: ");
            szInput = Console.ReadLine();
            Double.TryParse(szInput, out y);
            Console.WriteLine("You typed: " + y);
        }
    }

    class Basic_Arithmetic_Operators
    {
        public void RunExercise()
        {
            {
                int x = 2, y = 8, z;
                Console.WriteLine("2 times 8 equals " + x * y);	// multiply
                Console.WriteLine("8 divided by 2 equals " + y / x);	// divide
                Console.WriteLine("8 mod 2 equals " + y % x);		// modulus
                Console.WriteLine("2 plus 8 equals " + (x + y));	// add
                Console.WriteLine("8 minus 2 equals " + (y - x));	// subtract
                z = ((y - (2 * x)) * 6) / 12;
                Console.WriteLine("z now equals " + z);
                Console.WriteLine("\n");
            }
        }
    }

    class Comparison_Operators
    {
        public void RunExercise()
        {
            string szInput = "";
            int x = 0, y = 8, z = 14, key = 1;
            while (key == 1)
            {
                //Acts as a criterion to be filled
                Console.WriteLine("Give me a whole number!");
                //User Prompt
                szInput = Console.ReadLine();
                if (Int32.TryParse(szInput, out x) == true)
                {
                    if (x < y)
                    {
                        Console.WriteLine("{0} is less than {1}", x, y);
                    }
                    else if (x == y)
                    {
                        Console.WriteLine("You found the value for y! Which is: {0}", y);
                    }
                    else if (x == z)
                    {
                        Console.WriteLine("You found the value for z! Which is: {0}", z);
                    }
                    else if (x > y && x < z)
                    {
                        Console.WriteLine("{0} is more than {1} and less than {2}", x, y, z);
                    }
                    else
                    {
                        Console.WriteLine("{0}... that's a big number, surely bigger than {1}", x, z);
                    }
                    //Series of checks with a disgusting number of if/else if checks.
                    //I can probably find a better alternative.
                    key = 0;
                    //Key is changed to 0, and thus equivalent to "True" to continue the program
                }
                else Console.WriteLine("That's... not a whole number. Please type a whole number.");
            }
            Console.WriteLine("\n");
        }
    }

    class Define_An_Instance_Method
    {
        public void RunExercise()
        {
            Console.Write("H");
            Console.Write("E");
            Console.Write("L");
            Console.Write("L");
            Console.Write("O");
            Console.Write(",");
            Console.Write("W");
            Console.Write("O");
            Console.Write("R");
            Console.Write("L");
            Console.WriteLine("D");
            //This spells "HELLO, WORLD"
            Method_Two();
            //This calls the second method below, and because it's in the same class, it doesn't need an object to be called
        }

        public void Method_Two()
        {
            string Method_Too = "Method_Two is a method too";
            Console.WriteLine("{0}", Method_Too);
            //Taught in video 5-A
            //Also I needed a comment here for professional flair
        }
    }

    class HelloPrinter
    {
        public void printHello()
        {
            Console.WriteLine("I am the printer of the greetings! HEAR ME HELLO!!!");
            printSayonara();
        }
        public void printSayonara()
        {
            Console.WriteLine("I am the printer of goodbyes! HEAR ME SAYONARA!!");
            NumberPrinter NP = new NumberPrinter();
        }
    }

    class NumberPrinter
    {
        public void printTwoNumbers()
        {
            int key = 1, x, y;
            string npInputOne = "", npInputTwo = "";
            while (key == 1)
            {
                //Acts as a criterion to be filled
                Console.WriteLine("Give me a whole number!");
                //User Prompt
                npInputOne = Console.ReadLine();
                if (Int32.TryParse(npInputOne, out x) == true)
                {
                    Console.WriteLine("Give me another whole number!");
                    npInputTwo = Console.ReadLine();
                    if (Int32.TryParse(npInputTwo, out y) == true)
                    {
                        Console.WriteLine("The two numbers you've typed are {0} and {1}", x, y);
                        key = 0;
                    }
                    else Console.WriteLine("That's... not a whole number. Please type a whole number.");
                }
                else Console.WriteLine("That's... not a whole number. Please type a whole number.");
            }

        }
    }

    class ThisIsAJoke
    {
        public void Joke()
        {
            Console.WriteLine("What's the difference between a well dressed man on a tricycle, and a poorly dressed man on a unicycle?");
            Console.WriteLine("Attire.");
        }
    }

    // Put the Data_Type_Explanations stuff here
    class Data_Type_Explanations
    {
        public void DDD()
        {
            sbyte a = 1;
            //Minimum -128
            //Maximum 127
            byte b = 2;
            //Minimum 0
            //Maximum 255
            short c = 3;
            //Minimum -32,768
            //Maximum 32,767
            ushort d = 4;
            //Minimum 0
            //Maximum 65,535
            int e = 5;
            //Minimum -2,147,483,648
            //Maximum 2,147,483,647
            uint f = 6;
            //Minimum 0
            //Maximum 4,294,967,295
            long g = 7;
            //Minimum -9,223,372,036,854,775,808
            //Maximum 9,223,372,036,854,775,807
            ulong h = 8;
            //Minimum 0
            //Maximum 18,446,744,073,709,551,615
            char i = 'c';
            //Minimum one character
            //Maximum one character
            float j = 1.55F;
            //Minimum -3.4x10^38
            //Maximum 3.4x10^38
            double k = 1.22;
            //Minimum(+/-)5.0x10^-324
            //Maximum(+/-)1.7x10^308
            decimal l = 1.44m;
            //Minimum -7.9x10^28
            //Maximum 7.9x10^28
            bool m = true;
            //True and False
            string n = "Fun Times";

            if (m == true)
            {
                Console.WriteLine("The sbyte is: {0}", a);
                Console.WriteLine("The byte is: {0}", b);
                Console.WriteLine("The short is: {0}", c);
                Console.WriteLine("The ushort is: {0}", d);
                Console.WriteLine("The int is: {0}", e);
                Console.WriteLine("The uint is: {0}", f);
                Console.WriteLine("The long is: {0}", g);
                Console.WriteLine("The ulong is: {0}", h);
                Console.WriteLine("The char is: {0}", i);
                Console.WriteLine("The float is: {0}", j);
                Console.WriteLine("The double is: {0}", k);
                Console.WriteLine("The decimal is: {0}", l);
                Console.WriteLine(n);
                Console.WriteLine(n.ToUpper());
                Console.WriteLine(n.ToLower());
            }
        }
    }

    // Don't forget the following (detailed in the Word .DOC that describes this exercise):



    //answers here on what values can be stored in the given data types: 
    //sbyte
    //minimum -128
    //maximum 127
    //byte
    //minimum 0
    //maximum 255
    //short
    //minimum -32,768
    //maximum 32,767
    //ushort
    //minimum 0
    //maximum 65,535
    //int
    //minimum -2,147,483,648
    //maximum 2,147,483,647
    //uint
    //minimum 0
    //maximum 4,294,967,295
    //long
    //minimum -9,223,372,036,854,775,808
    //maximum 9,223,372,036,854,775,807
    //ulong
    //minimum 0
    //maximum 18,446,744,073,709,551,615
    //char
    //minimum one character
    //maximum one character
    //float
    //minimum -3.4x10^38
    //maximum 3.4x10^38
    //double
    //minimum(+/-)5.0x10^-324
    //maximum(+/-)1.7x10^308
    //decimal
    //minimum -7.9x10^28
    //maximum 7.9x10^28
    //bool
    //true and false
    //string
    //strings

    //answer for what the u prefix means:
    //The u prefix doesn't affect the Data Type's absolute sum value, but instead shifts the range to only be utilizing positive values in ranges

    //answer for what the difference between float/double/decimal are:
    //Their bit sizes, digit accuracy, and literal formatting when initializing them in code.

    // What is a typical usage of decimal instead of float/double?
    //For the situation when you want to use a Decimal over a Float or a Double is when you want more precision in your numbers. For example, finance. Due to the significant digit differences correlated with their bit size.

    //answers for the 5 questions:
    //1. What variable type(s) would you use to store the number of students enrolled in a class at Cascadia Community College? Keep in mind that classes are limited to 30 students (48 for a ‘learning community’ class).
    //Integer

    //2.What variable type(s) would you use to store a student’s current tuition balance? Keep in mind that a student may not have paid their tuition yet (in which case the balance is a positive number), or they may have overpaid (in which case the balance will be a negative number), and that the balance is always in US dollars.
    //Decimal

    //3.What variable type(s) would you use to store the result of a scientific computation? Keep in mind that having extremely precise results is very important, and that occasionally having to deal with round-off errors is ok, as long as the data has the maximum number of digits of precision in other cases.
    //Float

    //4.What variable type(s) would you use to store a Cascadia Student ID (SID)? If you need an example of a SID, you can check the back of your Cascadia student ID card – it’s the number that starts with “9600…”, and is 9 digits long.
    //Integer

    //5.Let’s say you’ve written a program that will send email to all of the students in a given class at Cascadia. What variable type(s) would you use to store, in memory, one of two values: one value will mean that your program’s attempt at emailing all of the students in a class succeeded, the other value will mean that at least one of the emails was not successfully sent.
    //Boolean

    //6.Let’s say you’ve written a program that will send email to all of the students in a given class at Cascadia. Let’s say that you want to reuse this program for multiple classes, so you decide to store the full name of the class in a variable. What variable type(s) would you use to store this information?
    //Some examples of class names:
    //  I: BIT 142
    //  II: ENG 101
    //  III: MATH 141
    //  IV: etc

    //String Arrays
}
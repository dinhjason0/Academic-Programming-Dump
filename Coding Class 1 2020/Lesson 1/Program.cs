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

            HelloPrinter ElectricBoogaloo1 = new HelloPrinter();
            ElectricBoogaloo1.RunExercise();

            NumberPrinter ElectricBoogaloo2 = new NumberPrinter();
            ElectricBoogaloo2.printTwoNumbers();

            Data_Type_Explanations ElectricBoo = new Data_Type_Explanations();
            ElectricBoo.RunExercise();
        }
    }

    class Basic_Console_IO
    {
        public void RunExercise()
        {
            Console.WriteLine("Hello, Where you @?");
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
            }
        }
    }

    class Comparison_Operators
    {
        public void RunExercise()
        {
            Console.WriteLine("Get 2 integers & store them, then compare them using <, <=, etc, etc");
        }
    }

    class Define_An_Instance_Method
    {
        public void RunExercise()
        {
            {
                Console.WriteLine("Hello World, from the Instance Method Exercise ");
            }

        }
    }

    class HelloPrinter
    {
        public void RunExercise()
        {
            {
                Console.WriteLine("WHERE. DO?");
            }
        }
    }

    class NumberPrinter
    {
        public void printTwoNumbers()
        {
            {
                Console.WriteLine("Give me a number!: ");
                String MyCodeIsAwful = Console.ReadLine();
                int First = int.Parse(MyCodeIsAwful);
                Console.WriteLine("Give me another number!: ");
                MyCodeIsAwful = Console.ReadLine();
                int Second = int.Parse(MyCodeIsAwful);
                Console.WriteLine(First + " " + Second);
            }
        }
    }
    // Put the Data_Type_Explanations stuff here

    // Don't forget the following (detailed in the Word .DOC that describes this exercise):

    //answers here on what values can be stored in the given data types:

    //answer for what the u prefix means:

    //answer for what the difference between float/double/decimal are:
    // What is a typical usage of decimal instead of float/double?

    //answers for the 5 questions:

    class Data_Type_Explanations
        {
        public void RunExercise()
            {
                String ElectricConfusionaloo = "Buenos Dias?";
                Console.WriteLine(ElectricConfusionaloo);
                Console.WriteLine(ElectricConfusionaloo.ToUpper());
                Console.WriteLine(ElectricConfusionaloo.ToLower());
                
                sbyte x = 3; //Can store from -128 to +127
                Console.WriteLine("Value of x is: " + x);
                byte y = 2; //Can store from 0 to 255
                Console.WriteLine("Value of y is: " + y);
                short h = -2000; //Can store from -32,768 to 32,767
                Console.WriteLine("Value of h is: " + h);
                ushort o = 40000; //Can store from 0 to 65,535
                //Took all of the space in itself byte-wise and used it to extend its positive integers is what the 'u' prefix means
                //That or unsigned
                Console.WriteLine("Value of o is: " + o);
                int q = 400; //Can store from -2,147,483,648 to 2,147,483,647
                Console.WriteLine("Value of q is: " + q);
                uint w = 33333; //Can store from 0 to 4,294,967,295
                Console.WriteLine("Value of w is: " + w);
                long g = 4444444444444444444; //Can store -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
                Console.WriteLine("Value of g is: " + g);
                ulong pp = 33333333333333; //Can store from 0 to 18,446,774,073,709,551,615
                Console.WriteLine("Value of pp is: " + pp);
            }
        }

}

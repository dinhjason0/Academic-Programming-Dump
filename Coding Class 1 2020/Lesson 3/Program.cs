//JASON TRUONG
//BIT 142
//A1.0

using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Simple_Loops sl = new Simple_Loops();
            sl.RunExercise();

            // Break_Continue_Keywords bck = new Break_Continue_Keywords();
            // bck.RunExercise();

            // Compound_Operators co = new Compound_Operators();
            // co.RunExercise();

            // Increment_Decrement id = new Increment_Decrement();
            // id.RunExercise();

            // Integer_Vs_Real_Division ivrd = new Integer_Vs_Real_Division();
            // ivrd.RunExercise();

            // Modulus_Operator mo = new Modulus_Operator();
            // mo.RunExercise();

            // Fahrenheit_To_Celsius ftc = new Fahrenheit_To_Celsius();
            // ftc.RunExercise();

            RandomNumbersBasic rnb = new RandomNumbersBasic();
            rnb.RunExercise();

            // Sentinel_Controlled_Loop scl = new Sentinel_Controlled_Loop();
            // scl.RunExercise();

            Print_A_Range_Of_Numbers paron = new Print_A_Range_Of_Numbers();
            paron.RunExercise();

            // Nested_Loops_Rectangles nlr = new Nested_Loops_Rectangles();
            // nlr.RunExercise();

            Nested_Loops_Hollow_Rectangles nlhr = new Nested_Loops_Hollow_Rectangles();
            nlhr.RunExercise();

            Built_In_Math_Functions bimf = new Built_In_Math_Functions();
            bimf.RunExercise();
        }
    }


    class Simple_Loops
    {
        public void RunExercise()
        {
        }
    }

    class Break_Continue_Keywords
    {
        public void RunExercise()
        {

        }
    }

    class Compound_Operators
    {
        public void RunExercise()
        {
        }
    }

    class Increment_Decrement
    {
        public void RunExercise()
        {
            int num = 0;
            // ++ before num is 'prefix' 
            while (++num < 10)
                Console.WriteLine("Num: {0}", num);

            num = 0;
            // ++ after num is 'postfix' 
            while (num++ < 10)
                Console.WriteLine("Num: {0}", num);

            num = 10;
            // -- before num is 'prefix' 
            while (--num > 0)
                Console.WriteLine("Num: {0}", num);

            num = 10;
            // -- after num is 'postfix' 
            while (num-- < 10)
                Console.WriteLine("Num: {0}", num);
        }
    }

    class Integer_Vs_Real_Division
    {
        public void RunExercise()
        {
        }
    }

    class Modulus_Operator
    {
        public void RunExercise()
        {
        }
    }

    class Fahrenheit_To_Celsius
    {
        public void RunExercise()
        {
        }
    }

    class RandomNumbersBasic
    {
        Random dieToRoll = new Random();

        public void RunExercise()
        {
            // First, generate (and print) a random number between 1 & 6
            //      (including, potentially, 1 or 6 as possible output)

            Console.WriteLine("Look! A number between 1 - 6 : {0}", (dieToRoll.Next() % 6 + 1));
            int i = 0;
            for (; i < 6; i++)
            {
                //dieToRoll = new Random();
                Console.WriteLine("Look, again!: {0}", (dieToRoll.Next() % 6 + 1));
            }
            //Putting the dieToRoll IN the loop gives me the same number 6 times because of the internal
            //clock sets runs everything in the same millisecond, so the number we're getting thrown back
            //is all the same number in the loop cause its all done in that same millisecond

            int x = 0, y = 0, z = 0, a = 0, b = 0, c = 0, d = 0;

            do
            {
                x = dieToRoll.Next(1, 7);
                switch (x)
                {
                    case 1:
                        y++;
                        break;

                    case 2:
                        z++;
                        break;

                    case 3:
                        a++;
                        break;

                    case 4:
                        b++;
                        break;

                    case 5:
                        c++;
                        break;

                    case 6:
                        d++;
                        break;
                }
                ++i;
            }while(i < 10006);

            Console.WriteLine("Generated 1 a total of {0} times", y);
            Console.WriteLine("Generated 2 a total of {0} times", z);
            Console.WriteLine("Generated 3 a total of {0} times", a);
            Console.WriteLine("Generated 4 a total of {0} times", b);
            Console.WriteLine("Generated 5 a total of {0} times", c);
            Console.WriteLine("Generated 6 a total of {0} times", d);

        }

            // Now, call dieToRoll.Next() lots of times,
            // as described in the exercise

        
        
    }

    class Sentinel_Controlled_Loop
    {
        public void RunExercise()
        {
        }
    }

    class Print_A_Range_Of_Numbers
    {
        public void RunExercise()
        {
            int key = 2;
            while (key != 1)
                {
                    Console.WriteLine("Do you want to quit (1), or print numbers (2) ?");
                    key = int.Parse(Console.ReadLine());
                    if (key != 1)
                    {
                        Console.WriteLine("Do you want to print even (1) or odd (2) numbers ?");
                        String set = Console.ReadLine();
                        if (0 == String.Compare(set, "2", true))
                            {
                                Console.WriteLine("Lowest Number? ");
                                int ay = int.Parse(Console.ReadLine());
                                Console.WriteLine("Highest Number?");
                                int by = int.Parse(Console.ReadLine());
                                Console.WriteLine("Numbers: ");
                                for (;ay <= by;ay++)
                                    {
                                        if ((ay%2) != 0)
                                        Console.Write(ay + " ");
                                    }
                                Console.WriteLine();
                            }
                        else if (0 == String.Compare(set, "1", true))
                            {
                                Console.WriteLine("Lowest Number? ");
                                int ay = int.Parse(Console.ReadLine());
                                Console.WriteLine("Highest Number?");
                                int by = int.Parse(Console.ReadLine());
                                Console.WriteLine("Numbers: ");
                                for (;ay <= by;ay++)
                                    {
                                        if ((ay%2) == 0)
                                        Console.Write(ay + " ");
                                    }
                                Console.WriteLine();
                            }
                        else Console.WriteLine("WELL THATS NOT A 1 OR A TWO, TRY AGAIN~!");
                    }
                    else
                        Console.WriteLine("Have a nice day!");
                }
        }
    }

    class Nested_Loops_Rectangles
    {
        public void RunExercise()
        {
        }
    }

    class Nested_Loops_Hollow_Rectangles
    {
        public void RunExercise()
        {
            Console.WriteLine("Give me a number for the width of the rectangle!: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("How many rows should the tall be on the rectangle?: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                if (i == 0 || i == (b-1))
                {
                    for (int o = 0; o < a; o++)
                    {
                        Console.Write("*");
                    }
                }
                else if(i >= 1 || i <= (b-2))
                {
                    for (int o = 0; o < a; o++)
                    {
                        if (o == 0)
                        {
                            Console.Write("*");
                        }
                        if (o == a-1)
                        {
                            Console.Write("*");
                        }
                        if (o != 0 && o != a-1)
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }

        }
    }

    class Built_In_Math_Functions
    {
        public void RunExercise()
        {
            Console.WriteLine("Give me a base number: ");
            double v = double.Parse(Console.ReadLine());
            Console.WriteLine("Give me an exponent to attach the base with: ");
            double r = double.Parse(Console.ReadLine());
            Pow(v, r);

            Console.WriteLine("Give me a number to take the square root of: ");
            v = double.Parse(Console.ReadLine());
            Sqrt(v);

            Console.WriteLine("Give me a number to give it a value of sin: ");
            v = double.Parse(Console.ReadLine());
            Sin(v);

            Console.WriteLine("Give me a number to give it a value of cos: ");
            v = double.Parse(Console.ReadLine());
            Cos(v);
        }

        public void Pow(double a, double b)
        {
            Console.WriteLine("Your number is: {0}", Math.Pow(a, b));
        }

        public void Sqrt(double a)
        {
            Console.WriteLine("Your number is: {0}", Math.Sqrt(a));
        }

        public void Sin(double a)
        {
            Console.WriteLine("Your value of Sin is: {0}", Math.Sin(a));
        }

        public void Cos(double a)
        {
            Console.WriteLine("Your value of Cos is: {0}", Math.Cos(a));
        }
    }
}

using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Simple_Loops sl = new Simple_Loops();
            sl.RunExercise();

            Break_Continue_Keywords bck = new Break_Continue_Keywords();
            bck.RunExercise();

            Compound_Operators co = new Compound_Operators();
            co.RunExercise();

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

            Sentinel_Controlled_Loop scl = new Sentinel_Controlled_Loop();
            scl.RunExercise();

            Print_A_Range_Of_Numbers paron = new Print_A_Range_Of_Numbers();
            paron.RunExercise();

            Nested_Loops_Rectangles nlr = new Nested_Loops_Rectangles();
            nlr.RunExercise();

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
            Console.Write("How many stars do you want to see printed at once?: ");
            int i = 0;
            int userinput; 
            Int32.TryParse(Console.ReadLine(), out userinput);
            while (i < userinput)
            {
                Console.Write("*");
                i++;
            }
            Console.WriteLine(" While-loop \n");
            for(i = 0; i < userinput; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" For-loop \n");
            i = 0;
            do
            {
                Console.Write("*");
                i++;
            }
            while (i < userinput);
            Console.WriteLine(" Do-While loop \n");
        }
    }

    class Break_Continue_Keywords
    {
        public void RunExercise()
        {
            Console.Write("Give me a number that's more than 9. You're going to guess the secret number, you have 20 guesses: ");
            int n = 0;
            int numberofguesses = 1;
            String runningGag = "";
            int i = 0;
            Int32.TryParse(Console.ReadLine(), out n);
            do
            {
                if (n < 10)
                {
                    Console.WriteLine("Please type a number more than 9");
                    Console.Write("Please try again: ");
                    Int32.TryParse(Console.ReadLine(), out n);
                    continue;
                }
                if (n == 201 || numberofguesses >= 20)
                {
                    if (n == 201)
                    {
                        Console.WriteLine("YOU FOUND THE MAGIC NUMBER!!");
                        if (numberofguesses == 1)
                        Console.WriteLine("IN ONE GUESS TOO!!! THAT'S AMAZING!!!");
                        else
                        Console.WriteLine("In {0} guesses, you found the number! Those guesses were: {1}", numberofguesses, runningGag);
                    }
                    if (numberofguesses == 20 && n != 201)
                    Console.WriteLine("Sorry, you had used all 20 of your guesses, your guesses were: {0}", runningGag);
                    break;
                }
                else
                {
                    runningGag += n + " ";
                    Console.Write("Please try again: ");
                    Int32.TryParse(Console.ReadLine(), out n);
                    numberofguesses++;
                    continue;
                }
            } while (true);
        }
    }

    class Compound_Operators
    {
        public void RunExercise()
        {
            Console.WriteLine("Compound_Operators");
            int num = 400;
            Console.WriteLine(num += 2);
            Console.WriteLine(num -= 2);
            Console.WriteLine(num *= 2);
            Console.WriteLine(num /= 2);
            Console.WriteLine(num %= 2);
            // ++ before num is 'prefix'
            num = 0;
            while (++num < 10)
                Console.WriteLine("Num: {0}", num);


            // ++ after num is 'postfix'
            num = 0;
            while (num++ < 10)
                Console.WriteLine("Num: {0}", num);

            // -- before num is 'prefix'
            num = 10;
            while (--num > 0)
                Console.WriteLine("Num: {0}", num);

            // -- after num is 'postfix'
            num = 10;
            while (num-- > 0)
                Console.WriteLine("Num: {0}", num);
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
        public void RunExercise()
        {
            Random dieToRoll = new Random();
            int dice = (dieToRoll.Next() % 5) + 1;
            //dieToRoll generates a new random, with an empty set of parenthesis
            //Random generates a new number at random between the digits 0 and 2.1billion; influenced by the range limit of the data-value in question
            //In this case its Integer
            //Integer is modular 5 to be reduced down to a range between 0 and 5, then added to 1 to become a range of 1-6.
            int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0;
            for (int i = 0; i < 100000; i++)
            {
                dice = ((dieToRoll.Next() % 6) + 1);
                switch (dice)
                {
                    case 1:
                        count1++;
                        break;
                    case 2:
                        count2++;
                        break;
                    case 3:
                        count3++;
                        break;
                    case 4:
                        count4++;
                        break;
                    case 5:
                        count5++;
                        break;
                    case 6:
                        count6++;
                        break;
                }
            }
            Console.WriteLine("Generated 1 a total of {0} times", count1);
            Console.WriteLine("Generated 2 a total of {0} times", count2);
            Console.WriteLine("Generated 3 a total of {0} times", count3);
            Console.WriteLine("Generated 4 a total of {0} times", count4);
            Console.WriteLine("Generated 5 a total of {0} times", count5);
            Console.WriteLine("Generated 6 a total of {0} times", count6);
            // Now, call dieToRoll.Next() lots of times,
            // as described in the exercise
        }
    }

    class Sentinel_Controlled_Loop
    {
        public void RunExercise()
        {
            Console.WriteLine("Welcome to NumberAverager!");
            int n = 0;
            double e = 0;
            int o = 0;
            while (true)
            {
                Console.Write("What is your next number? (Type -1 to exit) ");
                Int32.TryParse(Console.ReadLine(), out n);
                if (n == -1)
                break;
                e += n;
                o++;
            }
            Console.WriteLine("The average of your number is: {0}", e/o);
        }
    }

    class Print_A_Range_Of_Numbers
    {
        public void RunExercise()
        {
            Console.WriteLine("Greetings, User!");
            Console.WriteLine("Welcome to NumberPrinter!");
            int low, high, input;
            do
            {
                Console.Write("Do you want to quit (1), or print numbers (2) ? ");
                Int32.TryParse(Console.ReadLine(), out input);
                switch (input)
                {
                    case 1:
                        break;

                    case 2:
                        {
                            Console.Write("Do you want to print even (1) or odd (2) numbers? ");
                            Int32.TryParse(Console.ReadLine(), out input);
                            switch (input)
                            {
                                case 1:
                                    Console.Write("Lowest number? ");
                                    Int32.TryParse(Console.ReadLine(), out low);
                                    Console.Write("Highest number? ");
                                    Int32.TryParse(Console.ReadLine(), out high);
                                    if (low > high)
                                    {
                                        Console.WriteLine("Error!: Lowest number is larger than Highest number");
                                    }
                                    else
                                    {
                                        Console.Write("Numbers: ");
                                        for (int i = low; i <= high; i++)
                                        {
                                            if (i % 2 == 0)
                                                Console.Write("{0} ", i);
                                        }
                                    }
                                    Console.WriteLine();
                                    input = 0;
                                    break;
                                case 2:
                                    Console.Write("Lowest number? ");
                                    Int32.TryParse(Console.ReadLine(), out low);
                                    Console.Write("Highest number? ");
                                    Int32.TryParse(Console.ReadLine(), out high);
                                    if (low > high)
                                    {
                                        Console.WriteLine("Error!: Lowest number is larger than Highest number");
                                    }
                                    else
                                    {
                                        Console.Write("Numbers: ");
                                        for (int i = low; i <= high; i++)
                                        {
                                            if (i % 2 != 0)
                                                Console.Write("{0} ", i);
                                        }
                                    }
                                    Console.WriteLine();
                                    break;
                                default:
                                    Console.WriteLine("Please make a valid input!");
                                    break;
                            }
                        }
                        break;

                    default:
                        if (input != 1 || input != 2)
                        {
                            Console.WriteLine("Please input a valid input.");
                            Int32.TryParse(Console.ReadLine(), out input);
                        }
                        break;
                }
                if (input == 1)
                {
                    Console.WriteLine("Have a nice day!");
                    break;
                }
            } while (true);
        }
    }

    class Nested_Loops_Rectangles
    {
        public void RunExercise()
        {
            int width = 0, height = 0;
            Console.WriteLine("Welcome to RectanglePrinter!");
            Console.Write("How many columns wide should the rectangle be? ");
            Int32.TryParse(Console.ReadLine(), out width);
            Console.Write("How many rows tall should the rectangle be? ");
            Int32.TryParse(Console.ReadLine(), out height);
            for (int i = 0; i < height; i++)
            {
                for (int e = 0; e < width; e++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class Nested_Loops_Hollow_Rectangles
    {
        public void RunExercise()
        {
            int width = 0, height = 0;
            Console.WriteLine("Welcome to HollowRectanglePrinter!");
            Console.Write("How many columns wide should the rectangle be? ");
            Int32.TryParse(Console.ReadLine(), out width);
            Console.Write("How many rows tall should the rectangle be? ");
            Int32.TryParse(Console.ReadLine(), out height);
            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == height-1)
                {
                    int e = 0;
                    while (e < width)
                    {
                        e++;
                        Console.Write("*");
                    }
                }
                else
                for (int e = 0; e < width; e++)
                {
                    if (e == 0 || e == width - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }

    class Built_In_Math_Functions
    {
        public void RunExercise()
        {
            Console.WriteLine("Greetings, User!");
            Console.WriteLine("Welcome to Built_In_Math Machine");
            Ask();
        }

        public void Ask()
        {
            double inputa, inputb;
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            Console.Write("Give me a base, we're going to raise this to an exponent after: ");
                            Double.TryParse(Console.ReadLine(), out inputa);
                            Console.Write("Give me an exponent to raise that base to: ");
                            Double.TryParse(Console.ReadLine(), out inputb);
                            Console.WriteLine("{0} to the {1} power is, {2}", inputa, inputb, Math.Pow(inputa, inputb));
                        }
                        break;

                    case 1:
                        {
                            Console.Write("Give me a number to take the square root of it: ");
                            Double.TryParse(Console.ReadLine(), out inputa);
                            Console.WriteLine("The square root of {0} is {1}", inputa, Math.Sqrt(inputa));
                        }
                        break;

                    case 2:
                        {
                            Console.Write("Give me a number to pull a function of Sin(x) through it, you're giving us x: ");
                            Double.TryParse(Console.ReadLine(), out inputa);
                            Console.WriteLine("Sin({0}) equals to {1}", inputa, Math.Sin(inputa));
                        }
                        break;

                    case 3:
                        {
                            Console.Write("Give me a number to pull a function of Cos(x) through it, you're giving us x: ");
                            Double.TryParse(Console.ReadLine(), out inputa);
                            Console.WriteLine("Cos({0}) equals to {1}", inputa, Math.Cos(inputa));
                        }
                        break;
                }
            }
        }
    }
}

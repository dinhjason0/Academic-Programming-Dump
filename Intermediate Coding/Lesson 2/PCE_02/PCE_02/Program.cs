//JASON TRUONG

using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Conditional_Statements cs = new Conditional_Statements();
            cs.RunExercise();

            Comparison_Operators co = new Comparison_Operators();
            co.RunExercise();

            IO_Operators ioo = new IO_Operators();
            ioo.RunExercise();

            Integer_Vs_Real_Division ivrd = new Integer_Vs_Real_Division();
            ivrd.RunExercise();

            // Clearly, you will need to uncomment these to test them...
            Modulus_Operator mo = new Modulus_Operator();
            mo.RunExercise();

            Fahrenheit_To_Celsius ftc = new Fahrenheit_To_Celsius();
            ftc.RunExercise();

            String_Basics SB = new String_Basics();
            SB.RunExercise();
        }
    }

    class Conditional_Statements
    {
        public void RunExercise()
        {
            Console.WriteLine("About to do the \"Conditional Statements\" exercise");
            Conditional_Methods cm = new Conditional_Methods();
            cm.UsingIf();
            cm.UsingIfElse();
            cm.UsingSwitch();
        }
    }

    class Comparison_Operators
    {
        public void RunExercise()
        {
            int x = 10;
            int y = 11;
            Console.WriteLine("The integer for x is: {0}\nThe integer for y is {1}", x, y);
            Console.WriteLine("Get 2 integers & store them, then compare them using <, <=, etc, etc");
            if (x < y)
                Console.WriteLine("X is less than Y by {0}", y - x);
            if (x <= y)
                Console.WriteLine("{0} is less than and/or equal to {1}", x, y);
            if (x > y)
                Console.WriteLine("{0} is more than {1}", x, y);
            if (x >= y)
                Console.WriteLine("{0} is more than and/or equal to {1}", y, x);
            if (x == y)
                Console.WriteLine("{0} is equal to {1}", x, y);
            if (x != y)
                Console.WriteLine("{0} is not equal to {1}", x, y);
        }
    }


    class IO_Operators
    {
        public void RunExercise()
        {
            string szInput;
            int x;
            int y;
            Console.Write("Give a number: ");
            szInput = Console.ReadLine();
            Int32.TryParse(szInput, out x);
            Console.Write("Type another number: ");
            szInput = Console.ReadLine();
            Int32.TryParse(szInput, out y);
            if (x - 5 <= y && y <= x + 5)
                Console.WriteLine("{0} and {1} are within 5 integers of each other.", x, y);
            else
                Console.WriteLine("{0} and {1} are not within 5 integers of each other.", x, y);
        }
    }

    class Conditional_Methods
    {
        public string szInput;
        public int x;
        public void UsingIf()
        {
            Console.Write("What was your score on the test?: ");
            szInput = Console.ReadLine();
            Int32.TryParse(szInput, out x);
            if (x < 0)
                Console.WriteLine("Negative numbers can't be allowed, unless you really did THAT bad...");
            if (x == 0)
                Console.WriteLine("You need to talk to the professor immediately");
            if (x == 1)
                Console.WriteLine("You need to study a lot more!");
            if (x >= 2 && x <= 4)
                Console.WriteLine("If you keep working at this, you'll do better!");
            if (x == 5 || x == 6)
                Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
            if (x == 7 || x == 8)
                Console.WriteLine("Nice job, but don't let yourself slack!");
            if (x == 9)
                Console.WriteLine("Very nice job - keep up the good work!");
            if (x == 10)
                Console.WriteLine("Perfect!");
            if (x > 10)
                Console.WriteLine("I don't think you are able to get a score like that");
        }

        public void UsingIfElse()
        {
            Console.Write("What was your score on the test?: ");
            szInput = Console.ReadLine();
            Int32.TryParse(szInput, out x);
            if (x < 0)
                Console.WriteLine("Negative numbers can't be allowed, unless you really did THAT bad...");
            else if (x == 0)
                Console.WriteLine("You need to talk to the professor immediately");
            else if (x == 1)
                Console.WriteLine("You need to study a lot more!");
            else if (x >= 2 && x <= 4)
                Console.WriteLine("If you keep working at this, you'll do better!");
            else if (x == 5 || x == 6)
                Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
            else if (x == 7 || x == 8)
                Console.WriteLine("Nice job, but don't let yourself slack!");
            else if (x == 9)
                Console.WriteLine("Very nice job - keep up the good work!");
            else if (x == 10)
                Console.WriteLine("Perfect!");
            else
                Console.WriteLine("I don't think you can get a score that high");
        }
        public void UsingSwitch()
        {
            Console.Write("What was your score on the test?: ");
            szInput = Console.ReadLine();
            Int32.TryParse(szInput, out x);
            switch (x)
            {
                case 0:
                    Console.WriteLine("You need to talk to the professor immediately!");
                    break;
                case 1:
                    Console.WriteLine("You need to study a lot more!");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("If you keep working at this, you'll do better!");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Nice job, but don't let yourself slack!");
                    break;
                case 9:
                    Console.WriteLine("Very nice job - keep up the good work!");
                    break;
                case 10:
                    Console.WriteLine("Perfect!");
                    break;
                default:
                    if (x < 0)
                        Console.WriteLine("Wait.. how did you get a score THAT bad?");
                    if (x > 10)
                        Console.WriteLine("A score that high shouldn't be plausible?!");
                    break;
            }
        }
    }

    class Integer_Vs_Real_Division
    {
        public void RunExercise()
        {
            int x = 4;
            int y = 7;
            Console.WriteLine("{0} is a result of integer division", x/y);
            Console.WriteLine("{0} is a result of double division", x / (double)y);
            Console.WriteLine("{0} is a result of floating point division", x / (float)y);
        }
    }

    class Modulus_Operator
    {
        public void RunExercise()
        {
            int x = 10, y = 4;
            double z = 10;
            Console.WriteLine(x % y);
            Console.WriteLine(y % x);
            Console.WriteLine(x % x);
            Console.WriteLine(x % 2);
            Console.WriteLine(x % 2.5);
            Console.WriteLine((x + z) % y);
        }
    }

    class Fahrenheit_To_Celsius
    {
        public void RunExercise()
        {
            double fivenine = (5.0 / 9.0);
            Console.Write("What temperature is it over where you are? In farenheits please: ");
            String szInput = Console.ReadLine();
            double x;
            Double.TryParse(szInput, out x);
            Console.WriteLine("The temperature of your locale in farenheit is {0} degrees", x);
            Console.WriteLine("The temperature of your locale in celsius is: {0}", fivenine * (x - 32));
        }
    }

    class Logical_Operators
    {
        // Your answer goes here,in a comment like this one

        // Side-Note: Notice that this class has NO methods, and that it still compiles :)
        int x = 5, y = 2, z = 10;
        //y< 1 || y> 1

            //If y is an integer, can you find a better way to express the above?
            //When looking for a different/better way to express this, think when the expression will be true, and when it won't. 
            //Once you've got that figured out, think about how you might explain it to a friend – what's a quick, 1 sentence summary of when the expression evaluates to true? 
            //Lastly, think about how you would write that in C#.
            //When handing your answer to this part, put in something that clearly states what your new, simplified expression(in C# is)
                
                // y != 1
                // You would just have to check if y isn't 1.


        //y < 2 || x > 4
        	// First annotate everything with their data types
	            //y [int] < 2 [int] || x [int] > 4 [int]
	
	        // < and > have the same precedence, so
	        // the left-to-right associativity of the operators
	        // tells us that < goes first ,
	        // so substitute the value of x
	            // 2 [int] < 2 [int] && 5 [int] > 4 [int]
	
	        // 2 is not less than 2 – it's false
	            // false [bool] || x [int] > 4 [int]
	
	        // > goes next, so substitute the value of x
	            // false [bool] && 5 [int] > 4 [int]
	
	        // 5 is more than 4, therefore it's true
	            // false [bool] && true [bool]
	
	        // || is the only one left
	        // false OR true is true, so we get:
	            // true [bool]


        //z > 8 || y < 3
            // First annotate everything with their data types
	            //z [int] > 8 [int] || y [int] < 3 [int]
	
	        // > and < have the same precedence, so
	        // the left-to-right associativity of the operators
	        // tells us that > goes first ,
	        // so substitute the value of z
	            // 10 [int] > 8 [int] && y [int] < 3 [int]
	
	        // 10 is more than 8 – it's true
	            // true [bool] || y [int] < 3 [int]
	
	        // < goes next, so substitute the value of y
	            // true [bool] || 2 [int] < 3 [int]
	
	        // 2 is less than 3, therefore it's true
	            // false [bool] || true [bool]
	
	        // || is the only one left
	        // false OR true is true, so we get:
	            // true [bool]


        //!(z > 8)
            // First annotate everything with their data types
	            // !(z [int] > 8 [int])

            // > have precedence
            // Substitute the value of z
                // !(10 [int] > 8 [int])

            // 10 is more than 8 - it's true
                // !(true [bool])

            // last is !
            // Not [True] is false, so we get:
                // false [bool]


        //!(z > 8 || y< 3)
            // First annotate everything with their data types
	            //z [int] > 8 [int] || y [int] < 3 [int]

	        // > and < have the same precedence, so
	        // the left-to-right associativity of the operators
	        // tells us that > goes first ,
	        // so substitute the value of z
	            // !(10 [int] > 8 [int] && y [int] < 3 [int])

	        // 10 is more than 8 – it's true
	            // !(true [bool] || y [int] < 3 [int])
	
	        // < goes next, so substitute the value of y
	            // !(true [bool] || 2 [int] < 3 [int])
	
	        // 2 is less than 3, therefore it's true
	            // !(false [bool] || true [bool])
	
	        // || is next
	        // false OR true is true, so we get:
	            // !(true [bool])
            
            // Last is !
            // Not [True] is false - it is:
                // false [bool]


        //!(z > 4 && y == 2) || (z ==10 && y <= 3)
            // First annotate everything with their data types
	            // !(z [int] > 4 && y [int] == 2 [int]) || (z [int] == 10 [int] && y [int] <= 3 [int])

            // within the first parenthesis statement, > and == have equal precedence, so
            // the left-to-right associativity of the operators tell us that > goes first,
            // so substitute the value of z
                // !(10 [int] > 4 && y [int] == 2 [int]) || (z [int] == 10 [int] && y [int] <= 3 [int])
            
            // 10 is more than 4, its true
                // !(true [bool] && y [int] == 2 [int]) || (z [int] == 10 [int] && y [int] <= 3 [int])

            // == is next
            // so substite y
                // !(true [bool] && 2 [int] == 2 [int]) || (z [int] == 10 [int] && y [int] <= 3 [int])
            
            // 2 is equal to 2, so it is true
                // !(true [bool] && true [bool]) || (z [int] == 10 [int] && y [int] <= 3 [int])
            
            // next is &&
            // true and true is true
                // !(true [bool]) || (z [int] == 10 [int] && y [int] <= 3 [int])

            // last for the left side of the || is !
            // Not true is false
                // false [bool] || (z [int] == 10 [int] && y [int] <= 3 [int])

            // next is the right side
            // == and <= take equal precedence
            // left-to-right associativity of the operators tell us that == goes first
            // substitute z
                // false [bool] || (10 [int] == 10 [int] && y [int] <= 3 [int])

            // 10 equals 10 - its true
                // false [bool] || (true [bool] && y [int] <= 3 [int])
            
            // next is <=
            // subtitute y
                // false [bool] || (true [bool] && 2 [int] <= 3 [int])

            // 2 is less than or equal to 3
            // so it is true
                // false [bool] || (true [bool] && true [bool])

            // true and true is true
                // false [bool] || true [bool]

            // last is ||
            // false or true is true
                // true [bool]
            

        //y<z ^ z<x
            // First annotate everything with their data types
	            // y [int] < z [int] ^ z [int] < x [int]
            
            // < and < take equal precedence
            // left-to-right associativity of the operators tell us that the first < goes first
            // substitute y and z
                // 2 [int] < 10 [int] ^ z [int] < x [int]
            
            // next is <
            // 2 is less than 10, to it is true
                // true [bool] ^ z [int] < x [int]

            // next is the other <
            // substitute z and x
                // true [bool] ^ 10 [int] < 5 [int]

            // next is <
            // 10 is not less than 5, thus it is false
                // true [bool] ^ false [bool]

            // last is XOR ^
            // true and false is true, thus:
                // true [bool]

        //z<x ^ y<z
            // First annotate everything with their data types
	            // z [int] < x [int] ^ y [int] < z [int]
            
            // < and < take equal precedence
            // left-to-right associativity of the operators tell us that the first < goes first
            // substitute z and x
                // 10 [int] < 5 [int] ^ y [int] < z [int]
            
            // next is <
            // 10 is not less than 5, to it is false
                // false [bool] ^ y [int] < z [int]

            // next is the other <
            // substitute y and z
                // false [bool] ^ 2 [int] < 10 [int]

            // next is <
            // 2 is less than 10, thus it is true
                // false [bool] ^ true [bool]

            // last is XOR ^
            // false and true is true, thus:
                // true [bool]


        //10 < 20 ^ 20 < 30
            // First annotate everything with their data types
	            //10 [int] < 20 [int] ^ 20 [int] < 30 [int]

            // < and < take equal precedence
            // left-to-right associativity of the operators tell us that the first < goes first
                // 10 [int] < 20 [int] ^ 20 [int] < 30 [int]

            // 10 is less than 20; true
                // true [bool] ^ 20 [int] < 30 [int]

            // next is the other <
            // 20 is less than 30; true
                // true [bool] ^ true [bool]

            // last is XOR ^
            // true and true is false, thus:
                // false [bool]

        //20 == 10 ^ 20 < 10
            // First annotate everything with their data types
	            //20 [int] == 10 [int] ^ 20 [int] < 10 [int]

            // = and < take equal precedence
            // left-to-right associativity of the operators tell us that = goes first
                // 20 [int] = 10 [int] ^ 20 [int] < 10 [int]

            // 20 does not equal 10; false
                // false [bool] ^ 20 [int] < 10 [int]

            // next is the other <
            // 20 is not less than 10; false
                // false [bool] ^ false [bool]

            // last is XOR ^
            // false and false is false, thus:
                // false [bool]
    }

    class String_Basics
    {
        public void RunExercise()
        {

        }
    }
}
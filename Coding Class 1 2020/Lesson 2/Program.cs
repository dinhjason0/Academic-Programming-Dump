using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Conditional_Statements cs = new Conditional_Statements();
            cs.RunExercise();

            // Comparison_Operators co = new Comparison_Operators();
            // co.RunExercise();

            IO_Operators ioo = new IO_Operators();
            ioo.RunExercise();

            Integer_Vs_Real_Division ivrd = new Integer_Vs_Real_Division();
            ivrd.RunExercise();

            // Clearly, you will need to uncomment these to test them...
            Modulus_Operator mo = new Modulus_Operator();
            mo.RunExercise();

            Fahrenheit_To_Celsius ftc = new Fahrenheit_To_Celsius();
            ftc.RunExercise();

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
    }


    class Comparison_Operators
    {
        public void RunExercise()
        {
            Console.WriteLine("Get 2 integers & store them, then compare them using <, <=, etc, etc");
        }
    }


    class IO_Operators
    {
        public void RunExercise()
        {
            Console.WriteLine("Type in two numbers! ");
            String question_result = Console.ReadLine();
            int bob = int.Parse(question_result);
            Console.WriteLine("Again! ");
            question_result = Console.ReadLine();
            int bobbert = int.Parse(question_result);
                if (bob - bobbert >= -5 && bob - bobbert <= 5)
                {
                    Console.WriteLine(bob + " and " + bobbert + " are within 5 integers of each other.");
                }
                else
                    Console.WriteLine(bob + " and " + bobbert + " are NOT within 5 integers of each other.");
        }
    }

    class Conditional_Methods
    {
        public void UsingIf()
        {
            Console.Write("Hey! What was the number of questions you got correct on the quiz?: ");
            String question_result = Console.ReadLine();
            int bob = int.Parse(question_result);
            if (bob == 0)
                Console.WriteLine("You need to talk to the professor immediately!");
            if (bob == 1)
                Console.WriteLine("You need to study a lot more!");
            if (bob == 2 || bob == 3 || bob == 4)
                Console.WriteLine("If you keep working at this, you'll do better!");
            if (bob == 5 || bob == 6)
                Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you'll do even better!");
            if (bob == 7 || bob == 8)
                Console.WriteLine("Nice job, but don't let yourself slack!");
            if (bob == 9)
                Console.WriteLine("Very nice job - keep up the good work!");
            if (bob == 10)
                Console.WriteLine("Perfect!");
        }

        public void UsingIfElse()
        {
            Console.Write("Yo, Yo, Yo! Whatchu' got on dat quiz?: ");
            String question_result = Console.ReadLine();
            int bob = int.Parse(question_result);
            if (bob == 0)
                Console.WriteLine("You need to talk to the professor immediately!");
            else if (bob == 1)
                Console.WriteLine("You need to study a lot more!");
            else if (bob == 2 || bob == 3 || bob == 4)
                Console.WriteLine("If you keep working at this, you'll do better!");
            else if (bob == 5 || bob == 6)
                Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you'll do even better!");
            else if (bob == 7 || bob == 8)
                Console.WriteLine("Nice job, but don't let yourself slack!");
            else if (bob == 9)
                Console.WriteLine("Very nice job - keep up the good work!");
            else if (bob == 10)
                Console.WriteLine("Perfect!");
        }

        public void UsingSwitch()
        {
            Console.Write("Alright, the quiz is over! Hey, what did you get?: ");
            String question_result = Console.ReadLine();
            int bob = int.Parse(question_result);
            switch (bob)
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
                    Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure can do even better!");
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
            }

        }
    }

    class Integer_Vs_Real_Division
    {
        public void RunExercise()
        {
        int six = 6;
        int three = 3;
        int seven = 7;

        int six_three = six / three;
        int seven_three = seven / three;

        double bob = (double)six / three;
        float bobbert = (float)seven / three;

        Console.WriteLine(six_three + " " + seven_three + " " + bob + " " + bobbert);

        /*floats contain only 32 bits, the same size as an integer
         * so the float can't go down as many decimal places as the double
         * which is 7 to 16
         * loss of values is done because they're walking 64 bit to 32 bit, but not vice versa*/
        }
    }

    class Modulus_Operator
    {
        public void RunExercise()
        {
            int x = 3, y = 5, z = 10;
            Console.WriteLine(x % y);
            Console.WriteLine(y % x);
            Console.WriteLine(y % y);
            Console.WriteLine(y % z);
            Console.WriteLine((x + z) % y);
            //The best way to explain this in lay terms
            //Just do long division, and take the first number
            //That will go underneath the hood
            //and then the second number is what you're dividing it with
            //Anything that comes in the remainder is your modulus result
        }
    }

    class Fahrenheit_To_Celsius
    {
        public void RunExercise()
        {
        Console.WriteLine("Whats the temperature in farenheit? ");
        String question_answer = Console.ReadLine();
        int jeff = int.Parse(question_answer);
        double celsius = ((5 / 9) * (double)(jeff - 32));
        Console.WriteLine("Your temperature for the evening is " + celsius + "celsius");
        }
    }

    class Logical_Operators
    {
        int x = 5;
        int y = 2;
        int z = 10;

        y < 1 || y > 1
        //first annotate everything with their data types
        y [int] < 1 [int] || y [int] > 1 [int]
        // < and > have the same precedence in the or statement
        // so the left-to-right associativity of the operators
        // tell us that < goes first
        //substitute the value of y
        2 [int] < 1 [int] || y [int] > 1 [int]
        // with the first operator not true, it has to check if
        // the other operator is true or not
        // so moves onto the next operator and
        //substitutes the variable y
        false [bool] || 2 [int] > 1 [int]
        // one statement returned true
        false [bool] || true [bool]
        // the entire statement is true, so thus it returns true
        // because 2 is greater than 1
        true [bool]


        y < 2 || x > 4
        //first annotate everything with their data types
        y [int] < 2 [int] || x [int] > 4 [int]
        // < and > have the same precendece
        // left-to-right associativity
        // < goes first
        // substitute y
        2 [int] < 2 [int] || x [int] > 4 [int]
        // with the first operator not true
        // go further into the second operator
        // substitute x
        false [bool] || 5 [int] > 4 [int]
        // one statement returned true
        false [bool] || true [bool]
        // the entire statement is true, so thus it returns true
        // because 5 is greater than 4
        true [bool]

        z > 8 || y < 3
        //first annotate everything with their data types
        z [int] > 8 [int] || y [int] < 3 [int]
        // > and < have equal precedence
        // left-to-right associativity
        // > goes first
        // substitute z
        10 [int] > 8 [int] || y [int] < 3 [int]
        // first statement is true
        true [bool] || y [int] < 3 [int]
        // entire statement is true
        true [bool]


        // Your answer goes here,in a comment like this one

        // Side-Note: Notice that this class has NO methods, and that it still compiles :)
    }
}
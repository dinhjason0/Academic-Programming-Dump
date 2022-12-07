using System;

namespace PCE_StarterProject
{
	class Program
	{
		static void Main(string[] args)
		{
			Basic_Parameters bp = new Basic_Parameters();
			bp.RunExercise();

			Number_Printing_With_Parameters pnwp = new Number_Printing_With_Parameters();
			pnwp.RunExercise();

			Return_Values rv = new Return_Values();
			rv.RunExercise();

			Testing_Randomness tr = new Testing_Randomness();
			tr.RunExercise();

			Square_Of_Numbers son = new Square_Of_Numbers();
			son.RunExercise();
			
			Square_Of_Numbers_Parameters_Return sonpr = new Square_Of_Numbers_Parameters_Return();
			sonpr.RunExercise();

			Detecting_Prime_Numbers dpn = new Detecting_Prime_Numbers();
			dpn.RunExercise();

			Array_Basics ab = new Array_Basics();
			ab.RunExercise();

			Array_Usage au = new Array_Usage();
			au.RunExercise();

			Using_Part_Of_An_Array upoaa = new Using_Part_Of_An_Array();
			upoaa.RunExercise();

			Array_Parameter ap = new Array_Parameter();
			ap.RunExercise();

			Returning_An_Array raa = new Returning_An_Array();
			raa.RunExercise();

			Fibonnaci_With_Array fwa = new Fibonnaci_With_Array();
			fwa.RunExercise();

			///////////////////////////////////////////////////////////////////

			// The following were used to demonstrate topics
			// on the various videos, but aren't used in the actual
			// exercises that you have to hand in:

			//MethodDemo md = new MethodDemo();
			//md.PrintSomethingElse();
			//Console.WriteLine("==========");
			//md.PrintSomething();
			//Console.WriteLine("==========");

			//Return_Ref_Out_Demo rrod = new Return_Ref_Out_Demo();
			//rrod.RunExercise();
		}
	}
	
	class Basic_Parameters
	{
		public void RunExercise()
		{
			displayMax(1, 4);
		}

		public void displayMax(int first, int second)
		{
			Console.WriteLine("{0}, is the first integer. {1}, is the second integer.", first, second);
		}
	}

	class Number_Printing_With_Parameters
	{
		public void RunExercise()
		{
			NumberPrinter np = new NumberPrinter();
			np.PrintNumbers( 4, 2); // this will print the numbers -3 -2 -1 0 1 2
		}
	}

	class NumberPrinter
	{
		//// Your method goes here:
		public void PrintNumbers(int x, int y)
		{
            if (x < y)
            {
                Console.WriteLine("Now printing numbers...");
                for (int i = x; i<=y; i++)
                {
                    Console.WriteLine(i);
                }
            }

            else if (y < x)
            {
                Console.WriteLine("Now printing numbers...");
                for (int i = y; i<=x; i++)
                {
                    Console.WriteLine(i);
                }
            }

            else
            {
                Console.WriteLine("Now printing number...");
                Console.Write(x);
            }
		}
	}

	class Return_Values
	{
		public void RunExercise()
		{
            Console.WriteLine("First value?");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Second value?");
            int secondNumber = Int32.Parse(Console.ReadLine());

            int theMax;

            Max m = new Max();

            // TODO: YOU MUST CHANGE THE METHOD DEFINITION OF returnMax,
            // AND THIS NEXT LINE OF CODE, 
            // SO THAT firstNumber AND secondNumber ARE PASSED INTO THE METHOD AS PARAMETERS, 
            // AND THEN STORE THE RESULTING RETURN VALUE INTO theMax.

            theMax = m.returnMax(firstNumber, secondNumber); // you'll need to change this line 
            //Don't forget to assign the return value to theMax!    

            Console.WriteLine("The sum of {0} and {1} is {2}", firstNumber, secondNumber, theMax);

        }
    }

	class Max
	{
        // You'll need to change this method
        public int returnMax(int x, int y)
        {
            return x + y;
        }
    }

	class Params
	{
		public void RunExercise()
		{
		}



	}

	class Testing_Randomness
	{
		public void RunExercise()
		{
			HelperClass help = new HelperClass();

			double a1_6 = help.getAverage(1, 6);
			double a1_10 = help.getAverage(1, 10);
			double a1_20 = help.getAverage(1, 20);

			help.checkAverage(1, 6, a1_6);
			help.checkAverage(1, 10, a1_10);
			help.checkAverage(1, 20, a1_20);
		}
	}

    class HelperClass
    {
        public double getAverage(int x, int y)
        {
            Random rng = new Random();
            int g = rng.Next(x, y);
            int e = rng.Next(x, y);
            double average = 0;
            if (g > e)
            {
                for (int i = e; i <= g; i++)
                    average += i;
                return average / g;
            }
            if (e > g)
            {
                for (int i = g; i <= e; i++)
                    average += i;
                return average / e;
            }
            return 0.0;
        }

        public void checkAverage(int x, int y, double z)
        {
            double average = 0;
            if (x > y)
            {
                for (int i = y; i <= x; i++)
                    average += i;
                if (average / x != z)
                    Console.WriteLine("The average random number (range: {0} to {1}) was expected to be {2}, but was actually {3}", y, x, average / x, z);
                else
                    Console.WriteLine("The average random number (range: {0} to {1}) is {2}, as expected", y, x, average / x);
            }
            if (y > x)
            {
                for (int i = x; i <= y; i++)
                    average += i;
                if (average / x != z)
                    Console.WriteLine("The average random number (range: {0} to {1}) was expected to be {2}, but was actually {3}", x, y, average / y, z);
                else
                    Console.WriteLine("The average random number (range: {0} to {1}) is {2}, as expected", x, y, average / y);
            }
        }
    }

	class Square_Of_Numbers
	{
		public void RunExercise()
		{
            Console.Write("Give me a number and I'll make a square out of it: ");
            int width = Int32.Parse(Console.ReadLine());
            for (int x = 0; x < width; x++)
            {
                for (int i = 1; i <= width; i++)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }
		}
	}

	class Square_Of_Numbers_Parameters_Return
	{
		public void RunExercise()
		{
            Console.Write("Width? ");
            int width = Int32.Parse(Console.ReadLine());
            Console.Write("Length? ");
            int length = Int32.Parse(Console.ReadLine());
            SquarePrinter sp = new SquarePrinter();
            sp.PrintRectangle(width, length);
		}
	}

	class SquarePrinter
	{
        public void PrintRectangle(int w, int l)
        {
            int stars = 0;
            for (int i = 0; i < l; i++)
            {
                if (i == 0 || i == l - 1)
                    for (int o = 0; o < w; o++)
                    {
                        Console.Write("*");
                        stars++;
                    }
                else
                    for (int o = 0; o < w; o++)
                    {
                        if (o == 0 || o == w - 1)
                        {
                            Console.Write("*");
                            stars++;
                        }
                        else
                            Console.Write(" ");
                    }
                Console.WriteLine();
            }
        }
	}


	class Detecting_Prime_Numbers
	{
		public void RunExercise()
		{
            Console.WriteLine("What is the number you would like to test for prime-ness?");
            int prime = Int32.Parse(Console.ReadLine());
            if (isPrime(prime) == false)
                Console.WriteLine("{0} is NOT prime", prime);
            else
                Console.WriteLine("{0} IS prime", prime);
		}

        public bool isPrime(int x)
        {
            int check = 0;
            if (x < 0) return false;
            for (int i = 1; i < x; i++)
            {
                double div1 = x*1.0 / i*1.0;
                int div2 = x / i;
                if (div1 == div2)
                    check++;
                Console.WriteLine(check);
            }
            if (check > 2)
                return false;
            if (check <= 2)
                return true;
            return false;
        }
	}

	class PrimalityDetector
	{
		// // Add your isPrime method here:
		// public ______  isPrime( _______ )
		// {
		//
		//
		// }
	}

	class Array_Basics
	{
		public void RunExercise()
		{
            int[] x = new int[10];
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Write a number for position {0} of this array (the array limit is {1})", i + 1, x.Length);
                int integerPlacement = Int32.Parse(Console.ReadLine());
                x[i] = integerPlacement;
            }
            int[] y = new int[5];
            y[0] = 1;
            y[1] = 10;
            y[2] = 100;
            y[3] = 1000;
            y[4] = 10000;
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("The number for position {0} of the array is {1}", i, x[i]);
            }
		}
	}

	class Array_Usage
	{
		public void RunExercise()
		{
            int[] y = new int[5];
            y[0] = 1;
            y[1] = 10;
            y[2] = 100;
            y[3] = 1000;
            y[4] = 10000;
            int x = 0;
            for (int i = 0; i < y.Length; i++)
            {
                x += y[i];
            }
            Console.WriteLine(x);
        }
	}

	class Using_Part_Of_An_Array
	{
		public void RunExercise()
		{
            int[] x = new int[1];
            int[] y = new int[x.Length];
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Write a number to the array, write a negative number to stop adding numbers");
                int integerPlacement = Int32.Parse(Console.ReadLine());
                if (integerPlacement >= 0)
                {
                    x[i] = integerPlacement;
                    Console.WriteLine("You added the number {0} in position {1}", x[i], i);
                    sum += x[i];
                }
                else
                {

                    Console.WriteLine("The sum of all the numbers you've added to the array are: {0}. And the average is: {1}", sum, sum / y.Length);
                    break;
                }
                y = new int[x.Length];
                x = new int[x.Length + 1];
                for (int o = 0; o < y.Length; o++)
                {
                    y[o] = x[o];
                }
                for (int v = 0; v < y.Length; v++)
                {
                    x[v] = y[v];
                }
            }
        }
	}

	// These have been commented out so that the other exercises will compile.
	// When you get to this exercise, uncomment it, do the work, and leave this code uncommented
	//      (so your instructor can quickly and easily compile your final, 'fixed' version).
	class Array_Parameter
	{
		public void RunExercise()
		{
            // allocate the array here - name it something like dataValues
            int[] dataValues = new int[5];

            // call GetUserData( dataValues ); to fill in the array
            //      RunExercise will need to remember how many values were actually filled in
            int howMany = GetUserData(dataValues);
            Console.WriteLine("\nStored {0} values into the array\n", howMany);

            // call CalculateSum( howManyValues, dataValues );  to get the sum of the values -
            //      store the return value into a variable
            // print the sum (using the variable)
            Console.WriteLine("\nThe total is: {0}\n", CalculateSum(howMany, dataValues));

            // Do everything a second time, just to make sure it works with a different array
            int[] nums2 = new int[10];
            howMany = GetUserData(nums2);
            Console.WriteLine("\nStored {0} values into the array\n", howMany);
            Console.WriteLine("\nThe total is: {0}\n", CalculateSum(howMany, nums2));

            // Make sure CalculateSum totals up everything in the array (AND DOES NOT CRASH) when
            // given a 'howMany' parameter that's larger than the array
            int[] nums3 = new int[3] { -10, 9, 4};
            howMany = 20; // note that this is larger than the 3 element array that we're using
            Console.WriteLine("\nTesting CalculateSum with negative values and a 'howMany' parameter larger than the array\n");
            Console.WriteLine("\nThe total is: {0}\n", CalculateSum(howMany, nums3));
            // note that the total should be 13.  If it's just 3 then you're including negative numbers, which
            // is a mistake

        }

        public int GetUserData(int[] x)
        {
            int[] y = new int[x.Length];
            int total = 0;
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Please type in a number. Type a negative number to exit!");
                int integerPlacement = Int32.Parse(Console.ReadLine());
                if (integerPlacement >= 0)
                {
                    x[i] = integerPlacement;
                    total++;
                }
                else
                {
                    return total;
                }
            }
            return x.Length;
        }

        public int CalculateSum(int x, int[] y)
        {
            int sum = 0;
            for (int i = 0; i < x; i++)
            {
                if (i != y.Length)
                {
                    if (y[i] >= 0)
                    sum += y[i];
                }
                else
                break;
            }
            return sum;
        }
    }

	class ArrayHelper
	{
	//    public int GetUserData( /* ?????  */ )
	//    {
	//    }
	//    public int CalculateSum( /* ?????  */ )
	//    {
	//    }
	}  

	class Returning_An_Array
	{
        public void RunExercise()
        {
            int[] nums1; // Array will be allocated by 
                         // CreatedRandomlyFilledArray, below

            // Create an array of 10 integers, filled with random numbers
            nums1 = CreateRandomlyFilledArray(10);

            PrintArray(nums1);
            Console.WriteLine();
        }
        
        public int[] CreateRandomlyFilledArray(int x)
        {
            Random rng = new Random();
            int[] y = new int[x];
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = rng.Next(0, 101);
            }
            return y;
        }

        public void PrintArray(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("{0} ", x[i]);
            }
        }
	}

	class ArrayReturnMethods
	{

	//    public /*????*/ CreateRandomlyFilledArray( /*????*/ )
	//    {
	//        // This won't compile (and isn't implemented), but
	//        // it does show you where the this method
	//        // needs to go.
	//    }

	//    public /*????*/ PrintArray( /*????*/ )
	//    {
	//        // This won't compile (and isn't implemented), but
	//        // it does show you where the this method
	//        // needs to go.
	//    }
	}

	class Fibonnaci_With_Array
	{
		public void RunExercise()
		{
            Random rng = new Random();
            int[] x = new int[rng.Next(0, 50)];
            x[0] = 0;
            x[1] = 1;
            for (int i = 2; i < x.Length; i++)
            {
                x[i] = x[i - 1] + x[i - 2];
            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write("{0} ", x[i]);
            }
        }
	}

	///////////////////////////////////////////////////////////////////

	// The following were used to demonstrate topics
	// on the various videos, but aren't used in the actual
	// exercises that you have to hand in:   

	class MethodDemo
	{
		public void PrintSomethingElse()
		{
			Console.WriteLine("Something else");
		}

		public void PrintSomething()
		{
			Console.WriteLine("Hello!");
			this.PrintSomethingElse(); // valid, 115-like
			PrintSomethingElse(); // also valid

			Basic_Parameters_Demo bpd = new Basic_Parameters_Demo();
			bpd.RunExercise();
		}
	}

	class Basic_Parameters_Demo
	{
		public void RunExercise()
		{

			// // This was used in a video. Feel free to uncomment & play with it
			Demo d = new Demo();
			int theNum = 3;
			d.ParameterDemo(theNum, 3.2); // an argument
			Console.WriteLine(theNum);

			Console.WriteLine("First value?");
			int firstNumber = Int32.Parse(Console.ReadLine());

			Console.WriteLine("Second value?");
			int secondNumber = Int32.Parse(Console.ReadLine());

			// MaxPrinter mp = new MaxPrinter();
			// call displayMax here, with firstNumber and secondNumber
		}
	}

	// This was used in a video; you don't have to do anything with it yourself
	public class Demo
	{

		public void ParameterDemo(int theNum, double n2) // parameter, aka 'formal argument'
		{
			theNum = 10;
			Console.WriteLine("value passed in is: {0} {1}", theNum, n2);

			return;
		}


	}


	class Return_Values_Demo
	{
		public void RunExercise()
		{
			// This was used in a video. Feel free to uncomment & play with it
			ReturnValueHelper rvd = new ReturnValueHelper();
			int importantValue = 99;

			importantValue = rvd.ProduceReturnValue();

			Console.WriteLine(importantValue);
		}
	}

	// This was used in a video; you don't have to do anything with it yourself
	class ReturnValueHelper
	{
		public int ProduceReturnValue()
		{
			int number = 10;

			if (number < 5)
				return number;

			Console.WriteLine("Hello!");
			return 10;
		}
	}

	class Return_Ref_Out_Demo
	{
		public void RunExercise()
		{
			// This was used in a video. Feel free to uncomment & play with it
			Return_Ref_Out_Examples rvd = new Return_Ref_Out_Examples();

			int importantValue = 99;
			importantValue = rvd.ProduceReturnValue();
			Console.WriteLine(importantValue);

			int otherValue; // NOTICE: NOT initialized!
			rvd.InitializeVariables(out importantValue, out otherValue);
			Console.WriteLine("ImportantValue: {0} otherValue: {1}", importantValue, otherValue);

			otherValue = 10;
			rvd.PrintOrMakePositive(ref otherValue);
			Console.WriteLine("otherValue: {0}", otherValue);

			otherValue = -10;
			rvd.PrintOrMakePositive(ref otherValue);
			Console.WriteLine("otherValue: {0}", otherValue);
		}
	}

	// This was used in a video; you don't have to do anything with it yourself
	class Return_Ref_Out_Examples
	{
		public int ProduceReturnValue()
		{
			int number = 10;

			return number;
		}

		public void InitializeVariables(out int num1, out int num2)
		{
//            Console.WriteLine(num1); // note the compiler error!
			num1 = 0;
			num2 = 0;
			Console.WriteLine("num1 is now: {0}", num1);
		}

		public void PrintOrMakePositive(ref int num1)
		{
			if (num1 > 0)
				Console.WriteLine("num1 is: {0}", num1);
			else
				num1 = 1; // 1 is positive :)
		}
	}

	class ArrayExamples
	{
		public void RunExercise()
		{
			int[] nums = new int[5];
			// put vlaues into nums
			int x = 3;

			ArrayDemo ad = new ArrayDemo();
			ad.PrintArray(x, nums);

			int num = ad.ReturnNumber();

			int[] moreNums; // NOTE: NO new int[] - we'll do that below
			moreNums = ad.ReturnArray();

			ad.PrintArray(-10, moreNums);
		}
	}

	class ArrayDemo
	{
		public void PrintArray(int oneNum, int[] numsToPrint)
		{
			Console.WriteLine(oneNum);

			for (int i = 0; i < numsToPrint.Length; i++)
				Console.WriteLine(numsToPrint[i]);
		}

		public int ReturnNumber()
		{
			int x = 0;
			// x is given a value, somehow
			//      we'll leave that out since this 
			//      example focuses on returning the value
			return x+1;
		}

		public int[] ReturnArray()
		{
			int[] nums = { 1, 2 + 1, this.ReturnNumber() };
				// turns out, you can put code into the initializer
				// that will be executed at run-time

			// normally you'd do more with the array
			return nums;
		}
	}
}

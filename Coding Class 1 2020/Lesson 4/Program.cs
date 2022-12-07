//Jason Truong
//Bit 142
//A1.4

using System;

namespace PCE_StarterProject
{
	class Program
	{
		static void Main(string[] args)
		{
			Basic_Parameters bp = new Basic_Parameters();
			bp.RunExercise();

			// Number_Printing_With_Parameters pnwp = new Number_Printing_With_Parameters();
			// pnwp.RunExercise();

			Return_Values rv = new Return_Values();
			rv.RunExercise();

			Testing_Randomness tr = new Testing_Randomness();
			tr.RunExercise();

			Square_Of_Numbers son = new Square_Of_Numbers();
			son.RunExercise();
			
			Square_Of_Numbers_Parameters_Return sonpr = new Square_Of_Numbers_Parameters_Return();
			sonpr.RunExercise();

			// Detecting_Prime_Numbers dpn = new Detecting_Prime_Numbers();
			// dpn.RunExercise();

			// Array_Basics ab = new Array_Basics();
			// ab.RunExercise();

			// Array_Usage au = new Array_Usage();
			// au.RunExercise();

			Using_Part_Of_An_Array upoaa = new Using_Part_Of_An_Array();
			upoaa.RunExercise();

			Array_Parameter ap = new Array_Parameter();
		    ap.RunExercise();

            Returning_An_Array raa = new Returning_An_Array();
            raa.RunExercise();

            // Fibonnaci_With_Array fwa = new Fibonnaci_With_Array();
            // fwa.RunExercise();

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
            Console.WriteLine("Give me a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number: ");
            int b = int.Parse(Console.ReadLine());
			displayMax(a, b);
		}

		public void displayMax(double roxanne, double bailey)
		{
			Console.WriteLine("Two numbers! {0} and {1}!\nHere they are added together, {2}", roxanne, bailey, (roxanne + bailey));
		}
	}

	class Number_Printing_With_Parameters
	{
		public void RunExercise()
		{
			NumberPrinter np = new NumberPrinter();
			// np.PrintNumbers( -3, 2); // this will print the numbers -3 -2 -1 0 1 2
		}
	}

	class NumberPrinter
	{
		//// Your method goes here:
		//public ??? PrintNumbers( ??????   )
		//{

		//}
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

			            m.returnMax(firstNumber, secondNumber); // you'll need to change this line 
								// Don't forget to assign the return value to theMax!    

			            Console.WriteLine("The max from \"{2}\", that hold {0} and {1}, is {3}", firstNumber, secondNumber, m, (m.returnMax(firstNumber,secondNumber)));

		}
	}

	class Max
	{
		// You'll need to change this method
		public int returnMax(int a, int b)
		{
            //	Console.WriteLine("You will need to modify this function to accept parameters, and return a value!");
            //	Console.WriteLine("Make sure you remove these WriteLine statements - this method should RETURN the larger value; it should NOT PRINT the larger value");
            if (a > b)
                return a;
            else
                return b;
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
        Random g = new Random();
        public double getAverage(int a, int b)
        {
            int d = 0;
            for (int c = 0; c < 1000; c++)
            {
                d += g.Next(a, b);
            }
            double e = d / 1000;
            return e;
        }
        public void checkAverage(int a, int b, double z)
        {
            int d = 0;
            for (int c = 0; c < b; c++)
            {
                d += (c + 1);
            }
            double e = d / b;

            if (e == z)
                Console.WriteLine("The average random number (range: {0} to {1}) is {2}, as expected", a, b, z);
            else if (e != z)
                Console.WriteLine("The average random number (range: {0} to {1}) is {2}, but was actually {3}", a, b, e, z);
        }
    }

    class Square_Of_Numbers
    {
        public void RunExercise()
        {
            Console.WriteLine("How many collumns you want in this square?: ");
            int input = Int32.Parse(Console.ReadLine());
            for (int a = 0; a < input; a++)
            {
                for (int b = 1; b <= input; b++)
                {
                    if (b != input)
                        Console.Write(b + " ");
                    else
                        Console.WriteLine(b);
                }
            }
        }
    }

    class Square_Of_Numbers_Parameters_Return
	{
		public void RunExercise()
		{
            Console.WriteLine("Width? ");
            int width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Height? ");
            int height = Int32.Parse(Console.ReadLine());
            for (int a = 0; a < height; a++)
            {
                if ((a % (height - 1) == 0))
                {
                    for (int b = 0; b < width; b++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int b = 0; b < width; b++)
                    {
                        if ((b % (width -1 )) == 0)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
		}
	}

	class SquarePrinter
	{
	}


	class Detecting_Prime_Numbers
	{
		public void RunExercise()
		{
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
		}
	}

	class Array_Usage
	{
		public void RunExercise()
		{
		}
	}

	class Using_Part_Of_An_Array
	{
		public void RunExercise()
		{
            int total = 0;
            int[] bobbert = new int[10];
            Console.WriteLine("Alright lets fill an array!");
            for (int index = 0; index < bobbert.Length; index++)
            {
                Console.WriteLine("Number for position {0}", index);
                total = Int32.Parse(Console.ReadLine());
                bobbert[index] = total;
            }
            total = 0;
            for (int index = 0; index < bobbert.Length; index++)
            {
                total += bobbert[index];
            }
            Console.WriteLine("Your total sum is: {0}", total);
            Console.WriteLine("And the average would be {0}", (total / bobbert.Length));
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
            Console.WriteLine("How big do you want the array to be?: ");
            int input = Int32.Parse(Console.ReadLine());
            int[] dataValues = new int[input];

            // call GetUserData( dataValues ); to fill in the array
            //      RunExercise will need to remember how many values were actually filled in
            ArrayHelper AH = new ArrayHelper();
            dataValues = AH.getUserData(dataValues);
            int howMany = dataValues.Length;
            Console.WriteLine("\nStored {0} values into the array\n", howMany);

            // call CalculateSum( howManyValues, dataValues );  to get the sum of the values -
            //      store the return value into a variable
            // print the sum (using the variable)
            Console.WriteLine("\nThe total is: {0}\n", AH.calculateSum(howMany, dataValues));

            // Do everything a second time, just to make sure it works with a different array
            int[] nums2 = new int[10];
            nums2 = AH.getUserData(nums2);
            howMany = nums2.Length;
            Console.WriteLine("\nStored {0} values into the array\n", howMany);
            Console.WriteLine("\nThe total is: {0}\n", AH.calculateSum(howMany, nums2));

            // Make sure CalculateSum totals up everything in the array (AND DOES NOT CRASH) when
            // given a 'howMany' parameter that's larger than the array
            int[] nums3 = new int[3];
            nums3[0] = -10;
            nums3[1] = 9;
            nums3[2] = 4;
            howMany = 20; // note that this is larger than the 3 element array that we're using
            Console.WriteLine("\nTesting CalculateSum with negative values and a 'howMany' parameter larger than the array\n");
            Console.WriteLine("\nThe total is: {0}\n", AH.calculateSum(howMany, nums3));
            // note that the total should be 13.  If it's just 3 then you're including negative numbers, which
            // is a mistake

        }
    }

	class ArrayHelper
	{
        public int[] getUserData(int[] y)
        {
            for (int indexer = 0; indexer < y.Length; indexer++)
            {
                Console.WriteLine("Input an integer for index position {0}", indexer);
                y[indexer] = Int32.Parse(Console.ReadLine());
            }
            return y;
        }
        public int calculateSum(int x, int[] y)
        {
            x = y.Length;
            int bobbertGiveBackMySandwich = 0;
            for (int indexer = 0; indexer < y.Length; indexer++)
            {
                bobbertGiveBackMySandwich += y[indexer];
            }
            return bobbertGiveBackMySandwich;
        }
    }  

	class Returning_An_Array
	{
		public void RunExercise()
		{
            int[] nums1; // Array will be allocated by 
                         // CreatedRandomlyFilledArray, below

            // Create an array of 10 integers, filled with random numbers
            ArrayReturnMethods aRM = new ArrayReturnMethods();
            nums1 = aRM.CreateRandomlyFilledArray(10);

            Console.WriteLine(aRM.PrintArray(nums1));
        }
    }

	class ArrayReturnMethods
	{

	    public int[] CreateRandomlyFilledArray(int x)
	    {
        // This won't compile (and isn't implemented), but
        // it does show you where the this method
        // needs to go.
        Random a = new Random();
        int[] b = new int[x];
        for (int index = 0; index < b.Length; index++)
        {
            int jeff = a.Next();
            b[index] = jeff;
        }

        return b;
	    }

	    public String PrintArray(int[] x)
	    {
        // This won't compile (and isn't implemented), but
        // it does show you where the this method
        // needs to go.

        String Bobbert = "The following numbers in the array are: ";
        for (int index = 0; index < x.Length; index++)
        {
            if (index != (x.Length - 1))
                Bobbert += (x[index] + ", ");
            else
                Bobbert += ("and " + x[index]);
        }

        return Bobbert;
	    }
	}

	class Fibonnaci_With_Array
	{
		public void RunExercise()
		{
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

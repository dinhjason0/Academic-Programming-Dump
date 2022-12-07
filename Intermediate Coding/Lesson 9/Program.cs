#define TESTING
using System;

/*
 * STUDENTS: Your answers (your code) goes into this file!!!!
 * 
  * NOTE: In addition to your answers, this file also contains a 'main' method, 
 *      in case you want to run a normal console application.
 * 
 * If you want to / have to put something into 'Main' for these PCEs, then put that 
 * into the Program.Main method that is located below, 
 * then select this project as startup object 
 * (Right-click on the project, then select 'Set As Startup Object'), then run it 
 * just like any other normal, console app: use the menu item Debug->Start Debugging, or 
 * Debug->Start Without Debugging
 * 
 */

namespace PCE_StarterProject
{
	class Program
	{
        static void Main(String[] args)
        {
            int[] Kiske = { 1, 2, 3, 4, 5, 67, 89, 788 };
            int target = 5;
            int target2 = 14;
            int count = 0;
            int count2 = 0;
            SearchingAndSorting sas = new SearchingAndSorting();
            Console.WriteLine("The target number: {0} in the array is: {1}", target, sas.FindIntegerLinear(target, Kiske));
            Console.WriteLine("The target number: {0} in the array is: {1}", target2, sas.FindIntegerLinear(target2, Kiske));
            Console.WriteLine("The target number: {0} in the array is: {1}", target, sas.FindIntegerBinary(target, Kiske));
            Console.WriteLine("The target number: {0} in the array is: {1}", target2, sas.FindIntegerBinary(target2, Kiske));
            Console.WriteLine("The target number: {0} in the array is: {1}. {2} loops.", target, sas.FindIntegerLinearPerfMeasured(target, Kiske, out count), count);
            Console.WriteLine("The target number: {0} in the array is: {1}. {2} loops.", target2, sas.FindIntegerLinearPerfMeasured(target2, Kiske, out count), count);
            Console.WriteLine("The target number: {0} in the array is: {1}. {2} loops.", target, sas.FindIntegerBinaryPerfMeasured(target, Kiske, out count), count);
            Console.WriteLine("The target number: {0} in the array is: {1}. {2} loops.", target2, sas.FindIntegerBinaryPerfMeasured(target2, Kiske, out count), count);

            Random rng = new Random();
            int[] Force = new int[99];
            for (int i = 0; i < Force.Length; i++)
            {
                Force[i] = rng.Next();
            }
            sas.BubbleSort(Force);
            for (int i = 0; i < Force.Length-1; i++)
            {
                Console.Write(Force[i] + ", ");
            }
            Console.WriteLine(Force[Force.Length - 1] + "\n");

            Force = new int[99];
            for (int i = 0; i < Force.Length; i++)
            {
                Force[i] = rng.Next();
            }
            sas.BubbleSortPerfMeasured(Force, out count, out count2);
            for (int i = 0; i < Force.Length - 1; i++)
            {
                Console.Write(Force[i] + ", ");
            }
            Console.WriteLine(Force[Force.Length - 1] + "\n");

            Console.WriteLine("{0} swaps were made.  {1} comparisons were made", count, count2);
            // Test_Print_Array tpa = new Test_Print_Array();
            // tpa.RunExercise();

            // Test_Find_Integer_Linear_Measured tfilm = new Test_Find_Integer_Linear_Measured();
            // tfilm.measure();

            // Test_Find_Integer_Binary_Measured tfibm = new Test_Find_Integer_Binary_Measured();
            // tfibm.measure();
            // tfibm.TestRecursiveBinarySearch();

            // Test_BubbleSort_Measured tbm = new Test_BubbleSort_Measured();
            // tbm.measure();

            // Students: If you want to / have to put something
            // into 'Main' for these PCEs, this is the place to put it :)


            // In the View -> Solution Explorer you can right-click on project 03,
            // then select "Set As Startup Project" in order to run this code as
            // a console application
            QuickOverviewOfOutParameters qooop = new QuickOverviewOfOutParameters();
			int num1 = 10;
			Console.WriteLine("Normal Parameters: =============");
			Console.WriteLine("PRE  num1 is: {0}", num1);
			qooop.NormalParam(num1);
			Console.WriteLine("POST num1 is: {0}", num1); // notice that num1 hasn't changed

			Console.WriteLine("Out Parameters: ================");
			Console.WriteLine("PRE  num1 is: {0}", num1);
			qooop.OutParam(out num1);
			Console.WriteLine("POST num1 is: {0}", num1); // notice that num1 HAS changed

		}
	}

	public class Test_Print_Array
	{
		public void RunExercise()
		{
		}
	}

	public class Analyzing_Algorithms
	{
		// put your output here, in a comment:
	}

public class QuickOverviewOfOutParameters
{
	public void NormalParam(int x)
	{
		Console.WriteLine("PRE  x is: {0}", x);
		x = 20;
		Console.WriteLine("POST x is: {0}", x);
	}

	public void OutParam(out int x)
	{
		// we're not allowed to use an out parameter until we give it a 
		//      starting value.  
		// Try to uncomment the next line, and notice the compiler error you get
		// Console.WriteLine("PRE  x is: {0}", x);
		x = 0; // starting value assigned here

		x = 20; // notice that this changes the param here AND the "num1" back in main!
		Console.WriteLine("POST x is: {0}", x);
	}
}

	// This is now UNcommented, so it compiles ok as soon as you've downloaded it.
	public class SearchingAndSorting
	{
		// This is from a prior exercise.
		// If you haven’t done it yet, you should – it
		// just prints out everything in the nums array
		public void printArray(int[] nums)
		{
			Console.WriteLine("The array is " + nums.Length + "integers long!");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
		}

		public bool FindIntegerLinear(int target, int[] array)
		{
			// Your code goes here.
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target) return true;
            }
			return false;
		}

        public bool FindIntegerBinary(int target, int[] array)
		{
            int lowerLimit = 0;
            int upperLimit = array.Length - 1;
            while (lowerLimit <= upperLimit)
            {
                int watch = upperLimit+lowerLimit / 2;
                if (watch == target)
                    return true;
                else if (watch > target)
                    upperLimit = watch - 1;
                else if (watch < target)
                    lowerLimit = watch + 1;
            }
			return false;
		}

		public bool FindIntegerBinaryRecursive(int target, int[] array)
		{
			FindIntegerBinaryRecursive(target, array, 0, array.Length - 1);
			return false;
		}

		private bool FindIntegerBinaryRecursive(int target,
												int[] array,
												int lowestIndex,
												int highestIndex)
		{
			FindIntegerBinaryRecursive(target, array, lowestIndex + 1, highestIndex - 1);
			return false;
		}

        public bool FindIntegerLinearPerfMeasured(int target, int[] array, out int numComparisons)
        {
            numComparisons = 0;
            // Your code goes here.
            for (int i = 0; i < array.Length; i++)
            {
                numComparisons++;
                if (array[i] == target) return true;
            }
            return false;
        }

        public bool FindIntegerBinaryPerfMeasured(int target,
				int[] array, out int numComparisons)
		{
			numComparisons = 0;
            int lowerLimit = 0;
            int upperLimit = array.Length - 1;
            while (lowerLimit <= upperLimit)
            {
                numComparisons++;
                int watch = upperLimit + lowerLimit / 2;
                if (watch == target)
                    return true;
                else if (watch > target)
                    upperLimit = watch - 1;
                else if (watch < target)
                    lowerLimit = watch + 1;
            }
            return false;
        }

		public void BubbleSort(int[] nums)
		{
            if (nums == null || nums.Length == 0)
                return;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int o = 1; o <= nums.Length - 1; o++)
                {
                    int temp = nums[o - 1];
                    if (nums[o-1] >= nums[o])
                    {
                        nums[o - 1] = nums[o];
                        nums[o] = temp;
                    }
                }
            }
		}

		public void BubbleSortPerfMeasured(int[] nums, out int numSwaps, out int numComparisons)
		{
            numSwaps = numComparisons = 0;
            if (nums == null || nums.Length == 0)
                return;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int o = 1; o <= nums.Length - 1; o++)
                {
                    numComparisons++;
                    int temp = nums[o - 1];
                    if (nums[o - 1] >= nums[o])
                    {
                        nums[o - 1] = nums[o];
                        nums[o] = temp;
                        numSwaps++;
                    }
                }
            }
        }
	}

	public class Test_Find_Integer_Linear_Measured
	{
		public void measure()
		{
			SearchingAndSorting sas = new SearchingAndSorting();

			Console.WriteLine("\n\n\t\tLINEAR SEARCH PERFORMANCE TESTING!\n\n");
			Random r = new Random();
			for (int i = 1; i < 5; i++)
			{
				int arraySize = i * i * 100;

				int[] nums = new int[arraySize];
				for (int j = 0; j < arraySize; j++)
				{	// give each element a random starting value.
					nums[j] = r.Next(arraySize);
				}

				// we want to first get a reading on how many comparisons are
				// needed when we're looking for something in the array.
				// So we'll randomly pick an element out of the array,
				// and search for it.  Lather, rinse, repeat 100 times.
				int totalComps = 0;
				int numComps;
				for (int j = 0; j < 10000; j++)
				{
					int target = nums[r.Next(arraySize)];
					if (!sas.FindIntegerLinearPerfMeasured(target, nums, out numComps))
						Console.WriteLine("ERROR: COULDN'T find " + target + " despite it's presence");
					totalComps += numComps;
				}
				double aveFound = totalComps / 10000.0;	// Average number of comparisons per search

				// next, we want to get a reading on how many comparisons are
				// needed when we're looking for something NOT in the array.
				// So we'll randomly pick a value we know is NOT in the array,
				// and search for it.  Lather, rinse, repeat 100 times.
				totalComps = 0;
				for (int j = 0; j < 10000; j++)
				{
					if (sas.FindIntegerLinearPerfMeasured(arraySize + 10, nums, out numComps))
						Console.WriteLine("ERROR: COULD find " + (arraySize + 10) + " despite it's presence");
					totalComps += numComps;
				}
				double aveNotFound = totalComps / 10000.0;	// Average number of comparisons per search
				Console.WriteLine("For an array of " + arraySize + " elements, the average number of comparisons when:\n\tthe element was present: " + aveFound + "\n\tthe element was NOT present: " + aveNotFound);
			}
		}
	}

	public class Test_Find_Integer_Binary_Measured
	{
		public void measure()
		{
			SearchingAndSorting sas = new SearchingAndSorting();

			Console.WriteLine("\n\n\t\tBINARY SEARCH PERFORMANCE TESTING!\n\n");

			Random r = new Random();
			for (int i = 1; i < 5; i++)
			{
				int arraySize = i * i * 100;

				int[] nums = new int[arraySize];
				for (int j = 0; j < arraySize; j++)
				{	// give each element a random starting value.
					nums[j] = r.Next(arraySize);
				}
				Array.Sort(nums); // binary search only works on sorted arrays, so sort it...

				// we want to first get a reading on how many comparisons are
				// needed when we're looking for something in the array.
				// So we'll randomly pick an element out of the array,
				// and search for it.  Lather, rinse, repeat a zillioni times.
				int totalComps = 0;
				int numComps;
				for (int j = 0; j < 10000; j++)
				{
					int target = nums[r.Next(arraySize)];
					if (!sas.FindIntegerBinaryPerfMeasured(target, nums, out numComps))
						Console.WriteLine("ERROR: COULDN'T find " + target + " despite it's presence");
					totalComps += numComps;
				}
				double aveFound = totalComps / 10000.0;	// Average number of comparisons per search

				// next, we want to get a reading on how many comparisons are
				// needed when we're looking for something NOT in the array.
				// So we'll randomly pick a value we know is NOT in the array,
				// and search for it.  Lather, rinse, repeat a zillion more times.
				totalComps = 0;
				for (int j = 0; j < 10000; j++)
				{
					if (sas.FindIntegerBinaryPerfMeasured(arraySize + 10, nums, out numComps))
						Console.WriteLine("ERROR: COULD find " + (arraySize + 10) + " despite it's presence");
					totalComps += numComps;
				}
				double aveNotFound = totalComps / 10000.0;	// Average number of comparisons per search
				Console.WriteLine("For an array of " + arraySize + " elements, the average number of comparisons when:\n\tthe element was present: " + aveFound + "\n\tthe element was NOT present: " + aveNotFound);
			}
		}

		public void TestRecursiveBinarySearch()
		{
			// Create an array, and call binary search (recursive) on it, until you're
			// convinced that it works ok.
		}
	}

	public class Test_BubbleSort_Measured
	{
		public void measure()
		{
			Console.WriteLine("\n\n\t\tBUBBLE SORT PERFORMANCE TESTING!\n\n");

			Random r = new Random();
			SearchingAndSorting sas = new SearchingAndSorting();

			double totalComps = 0;
			int compsThisTime = 0;

			double totalSwaps = 0;
			int swapsThisTime = 0;

			for (int i = 1; i < 5; i++)
			{
				int arraySize = i * i * 100;
				totalComps = 0;

				// repeat 1000 times: create an unsorted array, and sort it.
				int numTimes = 2;
				for (int j = 0; j < numTimes; j++)
				{
					int[] nums = new int[arraySize];
					for (int k = 0; k < arraySize; k++)
					{	// give each element a random starting value.
						nums[k] = r.Next(arraySize);
					}

					sas.BubbleSortPerfMeasured(nums, out swapsThisTime, out compsThisTime);
					totalComps += compsThisTime;
					totalSwaps += swapsThisTime;
				}
				Console.WriteLine("For an array of " + arraySize + " elements, there were an average of " + totalComps / numTimes + " comparisons performed, and an average of " + totalSwaps / numTimes + "swaps performed");
			}
		}
	}
}
using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Basic_Array_Of_Objects baoc = new Basic_Array_Of_Objects();
            baoc.RunExercise();

            // Array_Of_Possibly_Null_Objects aopno = new Array_Of_Possibly_Null_Objects();
            // aopno.RunExercise();
            
            // Television_Definition td = new Television_Definition();
            // td.RunExercise();

            Objects_As_Parameters oap = new Objects_As_Parameters();
            oap.RunExercise();

            Objects_As_Return_Values oarp = new Objects_As_Return_Values();
            oarp.RunExercise();

            Objects_As_Parameters_And_Return_Values oasarv = new Objects_As_Parameters_And_Return_Values();
            oasarv.RunExercise();

            // Even though these are no longer part of this PCE they're being left here:
            BarChart_Demonstration bcd = new BarChart_Demonstration();
            bcd.RunExercise();

            TVStorage_Demonstration tvsd_d = new TVStorage_Demonstration();
            tvsd_d.RunExercise();
        }
    }

    /////////////////////////////////////////////////////////////////////////////////

    public class Basic_Array_Of_Objects
    {
        public void RunExercise()
        {
            TelevisionHandler th = new TelevisionHandler();

            th.PrintArrayOfTVs();

            Television te = new Television();
            te.Print();
        }
    }

    // This is the "user interface" for the Objects-As-Parameters exercise
    public class TelevisionHandler
    {
        public void PrintArrayOfTVs()
        {
            Console.WriteLine("You need to implement this!!");
        }

        public void PrintArrayOfPossiblyNullTVs()
        {
            Console.WriteLine("You need to implement this!!");
        }

        public void PrintMyTV(Television theTV)
        {
            // if theTV is null, then print nothing

            // else call the .Print() method on it

            // Example of a 'meaningful' message:
            // Television:
            //     Brand = Zenith
            //     Price = 300.75
            //     Size = 17.5
            Console.WriteLine();
            Console.WriteLine("ABOUT TO PRINT TV");
            if (theTV.GetBrand() != null)
                theTV.Print();
            Console.WriteLine("FINISHED PRINTING TV");
            Console.WriteLine();
        }

        public void PrintMyTVUsingGetters(Television theTV)
        {
            // if theTV is null, then print nothing

            // else use getter methods (GetBrand, GetPrice, GetSize)
            // to print out a message here.

            Console.WriteLine("ABOUT TO PRINT TV");
            Console.Write("The TV's Brand is ");
            if (theTV.GetBrand() != null)
                Console.Write(theTV.GetBrand());
            else Console.Write("nothing");
            Console.WriteLine(", which is rad.");

            Console.WriteLine("The TV's Price is {0}, which is really rad.", theTV.GetPrice());
            Console.WriteLine("The TV's Size is {0}, which is wicked radical sick nasty, YEAAAAAAAAAAAAAAAAAA\n", theTV.GetSize());
        }

        public Television CreateATV()
        {
            Television tv = new Television("Brand X", 10.0m, 42.0);
            return tv; // note that you can do this
            // note that this is NOT what you should do for this exercise! :)
        }

        // CreateATVFromUserInput goes here
        public Television CreateATVFromUserInput()
        {
            string br;
            decimal pr;
            double si;
            Console.Write("What's the brand of the TV?: ");
            br = Console.ReadLine();
            Console.Write("What is the price of the TV?: ");
            decimal.TryParse(Console.ReadLine(), out pr);
            Console.Write("What is the size of the TV?: ");
            double.TryParse(Console.ReadLine(), out si);
            Console.WriteLine();
            Television tv = new Television(br, pr, si);
            return tv;
        }
        // PickMoreExpensiveTV goes here

        public Television PickMoreExpensiveTV(Television first, Television second)
        {
            if (first == null)
            {
                if (second == null)
                    return null;
                else return second;
            }
            else if (second == null)
                return first;
            else if (first.GetPrice() > second.GetPrice())
                return first;
            else if (first.GetPrice() < second.GetPrice())
                return second;
            else return first;
        }
    }

    /////////////////////////////////////////////////////////////////////////////////


    class Array_Of_Possibly_Null_Objects
    {
        public void RunExercise()
        {
            TelevisionHandler th = new TelevisionHandler();

            th.PrintArrayOfPossiblyNullTVs();
        }
    }

    /////////////////////////////////////////////////////////////////////////////////

    public class Television_Definition
    {
        public void RunExercise()
        {
        }
    }

    // We need a class to pass as a parameter for this exercises, so
    // we've whipped up the 'Television' class
    public class Television
    {
        private string brand;
        private decimal price;
        private double size;

        public Television()
        {
            brand = "";
            price = 0m;
            size = 0.0;
        }
        public Television(string br, decimal pr, double si)
        {
            SetBrand(br);
            SetPrice(pr);
            SetSize(si);
        }

        public string GetBrand()
        {
            return brand;
        }
        public void SetBrand(string newValue)
        {
            if (newValue != null)
                brand = newValue;
            else brand = "";
        }

        public decimal GetPrice()
        {
            return price;
        }
        public void SetPrice(decimal newPrice)
        {
            if (newPrice >= 0)
                price = newPrice;
            else price = 0;
        }

        public double GetSize()
        {
            return size;
        }
        public void SetSize(double newSize)
        {
            if (newSize > 0)
                size = newSize;
            else size = 0;
        }

        public void Print()
        {
            Console.WriteLine("Brand: {0}\nPrice: {1}\nSize: {2}", GetBrand(), GetPrice(), GetSize());
        }
    }

    class Objects_As_Parameters
    {
        public void RunExercise()
        {
            TelevisionHandler tvh = new TelevisionHandler();

            Television tv = new Television("Sony", 2000.0m, 50);

            Console.WriteLine("Printing using the Print method: ");
            tvh.PrintMyTV(tv);

            Console.WriteLine("Printing using getters: ");
            tvh.PrintMyTVUsingGetters(tv);
        }
    }


    /////////////////////////////////////////////////////////////////////////////////

    class Objects_As_Return_Values
    {
        public void RunExercise()
        {
            TelevisionHandler tvh = new TelevisionHandler();

            Television tv1;

            tv1 = tvh.CreateATV();
            tv1.Print();
            Console.WriteLine();

            // you MUST call CreateATVFromUserInput, then print out the result
            tv1 = tvh.CreateATVFromUserInput();
            tv1.Print();
            Console.WriteLine();
        }
    }

    /////////////////////////////////////////////////////////////////////////////////

    class Objects_As_Parameters_And_Return_Values
    {
        public void RunExercise()
        {
            TelevisionHandler tvh = new TelevisionHandler();
            Television firstTV;
            Television secondTV;

            // Get tvh to create the first TV object
            firstTV = new Television("Cotzhia", 45.4m, 44.44444444444);
            // Get tvh to create the second TV object
            secondTV = new Television("Retzia", 50.0m, 55.5555555555555);
            // Get tvh to figure out which TV is more expensive
            Television moreExpensiveTV = tvh.PickMoreExpensiveTV(firstTV, secondTV);
            // Print out both TVs
            Console.WriteLine("The first television is...");
            tvh.PrintMyTV(firstTV);
            Console.WriteLine("The second television is...");
            tvh.PrintMyTV(secondTV);
            // Announce which TV is more expensive
            Console.WriteLine("The more expensive television is: {0}", moreExpensiveTV.GetBrand());
            // Print out the moreExpensiveTV
            tvh.PrintMyTV(moreExpensiveTV);
        }
    }

    /////////////////////////////////////////////////////////////////////////////////

    public class BarChart
    {
        int[] m_numbers;

        public BarChart()
        {
            m_numbers = new int[5];
        }

        public int GetSize()
        {
            return m_numbers.Length;
        }

        public void SetValue(int newVal, int idx)
        {
            if (idx >= 0 && idx < m_numbers.Length)
                m_numbers[idx] = newVal;

            // Interesting point: note the silent failure
            // if idx is out of range
        }

        public int GetValue(int idx)
        {
            if (idx >= 0 && idx < m_numbers.Length)
                return m_numbers[idx];

            // Is this a good value to return here?
            return 0;
        }

        public double GetAverage()
        {
            double sum = 0;
            for (int i = 0; i < m_numbers.Length; i++)
            {
                sum += m_numbers[i];
            }
            return sum/m_numbers.Length;
        }

        public void PrintBarChart()
        {
            for (int i = 0; i < m_numbers.Length; i++)
            {
                for (int o = 0; o < m_numbers[i]; o++)
                    Console.Write("*");
                Console.WriteLine();
            }
            // TODO: Implement this!!
        }
    }

    public class BarChart_Demonstration
    {
        public void RunExercise()
        {
            BarChart h1 = new BarChart();
            BarChart h2 = new BarChart();

            for (int i = 0; i < 5; i++)
            {
                h1.SetValue((i + 1) * 2, i);
                h2.SetValue(10 - i, i);
            }


            Console.WriteLine("Data set 1 (Version 1): Avg: {0:0.00}", h1.GetAverage());
            h1.PrintBarChart();
            Console.WriteLine();

            // What if the first two values were different?
            h1.SetValue(5, 0);
            h1.SetValue(7, 1);

            Console.WriteLine("Data set 1 (Version 2): Avg: {0:0.00}", h1.GetAverage());
            h1.PrintBarChart();
            Console.WriteLine();

            // Wait, hold on - I got those backwards :)
            h1.SetValue(7, 0);
            h1.SetValue(5, 1);

            Console.WriteLine("Data set 1 (Version 3): Avg: {0:0.00}", h1.GetAverage());
            h1.PrintBarChart();
            Console.WriteLine();

            // I just got some new data - let me adjust the first value:
            h1.SetValue(9, 0);

            Console.WriteLine("Data set 1 (Version 4): Avg: {0:0.00}", h1.GetAverage());
            h1.PrintBarChart();
            Console.WriteLine();

            // How do the two data sets compare?
            Console.WriteLine("Data set 1 (Version 4): Avg: {0:0.00}", h1.GetAverage());
            Console.WriteLine("Data set 2 (Version 1): Avg: {0:0.00}", h2.GetAverage());

            Console.WriteLine("\nData set 1:");
            h1.PrintBarChart();
            Console.WriteLine("\nData set 2:");
            h2.PrintBarChart();
            Console.WriteLine();
        }
    }

    /////////////////////////////////////////////////////////////////////////////////

    public class TVStorage
    {
        Television[] tvs = new Television[5];

        public TVStorage()
        {
            tvs = new Television[5];
        }

        public TVStorage(int numofTeles)
        {
            tvs = new Television[numofTeles];
        }

        // TODO: Implement this method!
        // If the location is invalid (negative, or too large) do nothing.
        // If the parameter is null (and the location is ok), then replace
        //      the object reference in the array with null
        public void StoreTV(int iLocation, Television tvToStore)
        {
            if (iLocation >= 0 && iLocation < tvs.Length)
                tvs[iLocation] = tvToStore;
        }

        // TODO: Implement this method!
        // If the location is invalid (negative, or too large) return null.
        public Television GetTV(int iLocation)
        {
            if (iLocation >= 0 && iLocation < tvs.Length)
                return tvs[iLocation];
            return null;
            //return new Television(); // odd, but will guarantee all tests fail, to start
        }

        // TODO: Implement this method!
        // If a given slot in the array is non-NULL, then call .Print on it
        // otherwise, print out "Slot X is null", where X is the slot index.
        public void PrintAllTVs()
        {
            for (int i = 0; i < tvs.Length; i++)
            {
                if (tvs[i] == null)
                    Console.WriteLine("Slot {0} is null", i);
                else
                {
                    Television tev = tvs[i];
                    tev.Print();
                }
            }
        }

    }

    public class TVStorage_Demonstration
    {
        public void RunExercise()
        {
            TVStorage tvs = new TVStorage();
            tvs.PrintAllTVs();

            Television t = new Television("Brand X", 1000, 42);
            tvs.StoreTV(2, t);
            tvs.StoreTV(4, new Television("Brand Y", 2000, 52));

            Television t2 = tvs.GetTV(0);
            Console.WriteLine("Is t2 null? (It should be) {0}", t2 == null);

            tvs.PrintAllTVs();

            t2 = tvs.GetTV(2);
            Console.WriteLine("Is t2 the same as t? (It should be) {0}", t2 == t);

        }
    }
}

using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic_Class_With_Instance_Method bcwim = new Basic_Class_With_Instance_Method();
            // bcwim.RunExercise();

            // Instance_Variables iv = new Instance_Variables();
            // iv.RunExercise();

            // More_Methods mm = new More_Methods();
            // mm.RunExercise();

            Access_Control ac = new Access_Control();
            ac.RunExercise();

            // Overloading_Create_Your_Own ocyo = new Overloading_Create_Your_Own();
            // ocyo.RunExercise();

            Constructors_Exercise ce = new Constructors_Exercise();
            ce.RunExercise();

            Scope_Of_Variables sov = new Scope_Of_Variables();
            sov.RunExercise();

            Television_Definition td = new Television_Definition();
            td.RunExercise();

            Basic_Array_Of_Objects baoc = new Basic_Array_Of_Objects();
            baoc.RunExercise();

            Array_Of_Possibly_Null_Objects aopno = new Array_Of_Possibly_Null_Objects();
            aopno.RunExercise();
        }
    }
    class Basic_Class_With_Instance_Method
    {
        public void RunExercise()
        {
        }
    }
    // You should define the Toaster class (and it's Print() method) in the space below //
    //////////////////////////////////////////////////////////////////////////////////////

    //////////////////////////////////////////////////////////////////////////////////////
    // You should define the Toaster class (and it's Print() method) in the space above //

    class Instance_Variables
    {
        public void RunExercise()
        {
        }
    }
    // You should define the Refrigerator class in the space below //
    /////////////////////////////////////////////////////////////////

    /////////////////////////////////////////////////////////////////
    // You should define the Refrigerator class in the space above //


    class More_Methods
    {
        public void RunExercise()
        {
            //Oven o = new Oven();
            //Oven theOtherOven = new Oven();

            //// What does the ovens start out at?
            //Console.WriteLine("Oven o:");
            //o.Print();
            //Console.WriteLine("Oven theOtherOven:");
            //theOtherOven.Print();

            //// We want the over to be about 125 degrees...
            //// If it's close enough, we'll just use the current
            //// temperature.

            //// We'll check that it's close enough (+/- 5 degrees away from 125)
            //if( o.GetCurrentTemp() < 120 ||
            //    o.GetCurrentTemp() > 130)
            //{
            //    // The temperature is too far away, so
            //    // set it to be what we want, here
            //    o.SetCurrentTemp(125.7);
            //}

            //Console.WriteLine("Oven o:");
            //o.Print();
            //Console.WriteLine("Oven theOtherOven:");
            //theOtherOven.Print();

            //theOtherOven.SetCurrentTemp(200);


            //Console.WriteLine("Oven o:");
            //o.Print();
            //Console.WriteLine("Oven theOtherOven:");
            //theOtherOven.Print();
        }
    }

    class Oven
    {
        // Put your instance variables here:



        //public /*????? */ SetCurrentTemp( /*  ????  */ )
        //{
        //}

        //public /*????? */ GetCurrentTemp( /*  ????  */ )
        //{
        //}

        //public /*????? */ Print( /*  ????  */ )
        //{
        //}
    }


    class Access_Control
    {

        public void RunExercise()
        {
            Break_Blender b = new Break_Blender();
            b.Print();
            b.SetSpeed(7);
            Console.WriteLine("Blender's current speed: {0}", b.GetSpeed());
        }

    }

    class Break_Blender
    {
        private int Blender;

        public void SetSpeed(int bloonder)
        {
            if (bloonder < 0 || bloonder > 7)
                throw new Exception("Bad Input");
            else
            Blender = bloonder;
        }

        public int GetSpeed()
        {
            return Blender;
        }

        public void Print()
        {
            Console.WriteLine("Blender's current speed: " + Blender);
        }
    }

    class Overloading_Create_Your_Own
    {
        public void RunExercise()
        {

        }
    }



    class Constructors_Exercise
    {
        public void RunExercise()
        {
            Dishwasher d = new Dishwasher(0, 10, 1, 5, 3, 7);
            d.Print();
        }
    }

    class Dishwasher
    {
        private int glassesMin; int glassesMax; int platesMin; int platesMax; int bowlsMin; int bowlsMax;
        
        public Dishwasher (int a, int b, int c, int d, int e, int f)
        {
            glassesMin = a;
            glassesMax = b;
            platesMin = c;
            platesMax = d;
            bowlsMin = e;
            bowlsMax = f;
        }

        public void Print()
        {
            Console.WriteLine("Holding {0} of {1} glasses\nHolding {2} of {3} plates\nHolding {4} of {5} bowls", glassesMin, glassesMax, platesMin, platesMax, bowlsMin, bowlsMax);
        }
        
    }

    class Scope_Of_Variables
    {
        // Put your comment here:
        // Instance variables exist from the intialisation and sustains with the existence of the class.
        // Local variables exist only in the time they're needed for; example is when the block they're in has ended, or the loop they're called for is finished.
        // Parameters exist from the moment a variable is passed through them all the way to the finale of the method() they're called in

        public void RunExercise()
        {
            NumberPrinter np = new NumberPrinter();
            np.SetLowest(3.14159);
            np.SetHighest(12);
            np.Print(true);
            np.SetHighest(17.1);
            np.Print(false);
            np.SetLowest(17); // note that lo == hi
            np.Print(false);  // no output
            np.SetLowest(22); // note that lo > hi
            np.Print(false);  // no output
        }
    }

    class NumberPrinter
    {
        private int low; int high;

        public void SetLowest(double a)
        {
            low = Convert.ToInt32(a);
            if (low < a)
                low += 1;
        }

        public void SetHighest(double a)
        {
            high = Convert.ToInt32(a);
        }
        public void Print(bool g)
        {
            if (low < high)
            {
                if (g == false)
                {
                    for (int i = low; i <= high; ++i)
                    {
                        Console.WriteLine(i);
                    }
                }

                if (g == true)
                {
                    for (int i = low; i <= high; ++i)
                    {
                        if (i % 2 == 0)
                            Console.WriteLine(i);
                    }
                }
            }
        }
    }

    public class Television_Definition
    {
        public void RunExercise()
        {
            Television tv = new Television("Sony", 1000.17M, 10.5);
            tv = new Television("Bobbert", 10.4M, 10.15);
        }
    }

    // We need a class to pass as a parameter for this exercises, so
    // we've whipped up the 'Television' class
    public class Television
    {
        private string a = "";
        private decimal b;
        private double c;

        public Television()
        {
        }
        public Television(string br, decimal pr, double si)
        {
            Television gg = new Television();
            gg.SetBrand(br);
            gg.SetPrice(pr);
            gg.SetSize(si);
            gg.Print();
        }

        public decimal GetPrice()
        {
            return b;
        }
        public void SetPrice(decimal newValue)
        {
            if (newValue < 0)
                throw new Exception("Bad Input");
            else
                b = newValue;
        }

        public void SetSize(double newValue)
        {
            if (newValue < 0)
                throw new Exception("Bad Input");
            else
                c = newValue;
        }
        public double GetSize()
        {
            return c;
        }

        public string GetBrand()
        {
            return a;
        }
        public void SetBrand(string newValue)
        {
            if (newValue != null)
            a = newValue;
        }

        public void Print()
        {
            Console.WriteLine("Brand: {0}\nPrice: {1}\nSize: {2}", GetBrand(), GetPrice(), GetSize());
        }
    }

    /////////////////////////////////////////////////////////////////////////////////

    public class Basic_Array_Of_Objects
    {
        public void RunExercise()
        {
            TelevisionHandler th = new TelevisionHandler();

            th.PrintArrayOfTVs();
        }
    }

    // This is the "user interface" for the Objects-As-Parameters exercise
    public class TelevisionHandler
    {
        private String br;
        private decimal pr;
        private double si;
        private Television[] abk;
        private Television[] apk;


        public void EstablishTVs()
        {
            Console.Write("How many TVs are you going to log?: ");
            int x = int.Parse(Console.ReadLine());
            Television[] aBunchOfTVs = new Television[x];

            for (int i = 0; i < aBunchOfTVs.Length; i++)
            {
                Console.Write("\nGive me a brand name for TV number {0}: ", (i + 1));
                br = Console.ReadLine();
                Console.Write("Give me a price for TV number {0}: ", (i + 1));
                pr = decimal.Parse(Console.ReadLine());
                Console.Write("Give me a size for TV number {0}: ", (i + 1));
                si = double.Parse(Console.ReadLine());
                aBunchOfTVs[i] = new Television();
            }

            Console.WriteLine();
            aBunchOfTVs[aBunchOfTVs.Length - 1] = new Television(null, 0, 0);
            Console.WriteLine();

            abk = aBunchOfTVs;
        }

        public void PrintArrayOfTVs()
        {
            if (abk == null)
                EstablishTVs();

            Console.WriteLine("\nAlright, here are all the TVs you've made\n");

            for (int i = 0; i < abk.Length; i++)
            {
                abk[i] = new Television(br, pr, si);
                Console.WriteLine();
            }

            if (apk != null)
            {
                Console.WriteLine("\nAnd here are those null TVs you made\n");
                if (apk.Length != 0)
                {
                    for (int i = 0; i < apk.Length; i++)
                    {
                        apk[i] = new Television(br, pr, si);
                    }
                }

                else
                    Console.WriteLine("WAIT THERE ARE NONE!");
            }
        }

        public void PrintArrayOfPossiblyNullTVs()
        {
            EstablishTVs();
            Television[] aBunchOfTVs = abk;
            int g = 0;
            int f = 0;

            for (int i = 0; i < aBunchOfTVs.Length; i++)
            {
                if (aBunchOfTVs[i] == null)
                {
                    g++;  
                }
                else if (aBunchOfTVs[i] != null)
                {
                    f++;
                }
            }

            Television[] aBunchOfNulls = new Television[g];

            for (int i = 0; i < aBunchOfTVs.Length; i++)
            {
                if (aBunchOfTVs[i] == null)
                {
                    aBunchOfNulls[aBunchOfNulls.Length - 1] = aBunchOfTVs[i];
                }
            }

            Television[] aBunchOfTele = new Television[f];
            
            for (int i = 0; i < abk.Length; i++)
            {
                if (aBunchOfTVs[i] != null)
                {
                    aBunchOfTele[aBunchOfTele.Length - 1] = aBunchOfTVs[i];
                }
            }

            apk = aBunchOfNulls;
            abk = aBunchOfTele;
            PrintArrayOfTVs();
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
}
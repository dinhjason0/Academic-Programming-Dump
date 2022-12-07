using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Basic_Class_With_Instance_Method bcwim = new Basic_Class_With_Instance_Method();
            bcwim.RunExercise();

            Instance_Variables iv = new Instance_Variables();
            iv.RunExercise();

            More_Methods mm = new More_Methods();
            mm.RunExercise();

            Access_Control ac = new Access_Control();
            ac.RunExercise();

            Overloading_Create_Your_Own ocyo = new Overloading_Create_Your_Own();
            ocyo.RunExercise();

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
            Toaster toast = new Toaster();
            toast.Print();
        }
    }
    // You should define the Toaster class (and it's Print() method) in the space below //
    //////////////////////////////////////////////////////////////////////////////////////

    class Toaster
    {
        public void Print()
        {
            Console.WriteLine("Hello, World, from the Instance Method Exercise!");
        }
    }

    //////////////////////////////////////////////////////////////////////////////////////
    // You should define the Toaster class (and it's Print() method) in the space above //

    class Instance_Variables
    {
        public void RunExercise()
        {
            Refigerator fridges = new Refigerator();
            fridges.SetInternalTemperature(3);
            fridges.SetMinimumInternalTemperature(-10);

            Console.WriteLine("The current temperature: ", fridges.currentInternalTemperature);
            Console.WriteLine("The minimum temperature: ", fridges.minimumInternalTemperature);

            fridges.SetInternalTemperature(50);
            fridges.SetMinimumInternalTemperature(-30);

            fridges.Print();
        }
    }
    // You should define the Refrigerator class in the space below //
    /////////////////////////////////////////////////////////////////

    class Refigerator
    {
        public double currentInternalTemperature = 0;
        public double minimumInternalTemperature = 0;

        public void SetInternalTemperature(int newIntTemp)
        {
            currentInternalTemperature = newIntTemp;
        }

        public void SetMinimumInternalTemperature(int newMinTemp)
        {
            minimumInternalTemperature = newMinTemp;
            Console.WriteLine(minimumInternalTemperature);
        }

        public void Print()
        {
            Console.WriteLine("The internal temperature is: {0}, and the minimum temperature is: {1}", currentInternalTemperature, minimumInternalTemperature);
        }
    }
    /////////////////////////////////////////////////////////////////
    // You should define the Refrigerator class in the space above //


    class More_Methods
    {
        public void RunExercise()
        {
            Oven o = new Oven();
            Oven theOtherOven = new Oven();

            // What does the ovens start out at?
            Console.WriteLine("Oven o:");
            o.Print();
            Console.WriteLine("Oven theOtherOven:");
            theOtherOven.Print();

            // We want the over to be about 125 degrees...
            // If it's close enough, we'll just use the current
            // temperature.

            // We'll check that it's close enough (+/- 5 degrees away from 125)
            if (o.GetCurrentTemp() < 120 || o.GetCurrentTemp() > 130)
            {
                // The temperature is too far away, so
                // set it to be what we want, here
                o.SetCurrentTemp(125.7);
            }

            Console.WriteLine("Oven o:");
            o.Print();
            Console.WriteLine("Oven theOtherOven:");
            theOtherOven.Print();

            theOtherOven.SetCurrentTemp(200);


            Console.WriteLine("Oven o:");
            o.Print();
            Console.WriteLine("Oven theOtherOven:");
            theOtherOven.Print();
        }
    }

    class Oven
    {
        // Put your instance variables here:
        public double CurrentTemp;


        public void SetCurrentTemp(double NewCurrentTemp)
        {
            CurrentTemp = NewCurrentTemp;
        }

        public double GetCurrentTemp()
        {
            return CurrentTemp;
        }

        public void Print()
        {
            Console.WriteLine(CurrentTemp);
        }
    }


    class Access_Control
    {
        public void RunExercise()
        {
            Blender firstBlender = new Blender();
            Blender secondBlender = new Blender();

            firstBlender.SetSpeed(6);
            firstBlender.Print(true);

            firstBlender.Print();

            secondBlender.SetSpeed(400);
            secondBlender.Print(false);
        }
    }

    class Blender
    {
        private int Speed;

        public void SetSpeed(int newSpeed)
        {
            if (newSpeed > -1 && newSpeed < 8)
            Speed = newSpeed;
        }

        public int GetSpeed()
        {
            return Speed;
        }

        public void Print()
        {
            Console.Write("For this blender, the current speed is ");
            Console.WriteLine(Speed);
        }

        public void Print(bool longwinded)
        {
            if (longwinded == true)
            {
                Console.Write("For this blender, the current speed is ");
                Console.WriteLine(Speed);
            }

            if (longwinded == false)
            {
                Console.Write("Blender's speed: ");
                Console.WriteLine(Speed);
            }
        }
    }

    class Overloading_Create_Your_Own
    {
        public void RunExercise()
        {
            Blender ble = new Blender();
            ble.SetSpeed(4);
            ble.Print(false);
        }
    }



    class Constructors_Exercise
    {
        public void RunExercise()
        {
            Dishwasher d = new Dishwasher(0, 10, 1, 5, 3, 7);
            d.Print();
            Dishwasher e = new Dishwasher();
            e.Print();
        }
    }

    class Dishwasher
    {
        private int glasses;
        private int glassesMax;
        private int plates;
        private int platesMax;
        private int bowls;
        private int bowlsMax;

        public Dishwasher()
        {
            glasses = 0; plates = 0; bowls = 0;
            glassesMax = 10; platesMax = 10; bowlsMax = 10;
        }

        public Dishwasher(int a, int b, int c, int d, int e, int f)
        {
            if (a <= b)
            {
                glasses = a;
                glassesMax = b;
            }
            if (c <= d)
            {
                plates = c;
                platesMax = d;
            }
            if (e <= f)
            {
                bowls = e;
                bowlsMax = f;
            }
        }

        public void Print()
        {
            Console.Write("Holding ");
            Console.Write(glasses);
            Console.Write(" of ");
            Console.Write(glassesMax);
            Console.WriteLine(" glasses");

            Console.Write("Holding ");
            Console.Write(plates);
            Console.Write(" of ");
            Console.Write(platesMax);
            Console.WriteLine(" plates");

            Console.Write("Holding ");
            Console.Write(bowls);
            Console.Write(" of ");
            Console.Write(bowlsMax);
            Console.WriteLine(" bowls");
        }
    }

    class Scope_Of_Variables
    {
        // Put your comment here:
        // Instance Variables: A variable that creates and is bounded to an object. It is able to work with access modifiers. They can have default values.
        // They are created when an object is created, they last as long as the object exists, and they're destroyed when the object doesn't exist - typically never.

        // Local Variables: They're a variable typically used in constructors that are created when entering the method or a constructor.
        // They are created when they are created in the method/constructor, they exist as long as the method/constructor is still in-use, the local variable destroys itself when the method/constructor exits.

        // Paramters: They're variables that exist to exclusively pass variables into a method.
        // They are created when the method has a value passed into it; that value is the parameter, it exists as long as its being used in the method, and destroys itself when the code exits the method.

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
        int lowest;
        int highest;

        public void SetLowest(double newLowest)
        {
            lowest = (int)newLowest;
        }

        public void SetHighest(double newHighest)
        {
            highest = (int)newHighest;
        }

        public void Print(bool evod)
        {
            if (lowest < highest)
            {
                for (int i = lowest; i <= highest; i++)
                {
                    if (evod == true)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else if (evod == false)
                    {
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
            Television tele = new Television(null, 1000.17M, 10.5);
            tele.Print();
            Television rele = new Television("Sony", (decimal)1000.17, 10.5);
            rele.Print();
        }
    }

    // We need a class to pass as a parameter for this exercises, so
    // we've whipped up the 'Television' class
    public class Television
    {
        string brandName;
        decimal price;
        double size;

        public Television()
        {
            brandName = "";
            price = 0;
            size = 0;
        }
        public Television(string br, decimal pr, double si)
        {
            SetBrand(br);
            SetPrice(pr);
            SetSize(si);
        }

        public string GetBrand()
        {
            return brandName;
        }
        public void SetBrand(string newValue)
        {
            if (newValue != null)
            {
                brandName = newValue;
            }
            else brandName = "";
        }

        public decimal GetPrice()
        {
            return price;
        }
        public void SetPrice(decimal newPrice)
        {
            if (newPrice > 0)
            {
                price = newPrice;
            }
        }

        public double GetSize()
        {
            return size;
        }
        public void SetSize(double newSize)
        {
            if (newSize > 0)
            {
                size = newSize;
            }
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
        public void PrintArrayOfTVs()
        {
            Television[] aBunchOfTVs = new Television[5];
            for (int i = 0; i < aBunchOfTVs.Length; i++)
            {
                aBunchOfTVs[i] = new Television("Brand X", 10+i, 42.0);
                aBunchOfTVs[i].Print();
            }
        }

        public void PrintArrayOfPossiblyNullTVs()
        {
            Television[] aBunchOfTVs = new Television[10];
            aBunchOfTVs[0] = new Television("Brand X", 10, 42.0);
            aBunchOfTVs[1] = new Television("Brand X", 11, 42.0);
            aBunchOfTVs[5] = new Television("Brand X", 15, 42.0);
            aBunchOfTVs[9] = new Television("Brand X", 19, 42.0);
            for (int i = 0; i < aBunchOfTVs.Length; i++)
            {
                if (aBunchOfTVs[i] != null)
                    aBunchOfTVs[i].Print();
                //This is to check if the slot in the array is 'null', if it isn't in this case, print it.
                else
                {
                    aBunchOfTVs[i] = new Television("Brand X", 10+i, 42.0);
                    aBunchOfTVs[i].Print();
                    //this is to check if the slot in the array is 'null'. If it is in this case, fill it, then print it.
                }
            }
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
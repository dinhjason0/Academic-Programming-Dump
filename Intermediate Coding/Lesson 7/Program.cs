using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // BarChart_Demonstration bcd = new BarChart_Demonstration();
            // bcd.RunExercise();

            // TVStorage_Demonstration tvsd_d = new TVStorage_Demonstration();
            // tvsd_d.RunExercise();

            Basic_Inheritance bi = new Basic_Inheritance();
            bi.RunExercise();

            Constructors_Calling_One_From_Another ccofa = new Constructors_Calling_One_From_Another();
            ccofa.RunExercise();

            Calling_Methods_In_Base_Class cmibc = new Calling_Methods_In_Base_Class();
            cmibc.RunExercise();

            Inheritance_Constructors ic = new Inheritance_Constructors();
            ic.RunExercise();

            Explain_Basic_Polymorphism ebp = new Explain_Basic_Polymorphism();
            ebp.RunExercise();

            Create_Basic_Polymorphic_Method cbpm = new Create_Basic_Polymorphic_Method();
            cbpm.RunExercise();

            Polymorphism_And_Arrays paa = new Polymorphism_And_Arrays();
            paa.RunExercise();

            Overriding_ToString ot = new Overriding_ToString();
            ot.RunExercise();

            ToString_And_Arrays taa = new ToString_And_Arrays();
            taa.RunExercise();
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
                // TODO: Implement this!!
                return Double.MinValue;
            }

            public void PrintBarChart()
            {
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

        // We need a class to pass as a parameter for this exercises, so
        // we're using the 'Television' class
        // PLEASE COPY THIS FROM YOUR PRIOR PCE!
        // I've included just enough code here so that this project compiles, but you'll
        // need the full implementation from the prior class
        public class Television
        {
            public Television() 
            {
            }
            public Television(string br, decimal pr, double si)
            {
            }
        }

        public class TVStorage
        {
            Television[] tvs = new Television[5];

            public TVStorage()
            {
            }

            // TODO: Implement this method!
            // If the location is invalid (negative, or too large) do nothing.
            // If the parameter is null (and the location is ok), then replace
            //      the object reference in the array with null
            public void StoreTV(int iLocation, Television tvToStore)
            {
            }

            // TODO: Implement this method!
            // If the location is invalid (negative, or too large) return null.
            public Television GetTV(int iLocation)
            {
                return new Television(); // odd, but will guarantee all tests fail, to start
            }

            // TODO: Implement this method!
            // If a given slot in the array is non-NULL, then call .Print on it
            // otherwise, print out "Slot X is null", where X is the slot index.
            public void PrintAllTVs()
            {
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


        class Basic_Inheritance
        {
            public void RunExercise()
            {
                Car c1 = new Car(2000.25m, 10.00m);
                c1.Print();
                F250 f1 = new F250(2000.25m, 10.00m, 200.70m);
                f1.F250Print();
                Prius p1 = new Prius(2000.25m, 10.00m, 200.70m, 108);
                p1.PriusPrint();
            }
        }

        class Car
        {
            private decimal weight;
            private decimal gasTankSize;

            public void setWeight(decimal newWeight)
            {
                if (newWeight >= 0)
                    weight = newWeight;
                else weight = 0;
            }
            public decimal getWeight()
            {
                return weight;
            }
            public void setTankSize(decimal newTankSize)
            {
                if (newTankSize >= 0)
                    gasTankSize = newTankSize;
                else gasTankSize = 0;
            }
            public decimal getTankSize()
            {
                return gasTankSize;
            }

            public Car()
            {
                setWeight(0);
                setTankSize(0);
            }
            public Car(decimal kekWeight, decimal kekTank)
            {
                setWeight(kekWeight);
                setTankSize(kekTank);
            }
            public void Print()
            {
                Console.WriteLine("Weight: {0:0.00}", getWeight());
                Console.WriteLine("Gas Tank: {0:0.00}", getTankSize());
                Console.WriteLine();
            }
        }

        class F250:Car
        {
            private decimal cargo;
            
            public void setCargo(decimal newCargo)
            {
                if (newCargo >= 0)
                    cargo = newCargo;
                else cargo = 0;
            }
            public decimal getCargo()
            {
                return cargo;
            }

            public F250()
            {
                setWeight(0);
                setTankSize(0);
                setCargo(0);
            }
            public F250(decimal kekWeight, decimal kekTank, decimal kekCargo)
            {
                setWeight(kekWeight);
                setTankSize(kekTank);
                setCargo(kekCargo);
            }

            public void F250Print()
            {
                Console.WriteLine("Weight: {0:0.00}", getWeight());
                Console.WriteLine("Gas Tank: {0:0.00}", getTankSize());
                Console.WriteLine("Max Cargo: {0:0.0}", getCargo());
                Console.WriteLine();
            }
        }

        class Prius : F250
        {
            private int children;

            public void setChildren(int newChildren)
            {
                if (newChildren >= 0)
                    children = newChildren;
                else children = 0;
            }
            public int getChildren()
            {
                return children;
            }

            public Prius()
            {
                setWeight(0);
                setTankSize(0);
                setCargo(0);
                setChildren(0);
            }
            public Prius(decimal kekWeight, decimal kekTank, decimal kekCargo, int kekChildren)
            {
                setWeight(kekWeight);
                setTankSize(kekTank);
                setCargo(kekCargo);
                setChildren(kekChildren);
            }

            public void PriusPrint()
            {
                Console.WriteLine("Weight: {0:0.00}", getWeight());
                Console.WriteLine("Gas Tank: {0:0.00}", getTankSize());
                Console.WriteLine("Max Cargo: {0:0.00}", getCargo());
                Console.WriteLine("Children that come with Prius: {0:0}", getChildren());
                Console.WriteLine();
            }
        }

        class Constructors_Calling_One_From_Another
        {
            public void RunExercise()
            {
                HomeElectronicsDevice hed1 = new HomeElectronicsDevice();
                HomeElectronicsDevice hed2 = new HomeElectronicsDevice(4.55m, 45555555555555.5555);
                TV tehve1 = new TV();
                TV tehve2 = new TV(4.555);
                TV tehve3 = new TV(6.5155, 23.44m, 4123.444);
                GameConsole gc1 = new GameConsole();
                GameConsole gc2 = new GameConsole(91.11m);
                GameConsole gc3 = new GameConsole(66.44m, 41241234.14m, 444.44444444444444444444);
                Console.WriteLine("The generic home electronics\n-------------------------");
                hed1.Print();
                hed2.Print();
                Console.WriteLine("The televisions\n------------------------------");
                tehve1.Print();
                tehve2.Print();
                tehve3.Print();
                Console.WriteLine("The game consoles\n---------------------------");
                gc1.Print();
                gc2.Print();
                gc3.Print();
            }
        }

        class HomeElectronicsDevice
        {
            private decimal price;
            private double weight;

            public void setPrice(decimal newPrice)
            {
                if (newPrice >= 0)
                    price = newPrice;
                else price = 0;
            }
            public decimal getPrice()
            {
                return price;
            }
            public void setWeight(double newWeight)
            {
                if (newWeight >= 0)
                    weight = newWeight;
                else weight = 0;
            }
            public double getWeight()
            {
                return weight;
            }

            public HomeElectronicsDevice(decimal pr, double we)
            {
                setPrice(pr);
                setWeight(we);
            }
            public HomeElectronicsDevice() : this(4.99m, 5.55555555555555555)
            {

            }

            public void Print()
            {
                Console.WriteLine("Price: {0:0.00}", getPrice());
                Console.WriteLine("Weight: {0:0.00}", getWeight());
                Console.WriteLine();
            }
        }

        class TV : HomeElectronicsDevice
        {
            private double screenSize;

            public void setScreenSize(double newScreenSize)
            {
                if (newScreenSize >= 0)
                    screenSize = newScreenSize;
                else screenSize = 0;
            }
            public double getScreenSize()
            {
                return screenSize;
            }

            public TV() : base()
            {
                setScreenSize(0);
            }
            public TV(double ss) : base (1100.45m, 15.554)
            {
                setScreenSize(ss);
            }
            public TV(double ss, decimal pr, double we) : base (pr, we)
            {
                setScreenSize(ss);
            }

            public void Print()
            {
                Console.WriteLine("Price: {0:0.00}", getPrice());
                Console.WriteLine("Weight: {0:0.00}", getWeight());
                Console.WriteLine("Screen Size: {0:0.00}", getScreenSize());
                Console.WriteLine();
            }
        }

        class GameConsole : HomeElectronicsDevice
        {
            private decimal speedCPU;

            public void setCPUSpeed(decimal newCPUSpeed)
            {
                if (newCPUSpeed >= 0)
                    speedCPU = newCPUSpeed;
                else speedCPU = 0;
            }
            public decimal getCPUSpeed()
            {
                return speedCPU;
            }

            public GameConsole() : base()
            {
                setCPUSpeed(0);
            }
            public GameConsole(decimal sc) : base (400m, 8.5444)
            {
                setCPUSpeed(sc);
            }
            public GameConsole(decimal sc, decimal pr, double we) : base (pr, we)
            {
                setCPUSpeed(sc);
            }

            public void Print()
            {
                Console.WriteLine("Price: {0:0.00}", getPrice());
                Console.WriteLine("Weight: {0:0.00}", getWeight());
                Console.WriteLine("Game Console's CPU Speed: {0}", getCPUSpeed());
                Console.WriteLine();
            }
        }

        class Calling_Methods_In_Base_Class
        {
            public void RunExercise()
            {
                Plane p1 = new Plane();
                Plane p2 = new Plane(10, 12001.50);
                JetPlane jp1 = new JetPlane();
                JetPlane jp3 = new JetPlane(20);
                JetPlane jp2 = new JetPlane(20, 10, 12001.50);
                Console.WriteLine("Planes\n-----------------------");
                p1.Print();
                Console.WriteLine();
                p2.Print();
                Console.WriteLine();
                Console.WriteLine("JetPlanes\n---------------------------");
                jp1.Print();
                jp2.Print();
                jp3.Print();

                //THIS IS MY TAKE ON THE DEFINITION FOR THE 'new' KEYWORD MEANS
                //'new' creates a new instance of the object you're targeting to initialize a 'new' invocation of it.
                //
                //THIS IS MY TAKE ON THE DEFINITION FOR THE 'base' CONSEQUENCES OF TAKING IT OUT
                //It called a 'StackOverflowException', and this is happenstance to the Print() calling itself along with calling its' base.
                //
            }
        }

        class Plane
        {
            private int passengers;
            private double luggageWeight;

            public void setPassengers(int newPassengers)
            {
                if (newPassengers >= 0)
                    passengers = newPassengers;
                else passengers = 0;
            }
            public int getPassengers()
            {
                return passengers;
            }
            public void setLuggageWeight(double newLuggageWeight)
            {
                if (newLuggageWeight >= 0)
                    luggageWeight = newLuggageWeight;
                else luggageWeight = 0;
            }
            public double getLuggageWeight()
            {
                return luggageWeight;
            }

            public Plane() : this (0, 0)
            {
            }
            public Plane(int pa, double lw)
            {
                setPassengers(pa);
                setLuggageWeight(lw);
            }

            public void Print()
            {
                Console.WriteLine("NumPassengers: {0:0.00}", passengers);
                Console.WriteLine("Weight: {0:0.00}", luggageWeight);
            }
        }

        class JetPlane : Plane
        {
            private int engines;

            public void setEngines(int newEngines)
            {
                engines = newEngines;
            }
            public int getEngines()
            {
                return engines;
            }

            public JetPlane(int en, int pa, double lw) : base(pa, lw)
            {
                setEngines(en);
            }

            public JetPlane(int en) : base()
            {
                setEngines(en);
            }

            public JetPlane() : this(0)
            {
            }

            public void Print()
            {
                base.Print();//This calls Planes' Print()
                Console.WriteLine("NumEngines: {0:0}", getEngines());
                Console.WriteLine();
            }
        }

        class Inheritance_Constructors
        {
            public void RunExercise()
            {
                Saw s1 = new Saw();
                Saw s2 = new Saw(9);
                ElectricSaw es1 = new ElectricSaw();
                ElectricSaw es2 = new ElectricSaw(9);
                ElectricSaw es3 = new ElectricSaw(44.5, 8);

                Console.WriteLine("Saw\n--------------------------------");
                s1.Print();
                Console.WriteLine();
                s2.Print();
                Console.WriteLine();
                Console.WriteLine("Electric Saw\n------------------------------");
                es1.Print();
                Console.WriteLine();
                es2.Print();
                Console.WriteLine();
                es3.Print();
                Console.WriteLine();
            }
        }

        class Saw
        {
            private int sharpness;

            public void setSharpness(int newSharpness)
            {
                if (newSharpness >= 1 && newSharpness <= 10)
                {
                    sharpness = newSharpness;
                }
                else sharpness = 5;
            }
            public int getSharpness()
            {
                return sharpness;
            }

            public Saw(int sh)
            {
                setSharpness(sh);
            }
            public Saw() : this (5)
            {

            }

            public void Print()
            {
                Console.WriteLine("Sharpness: {0:0}", getSharpness());
            }
        }

        class ElectricSaw : Saw
        {
            private double cord;

            public void setCord(double newCord)
            {
                if (newCord >= 0)
                    cord = newCord;
                else cord = 20;
            }
            public double getCord()
            {
                return cord;
            }

            public ElectricSaw() : base(6)
            {
                setCord(0);
            }
            public ElectricSaw(int sh) : base (sh)
            {
                setCord(20);
            }
            public ElectricSaw(double co, int sh) : base (sh)
            {
                setCord(co);
            }

            public void Print()
            {
                base.Print();
                Console.WriteLine("Cord Length: {0:00}", getCord());
            }

            public override string ToString()
            {
                string rent = "Sharpness: " + getSharpness() + "\nCord Length: " + getCord();
                return rent;
            }
        }

        // The comments you need to fill in are inside RunExercise, below:
        class Explain_Basic_Polymorphism
        {
            public void RunExercise()
            {
                BaseClass bcRef1 = new BaseClass();
                BaseClass bcRef2 = new DerrivedClassOne();
                BaseClass bcRef3 = new TheOtherDerrivedClass();

                Console.WriteLine("variables is of type BaseClass, object is of type BaseClass:");
                bcRef1.VirtualMethod1();
                // What output does the prior line produce?  Paste it in here:
                // BaseClass.VirtualMethod1!

                // Why does bcRef1.VirtualMethod1 produce that output?  Which method is it calling, and why?
                // YOUR ANSWER:
                // The BaseClass object is refering to the BaseClass.VirtualMethod in the BaseClass(), so nothing unnatural
                bcRef1.VirtualMethodTWO();
                // What output does the prior line produce?  Paste it in here:
                // BaseClass.VirtualMethodTWO!

                // Why does bcRef1.VirtualMethodTWO produce that output?  Which method is it calling, and why?
                // YOUR ANSWER:
                //The BaseClass object in this case is still refering to BaseClass(), so nothing unusual occurs. Just calls.

                Console.WriteLine("variables is of type BaseClass, object is of type DerrivedClassOne:");
                bcRef2.VirtualMethod1();
                // What output does the prior line produce?  Paste it in here:
                // DerivedClassOne.VirtualMethod1
                // BaseClass.VirtualMethod1!

                // Why does bcRef2.VirtualMethod1 produce that output?  Which method is it calling, and why?
                // YOUR ANSWER:
                // The BaseClass objects reads which VirtualMethod1() method is 'more specialized' of the children
                // It finds that there's an override available to the virtual signature within the base class.
                // Thus it uses that now polymorphed method, and prints the Console.WriteLine()
                // On the next line however, it calls the base.Print(), which calls its print() method from it's Superclass
                bcRef2.VirtualMethodTWO();
                // What output does the prior line produce?  Paste it in here:
                // BaseClass.VirtualMethodTWO!

                // Why does bcRef2.VirtualMethodTWO produce that output?  Which method is it calling, and why?
                // YOUR ANSWER:
                // Because there is no override present in the DerivedClassOne() object from BaseClass()
                // They can't use the child's class for this method, so they use their parent class'.

                Console.WriteLine("variables is of type BaseClass, object is of type TheOtherDerrivedClass:");
                bcRef3.VirtualMethod1();
                // What output does the prior line produce?  Paste it in here:
                // BaseClass.VirtualMethod1!

                // Why does bcRef3.VirtualMethod1 produce that output?  Which method is it calling, and why?
                // YOUR ANSWER:
                // Because the child class that is being invoked from the object without a method of that address
                // It'll use their parent.
                bcRef3.VirtualMethodTWO();
                // What output does the prior line produce?  Paste it in here:
                // TheOtherDerrivedClass.VirtualMethodTWO

                // Why does bcRef3.VirtualMethodTWO produce that output?  Which method is it calling, and why?
                // YOUR ANSWER:
                // When the object is called, it uses it's polymorphed child class because they're overriding the method
                // that is available.
            }
        }
        class BaseClass
        {
            public virtual void VirtualMethod1()
            {
                Console.WriteLine("BaseClass.VirtualMethod1!");
            }
            // This is here just to show you that virtual & public can be in either order
            // void (the return type) needs to go immediately prior to the method name, though
            // (try something like public void virtual, and note the compiler errors you get)
            virtual public void VirtualMethodTWO()
            {
                Console.WriteLine("BaseClass.VirtualMethodTWO!");
            }
        }
        class DerrivedClassOne : BaseClass
        {
            public override void VirtualMethod1()
            {
                Console.WriteLine("DerrivedClassOne.VirtualMethod1");
                base.VirtualMethod1();
            }
        }
        class TheOtherDerrivedClass : BaseClass
        {
            public override void VirtualMethodTWO()
            {
                Console.WriteLine("TheOtherDerrivedClass.VirtualMethodTWO");
            }
        }

        public class Create_Basic_Polymorphic_Method
        {
            public void RunExercise()
            {
                LightBulb lb1 = new IncandescentLightBulb();
                LightBulb lb2 = new FluorescentLightBulb();
                Console.WriteLine();
                Console.WriteLine("The light of an incadescent at an amp of 4 is: {0}\n" +
                    "The heat of the same lightbulb with the same amplitude is: {1}", lb1.CalculateLight(4), lb1.CalculateHeat(4));
                Console.WriteLine("The light of an fluorescent at an amp of 4 is: {0}\n" +
                    "The heat of the same lightbulb with the same amplitude is: {1}", lb2.CalculateLight(4), lb2.CalculateHeat(4));
            }
        }

        public class LightBulb
        {
            virtual public double CalculateLight(double amps)
            {
                // We want to start by returning something that will cause the tests to fail.
                // Not A Number (NaN) is a good choice for that :)
                return Double.NaN;
            }
            public virtual double CalculateHeat(double amps)
            {
                return Double.NaN;
            }
        }
        public class IncandescentLightBulb : LightBulb
        {
            private double heat;
            private double light;
            public override double CalculateLight(double amps)
            {
                return Math.Pow(amps * 3 + 1, 2) / amps;
            }
            public override double CalculateHeat(double amps)
            {
                return Math.Sqrt(amps * 7);
            }

            public IncandescentLightBulb() : this (0)
            {

            }
            public IncandescentLightBulb(double amp)
            {
                if (amp >= 0)
                {
                    heat = CalculateHeat(amp);
                    light = CalculateLight(amp);
                }
                else
                {
                    heat = CalculateHeat(0);
                    light = CalculateLight(0);
                }
            }

            public override string ToString()
            {
                string rest = "Light Level: " + light + "\nHeat Level: " + heat;
                return rest;
            }
        }
        public class FluorescentLightBulb : LightBulb
        {
            public override double CalculateLight(double amps)
            {
                return Math.Pow(amps, 2) * 3;
            }
            public override double CalculateHeat(double amps)
            {
                return Math.Sqrt(Math.Sqrt(amps * 7));
            }
        }


        class Polymorphism_And_Arrays
        {
            public void RunExercise()
            {
                // This will create 10 spaces, each of which is a blank reference to 
                // a GeneralPrinter.
                GeneralPrinter[] gps = new GeneralPrinter[10];

                gps[1] = new GeneralPrinter();
                gps[2] = new GeneralPrinter(21);
                gps[3] = new SpecificPrinter();
                gps[7] = new SpecificPrinter();
                gps[2] = new GeneralPrinter(400);
                gps[7] = new SpecificPrinter();
                gps[2] = new GeneralPrinter(66);
                gps[2] = new GeneralPrinter(31);
                gps[7] = new SpecificPrinter();
                gps[6] = new GeneralPrinter(1111111);
                gps[7] = new SpecificPrinter();

                for (int i = 0; i < gps.Length; i++)
                {
                    if (gps[i] != null)
                        gps[i].PrintTheMessage();
                }
            }
        }
        public class GeneralPrinter
        {
            private int data; // mostly, we just want to see that there are, in fact,
            // separate objects

            public GeneralPrinter()
            {
                data = 99;
            }
            public GeneralPrinter(int n) // in case you want to create a GP with a specific data value...
            {
                data = n;
            }
            virtual public void PrintTheMessage()
            {
                Console.WriteLine("GeneralPrinter.PrintTheMessage: This is my general message.  My data:{0}", data);
            }
        }
        public class SpecificPrinter : GeneralPrinter
        {
            public override void PrintTheMessage()
            {
                Console.WriteLine("Message from a specific printer object!");
            }
        }


        class Overriding_ToString
        {
            public void RunExercise()
            {
                MyPoint p = new MyPoint(3, 7.6);

                Console.WriteLine("Your point is at:" + p.ToString());
                Console.WriteLine("Your point is at:{0}", p.ToString());
                Console.WriteLine("Your point is at:" + p);
                Console.WriteLine("Your point is at:{0}", p);
                //THE POINT
                //Your point is at:PCE_StarterProject.Program+MyPoint
                //Your point is at:PCE_StarterProject.Program + MyPoint
                //Your point is at:PCE_StarterProject.Program + MyPoint
                //Your point is at:PCE_StarterProject.Program + MyPoint
            }
        }
        public class MyPoint
        {
            double x;
            double y;
            public MyPoint(double nX, double nY)
            {
                x = nX;
                y = nY;
            }
            double getX()
            {
                return x;
            }
            void setX(double nx)
            {
                x = nx;
            }

            double getY() { return y; }
            void setY(double ny) { y = ny; }

            public override string ToString()
            {
                string ret = "(" + x + "," + y + ")";
                return ret;
            }
        }

        class ToString_And_Arrays
        {
            public void RunExercise()
            {
                Object[] objs = new Object[6];
                objs[0] = new MyPoint(1, 2);
                objs[1] = new IncandescentLightBulb(10); // amps, maybe?
                objs[2] = new MyPoint(4, 7);
                objs[3] = new IncandescentLightBulb(20); // amps, maybe?
                objs[4] = new ElectricSaw();
                objs[5] = new ElectricSaw(4.5, 4);
                for (int i = 0; i < objs.Length; i++)
                {
                    string s = objs[i].ToString();
                    Console.WriteLine(s);
                }
            }
        }
    }
}
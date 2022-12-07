using System;
// if you want to use the instructor's version of "MyDate":
//using Date_SOLUTION; // leave this line UNcommented
using MyDate_StudentWork;  // and comment this line out.
//If you want to use your version of "MyDate" then comment out "using TEACHER_SOLUTION;" 
// and UNcomment "using Date_StudentWork";

namespace A3_Date
{
    class Birthday
    {
        static void Main(string[] args)
        {
            MyDate today;
            int todayMonth;
            int todayDay;

            MyDate bday;
            int bdayMonth;
            int bdayDay;

            Console.WriteLine("What is today's month?");
            todayMonth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is today's day?");
            todayDay = Int32.Parse(Console.ReadLine());
            MyDate Chernobog = new MyDate(todayMonth, todayDay);

            Console.WriteLine("What is your birthday month?");
            bdayMonth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is your birthday day?");
            bdayDay = Int32.Parse(Console.ReadLine());
            MyDate Tetsunade = new MyDate(bdayMonth, bdayDay);




            // REMEMBER TO TEST OUT YOUR CODE WITH _BOTH_ THE INSTRUCTOR'S
            // VERSION _AND_ YOUR VERSION!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // (there are more details at the top of this file)

            TestMyDate(); // this jumps down to the 'TestMyDate' method, below:

            if (Chernobog.equals(Tetsunade.getMonth(), Tetsunade.getDay()) == true)
            {
                Console.WriteLine("=== Btw, Happy Birthday. ^_^ ===\n");
            }
            else
            {
                int i = 0;
                int o = Chernobog.getDay();
                int e = Chernobog.getMonth();
                int g = Chernobog.daysInMonth();

                while (Chernobog.equals(Tetsunade.getMonth(), Tetsunade.getDay()) == false)
                {
                    o++;
                    Chernobog = new MyDate(e, o);

                    if (o > g)
                    {
                        o = 1;
                        e++;
                        Chernobog = new MyDate(e, o);
                    }
                    if (e > 13)
                    {
                        e = 1;
                        o = 1;
                        Chernobog = new MyDate(e, o);
                    }

                    g = Chernobog.daysInMonth();

                    i++;
                }

                Console.WriteLine("=== {0} days until your birthday ===\n", i);
            }


        }

        public static void TestMyDate()
        {
            // There's a lot of tests here
            // It's easy to miss one
            // I'd like the program to tell me if anything failed
            // so I can go back and check the tests in detail to figure out which one failed

            // This variable will start out 'false'
            // When any test fails it will be set to 'true'
            // At the end I'll print out a single, easy-to-find message summarizing whether
            // anything failed or not
            int numberOfFailingTests = 0;

            Console.WriteLine("Test the The MyDate() constructor (the one with no parameters)");
            MyDate testObject = new MyDate();
            if (testObject.getDay() == 1)
                Console.WriteLine("\tTEST PASSED: new MyDate() correctly stored '1' for the day");
            else
            {
                Console.WriteLine("\tTEST FAILED: new MyDate() did NOT store '1' for the day (but it should have)(instead, it stored {0}", testObject.getDay());
                numberOfFailingTests++;
            }

            if (testObject.getMonth() == 1)
                Console.WriteLine("\tTEST PASSED: new MyDate() correctly stored '1' for the month");
            else
            { 
                Console.WriteLine("\tTEST FAILED: new MyDate() did NOT store '1' for the month (but it should have)(instead, it stored {0}", testObject.getMonth());
                numberOfFailingTests++;
            }

            Console.WriteLine("Now test The MyDate(3,2) constructor (the one with two parameters)");
            // change the testObject variable to now refer to a new object:
            testObject = new MyDate(3, 2);
            if (testObject.getDay() == 2)
                Console.WriteLine("\tTEST PASSED: new MyDate(3, 2) correctly stored '2' for the day");
            else
            {
                Console.WriteLine("\tTEST FAILED: new MyDate(3, 2) did NOT store '2' for the day (but it should have)(instead, it stored {0}", testObject.getDay());
                numberOfFailingTests++;
            }

            if (testObject.getMonth() == 3)
                Console.WriteLine("\tTEST PASSED: new MyDate(3, 2) correctly stored '3' for the month");
            else
            { 
                Console.WriteLine("\tTEST FAILED: new MyDate(3, 2) did NOT store '3' for the month (but it should have)(instead, it stored {0}", testObject.getMonth());
                numberOfFailingTests++;
            }

            Console.WriteLine("Now test The MyDate(22, 33) constructor (the one with two parameters)");
            // This should create a date for Jan 1st.
            // Because the month (22) is out of range, the month should be set to 1
            // Because the day (33) is out of range _for_January, the day should be set to 1
            testObject = new MyDate(22, 33);
            if (testObject.getDay() == 1)
                Console.WriteLine("\tTEST PASSED: new MyDate(22, 33) correctly stored '1' for the day");
            else
            {
                Console.WriteLine("\tTEST FAILED: new MyDate(22, 33) did NOT store '1' for the day (but it should have)(instead, it stored {0}", testObject.getDay());
                numberOfFailingTests++;
            }


            if (testObject.getMonth() == 1)
                Console.WriteLine("\tTEST PASSED: new MyDate(22, 33) correctly stored '1' for the month");
            else
            {
                Console.WriteLine("\tTEST FAILED: new MyDate(22, 33) did NOT store '1' for the month (but it should have)(instead, it stored {0}", testObject.getMonth());
                numberOfFailingTests++;
            }

            Console.WriteLine("Now test The MyDate(22, 14) constructor (the one with two parameters)");
            // This should create a date for Jan 14th.
            // Because the month (22) is out of range, the month should be set to 1
            // Because the day (14) is out of range _for_January, the day should be set to 14
            testObject = new MyDate(22, 14);
            if (testObject.getDay() == 14)
                Console.WriteLine("\tTEST PASSED: new MyDate(22, 14) correctly stored '14' for the day");
            else
            {
                Console.WriteLine("\tTEST FAILED: new MyDate(22, 14) did NOT store '14' for the day (but it should have)(instead, it stored {0}", testObject.getDay());
                numberOfFailingTests++;
            }

            if (testObject.getMonth() == 1)
                Console.WriteLine("\tTEST PASSED: new MyDate(22, 14) correctly stored '1' for the month");
            else
            {
                Console.WriteLine("\tTEST FAILED: new MyDate(22, 14) did NOT store '1' for the month (but it should have)(instead, it stored {0}", testObject.getMonth());
                numberOfFailingTests++;
            }

            Console.WriteLine("Now test The MyDate(6, 31) constructor (the one with two parameters)");
            // This should create a date for Jun 1st.
            // Because the month (6) is in range, the month should be set to 6
            // Because the day (31) is out of range _for_June_, the day should be set to 1
            testObject = new MyDate(6, 31);
            if (testObject.getDay() == 1)
                Console.WriteLine("\tTEST PASSED: new MyDate(6, 31) correctly stored '1' for the day");
            else
            {
                Console.WriteLine("\tTEST FAILED: new MyDate(6, 31) did NOT store '1' for the day (but it should have)(instead, it stored {0}", testObject.getDay());
                numberOfFailingTests++;
            }

            if (testObject.getMonth() == 6)
                Console.WriteLine("\tTEST PASSED: new MyDate(6, 31) correctly stored '6' for the month");
            else
            {
                Console.WriteLine("\tTEST FAILED: new MyDate(6, 31) did NOT store '6' for the month (but it should have)(instead, it stored {0}", testObject.getMonth());
                numberOfFailingTests++;
            }

            // NOTE: Your instructor may test other combinations of months & days, in addition to what's listed here
            // MAKE SURE THAT YOUR CODE WORKS ACCORDING TO THE SPECIFICATION,
            // Regardless of the tests that are (or aren't) here


            // SetDate
            Console.WriteLine("Now test The SetDate(8, 12) method");
            // This should set the date to August (month 8) 12th
            testObject = new MyDate(); // start with a fresh object
            testObject.setDate(8, 12);
            if (testObject.getDay() == 12)
                Console.WriteLine("\tTEST PASSED: testObject.setDate(8, 12) correctly copied '12' for the day");
            else
            {
                Console.WriteLine("\tTEST FAILED: testObject.setDate(8, 12) did NOT store '12' for the day (but it should have)(instead, it stored {0}", testObject.getDay());
                numberOfFailingTests++;
            }

            if (testObject.getMonth() == 8)
                Console.WriteLine("\tTEST PASSED: testObject.setDate(8, 12) correctly stored '8' for the month");
            else
            {
                Console.WriteLine("\tTEST FAILED: testObject.setDate(8, 12) did NOT store '8' for the month (but it should have)(instead, it stored {0}", testObject.getMonth());
                numberOfFailingTests++;
            }

            Console.WriteLine("Now test The SetDate(8, 32) method");
            // This should set the date to August (month 8) 1st
            // 8 is a valid month, but 32 isn't a valid day, so it should set the day to 1
            testObject = new MyDate(); // start with a fresh object
            testObject.setDate(8, 32);
            if (testObject.getDay() == 1)
                Console.WriteLine("\tTEST PASSED: testObject.setDate(8, 32) correctly copied '1' for the day");
            else
            {
                Console.WriteLine("\tTEST FAILED: testObject.setDate(8, 32) did NOT store '1' for the day (but it should have)(instead, it stored {0}", testObject.getDay());
                numberOfFailingTests++;
            }

            if (testObject.getMonth() == 8)
                Console.WriteLine("\tTEST PASSED: testObject.setDate(8, 32) correctly stored '8' for the month");
            else
            {
                Console.WriteLine("\tTEST FAILED: testObject.setDate(8, 32) did NOT store '8' for the month (but it should have)(instead, it stored {0}", testObject.getMonth());
                numberOfFailingTests++;
            }

            Console.WriteLine("Now test The SetDate(-1, -10) method");
            // This should set the date to January (month 1) 1st
            // -1 is NOT a valid month, so set the month to 1
            // -10 isn't a valid day, so it should set the day to 1
            testObject = new MyDate(); // start with a fresh object
            testObject.setDate(-1, -10);
            if (testObject.getDay() == 1)
                Console.WriteLine("\tTEST PASSED: testObject.setDate(-1, -10) correctly set '1' for the day");
            else
            {
                Console.WriteLine("\tTEST FAILED: testObject.setDate(-1, -10) did NOT store '1' for the day (but it should have)(instead, it stored {0}", testObject.getDay());
                numberOfFailingTests++;
            }

            if (testObject.getMonth() == 1)
                Console.WriteLine("\tTEST PASSED: testObject.setDate(-1, -10) correctly stored '1' for the month");
            else
            {
                Console.WriteLine("\tTEST FAILED: testObject.setDate(-1, -10) did NOT store '1' for the month (but it should have)(instead, it stored {0}", testObject.getMonth());
                numberOfFailingTests++;
            }

            // toString
            Console.WriteLine("Now test The toString() method");
            testObject = new MyDate(10, 11); // start with a fresh object
            string resultOfToString = testObject.toString();
            if( resultOfToString == "10/11")
                Console.WriteLine("\tTEST PASSED: testObject.toString() correctly produced 10/11");
            else
            {
                Console.WriteLine("\tTEST FAILED: testObject.toString() did NOT produce 10/11 (but it should have)(instead, it produced {0}", 
                    resultOfToString);
                numberOfFailingTests++;
            }

            // equals - should return true
            Console.WriteLine("Now test The equals() method on two objects with the SAME information");
            testObject = new MyDate(11, 28); // start with a fresh object
            MyDate testObject_2_ = new MyDate(11, 28);
            if (testObject.equals(testObject_2_.getMonth(), testObject_2_.getDay()) == true)
                Console.WriteLine("\tTEST PASSED: testObject.equals(testObject_2_) correctly said two objects with the same information were equal!");
            else
            {
                Console.WriteLine("\tTEST FAILED: testObject.equals(testObject_2_) said two objects with the same information were NOT equal, but it should have said that they were equal!");
                numberOfFailingTests++;
            }

            // equals - should return false when months don't match
            Console.WriteLine("Now test The equals() method on two objects with the DIFFERENT months");
            testObject = new MyDate(11, 28); // start with a fresh object
            testObject_2_ = new MyDate(10, 28);
            if (testObject.equals(testObject_2_.getMonth(), testObject_2_.getDay()) == false)
                Console.WriteLine("\tTEST PASSED: testObject.equals(testObject_2_) correctly said two objects with different months were different!");
            else
            {
                Console.WriteLine("\tTEST FAILED: testObject.equals(testObject_2_) said two objects with the different months were equal, but it should have said that they were NOT equal!");
                numberOfFailingTests++;
            }

            // equals - should return false when days don't match
            Console.WriteLine("Now test The equals() method on two objects with the DIFFERENT days");
            testObject = new MyDate(11, 28); // start with a fresh object
            testObject_2_ = new MyDate(11, 7);
            if (testObject.equals(testObject_2_.getMonth(), testObject_2_.getDay()) == false)
                Console.WriteLine("\tTEST PASSED: testObject.equals(testObject_2_) correctly said two objects with different days were different!");
            else
            {
                Console.WriteLine("\tTEST FAILED: testObject.equals(testObject_2_) said two objects with the different days were equal, but it should have said that they were NOT equal!");
                numberOfFailingTests++;
            }

            // daysInMonth - check a 'normal' month
            Console.WriteLine("Now test The daysInMonth() method for November (month 11)");
            testObject = new MyDate(11, 1); // for this test the day doesn't actually matter
            if (testObject.daysInMonth() == 30)
                Console.WriteLine("\tTEST PASSED: testObject.daysInMonth() for November said that the month had 30 days");
            else
            {
                Console.WriteLine("\tTEST FAILED: testObject.daysInMonth() for November did NOT say that the month had 30 days, (but it should have)(instead, it returned {0})", testObject.daysInMonth());
                numberOfFailingTests++;
            }

            // daysInMonth - check February
            Console.WriteLine("Now test The daysInMonth() method for February (month 2)");
            testObject = new MyDate(2, 1); // for this test the day doesn't actually matter
            if (testObject.daysInMonth() == 28)
                Console.WriteLine("\tTEST PASSED: testObject.daysInMonth() for February said that the month had 28 days");
            else
            {
                Console.WriteLine("\tTEST FAILED: testObject.daysInMonth() for February did NOT say that the month had 28 days, (but it should have)(instead, it returned {0})", testObject.daysInMonth());
                numberOfFailingTests++;
            }

            // nextDay - mid-month
            Console.WriteLine("Now test The nextDay() method for the middle of the month (Dec 7th)");
            testObject = new MyDate(12, 7); // for this test the day doesn't actually matter
            testObject.nextDay();

            if (testObject.getMonth() == 12)
                Console.WriteLine("\tTEST PASSED: nextDay() method for the middle of the month (Dec 7th) correctly kept the month as December (12)");
            else
            {
                Console.WriteLine("\tTEST FAILED: nextDay() method for the middle of the month (Dec 7th) did NOT have keep the month as December (12) (but it should have)(instead, it changed the month to {0}",
                    testObject.getMonth());
                numberOfFailingTests++;
            }

            if (testObject.getDay() == 8)
                Console.WriteLine("\tTEST PASSED: nextDay() method for the middle of the month (Dec 7th) correctly changed the day from 7 to 8");
            else
            {
                Console.WriteLine("\tTEST FAILED: nextDay() method for the middle of the month (Dec 7th) did NOT change the day from 7 to 8 (but it should have)(instead, it changed the day is {0}",
                    testObject.getDay());
                numberOfFailingTests++;
            }

            // nextDay - end of month but NOT end of year
            Console.WriteLine("Now test The nextDay() method for the end of the month in the middle of the year (July 31st - > Aug 1st)");
            testObject = new MyDate(7, 31);
            testObject.nextDay();

            if (testObject.getMonth() == 8)
                Console.WriteLine("\tTEST PASSED: nextDay() method for the end of the month in the middle of the year (July 31st - > Aug 1st) correctly moved the month to August (8)");
            else
            {
                Console.WriteLine("\tTEST FAILED: nextDay() method for the end of the month in the middle of the year (July 31st - > Aug 1st) did NOT move the month to August (8) (but it should have)(instead, it changed the month to {0}",
                    testObject.getMonth());
                numberOfFailingTests++;
            }

            if (testObject.getDay() == 1)
                Console.WriteLine("\tTEST PASSED: nextDay() method for nextDay() method the end of the month in the middle of the year (July 31st - > Aug 1st) correctly changed the day from 31 to 1");
            else
            {
                Console.WriteLine("\tTEST FAILED: nextDay() method for nextDay() method the end of the month in the middle of the year (July 31st - > Aug 1st) did NOT change the day from 31 to 1 (but it should have)(instead, it changed the day is {0}",
                    testObject.getDay());
                numberOfFailingTests++;
            }

            // nextDay - end of month at the end of the year
            Console.WriteLine("Now test The nextDay() method for the end of the month at the end of the year (Dec 31st - > Jan 1st)");
            testObject = new MyDate(12, 31);
            testObject.nextDay();

            if (testObject.getMonth() == 1)
                Console.WriteLine("\tTEST PASSED: nextDay() method for the end of the month at the end of the year (Dec 31st - > Jan 1st) correctly moved the month to January (1)");
            else
            {
                Console.WriteLine("\tTEST FAILED: nextDay() method for the end of the month t the end of the year (Dec 31st - > Jan 1st) did NOT move the month to January (1) (but it should have)(instead, it changed the month to {0}",
                    testObject.getMonth());
                numberOfFailingTests++;
            }

            if (testObject.getDay() == 1)
                Console.WriteLine("\tTEST PASSED: nextDay() method for nextDay() method the end of the month at the end of the year (Dec 31st - > Jan 1st) correctly changed the day from 31 to 1");
            else
            {
                Console.WriteLine("\tTEST FAILED: nextDay() method for nextDay() method the end of the month at the end of the year (Dec 31st - > Jan 1st) did NOT change the day from 31 to 1 (but it should have)(instead, it changed the day is {0}",
                    testObject.getDay());
                numberOfFailingTests++;
            }

            Console.WriteLine(); 
            if (numberOfFailingTests > 0)
                Console.WriteLine("==== {0} TESTS FAILED ====\n", numberOfFailingTests);
                // \n means "new line" - it moves down a line, to add some space
            else
                Console.WriteLine("==== All tests passed ====\n");

        }
    }
}

using System;
using System.IO;

namespace PCE_StarterProject
{
    // NOTE: NONE OF THIS CODE WILL WORK UNTIL YOU SET THE 
    // WORKING DIRECTORY IN VISUAL STUDIO.
    // There are instructions in the slides for Input
    // Slide #7, here: http://faculty.cascadia.edu/mpanitz/Courses/BIT142/Lessons/Lesson_08_File_IO/FileIO_Cs_Only_Slides.pptx

    class Program
    {
        static void Main(String[] args)
        {
            File_Exercises fe = new File_Exercises();
            fe.Average();
            fe.FindWord();
            fe.Output_Numbers();
            fe.Output_Maxes();

            SSA name_searcher = new SSA();
            name_searcher.Search();


            SlideExamples_Input_LineByLine se = new SlideExamples_Input_LineByLine();
            //se.Slide_8();
            //se.Slide_14();
            //se.Slide_14_Extra_Example();
            //se.Slide_17();
            //se.Slide_23();
            //se.Slide_26();
            //se.Slide_28();
            //se.Slide_30();
            //se.Slide_32();
            //se.Slide_37();
            //se.Slide_xx_OOP_and_Files();

            SlideExamples_Output so = new SlideExamples_Output();
            // so.Slide_3();
            // so.Slide_4();
            // so.Slide_6();
            // so.Slide_8();
        }
    }

    class File_Exercises
    {
        public void Average()
        {
            double sum = 0, collective = 0;
            TextReader file = new StreamReader("Files\\Exercise_Files\\NumberJumble.txt");
            string theLine;
            char[] delims = { ' ', '\t' };
            while ((theLine = file.ReadLine()) != null)
            {
                string[] tokens = theLine.Split(delims, StringSplitOptions.RemoveEmptyEntries);
                foreach (string token in tokens)
                {
                    double currentDouble;
                    if (Double.TryParse(token, out currentDouble))
                    {
                        sum += currentDouble;
                        Console.WriteLine("Number: {0}", token);
                        collective++;
                    }
                }
            }
            Console.WriteLine("The sum is: {0}", sum);
            Console.WriteLine("The average is: {0}\n", sum / collective);
        }

        public void FindWord()
        {
            TextReader file = new StreamReader("Files\\Exercise_Files\\Words.txt");
            string theLine;
            int escapeKey = 0;
            char[] delims = { ' ', '\t' };
            Console.WriteLine("These are the available words in the pool:\n");
            while ((theLine = file.ReadLine()) != null)
            {
                string[] tokens = theLine.Split(delims, StringSplitOptions.RemoveEmptyEntries);
                foreach (string token in tokens)
                {
                    Console.WriteLine(token);
                }
            }
            file = new StreamReader("Files\\Exercise_Files\\Words.txt");
            Console.WriteLine("Type a word and we'll compare it to the list: ");
            string userInput;
            userInput = Console.ReadLine();
            while ((theLine = file.ReadLine()) != null)
            {
                string[] tokens = theLine.Split(delims, StringSplitOptions.RemoveEmptyEntries);
                foreach (string token in tokens)
                {
                    switch (userInput.ToLower().CompareTo(token.ToLower()))
                    {
                        case 0:
                            Console.WriteLine("The word, \"{0}\" is in the list!", token);
                            escapeKey = 1;
                            break;
                    }
                }
                if (escapeKey == 1) break;
            }
            if (escapeKey == 0) Console.WriteLine("The word isn't in the list...");
        }

        public void Output_Numbers()
        {
            Console.WriteLine("How many integers do you want to print? ");
            int numberOfIntegers, startingInput;
            Int32.TryParse(Console.ReadLine(), out numberOfIntegers);
            Console.WriteLine("What is the first integer that you want printed? ");
            Int32.TryParse(Console.ReadLine(), out startingInput);
            StreamWriter output = new StreamWriter("Files/output_numbers_exercise.txt");
            for (int i = 0; i < numberOfIntegers; i++)
            {
                output.Write("{0} ", startingInput + i);
            }
            output.Dispose();
        }

        public void Output_Maxes()
        {
            string theLine;
            StreamWriter output = new StreamWriter("Files/SSA_Names_Maxes.txt");
            TextReader file = new StreamReader("Files/Exercise_Files/SSA_Names_Short_Find_Max.txt");
            char[] delims = { ' ', '\t' };
            while ((theLine = file.ReadLine()) != null)
            {
                string returnThisString = "";
                int current = 0, previous = 0;
                string[] tokens = theLine.Split(delims, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < tokens.Length; i++)
                {
                    Int32.TryParse(tokens[i], out current);
                    if (current > previous)
                    {
                        previous = current;
                        returnThisString = tokens[0] + " " + (1970 + i - 1);
                    }
                }
                output.WriteLine(returnThisString);
            }
            output.Dispose();
        }
    }

    public class SSA
    {
        public void Search()
        {
            Console.WriteLine("Name to search for?");
            string n = Console.ReadLine();
            int[] setlist = Search(n, "Files/Exercise_Files/SSA_Names_Long.txt");
            if (setlist != null)
                for (int i = 0; i < setlist.Length; i++)
                {
                    Console.Write("{0} ", 1900 + i * 10);
                    Console.WriteLine(setlist[i]);
                }
        }

        public int[] Search(string targetName, string fileName)
        {
            int[] nums = new int[11]; //I wasn't sure if this was suppposed to be a 10 or 11, I just changed it to 11 for the full list.
            TextReader file = new StreamReader(fileName);
            int escapeKey = 0;
            char[] delims = { ' ', '\t' };
            string theLine;
            while ((theLine = file.ReadLine()) != null)
            {
                string[] tokens = theLine.Split(delims, StringSplitOptions.RemoveEmptyEntries);
                foreach (string token in tokens)
                {
                    if (token.ToLower().Equals(targetName.ToLower()))
                    {
                        Console.WriteLine("We found {0}!", token);
                        for (int i = 0; i < nums.Length; i++)
                        {
                            Int32.TryParse(tokens[i + 1], out nums[i]);
                        }
                        escapeKey = 1;
                    }
                }
                if (escapeKey == 1) return nums;
            }
            Console.WriteLine("{0} was not found", Capitilizer(targetName));
            return null;
        }

        public string Capitilizer(string intoThe)
        {
            char[] theSplit = intoThe.ToCharArray();
            for (int i = 0; i < theSplit.Length; i++)
            {
                if (i == 0 || theSplit[i - 1] == ' ')
                {
                    theSplit[i] = char.ToUpper(theSplit[i]);
                }
            }
            string newWord = "";
            for (int i = 0; i < theSplit.Length; i++)
            {
                newWord += theSplit[i];
            }
            return newWord;
        }
    }

    class SlideExamples_Input_LineByLine
    {
        public void Slide_10()
        {
            String path = "Files\\example.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public void Slide_14()
        {
            TextReader name = new StreamReader("Files\\example.txt");
            // The program reads the file here
            name.Dispose();


            // or, using the more concise syntax:
            using (TextReader name2 = new StreamReader("Files\\example.txt"))
            {
            } // name2.Dispose called here automatically

            // using also works with File.OpenText:
            // (this is not in the slide)
            using (TextReader name2 = File.OpenText("Files\\example.txt"))
            {
            } // name2.Dispose called here automatically
        }

        public void Slide_14_Extra_Example()
        {
            // an example of relative paths that use the forward slash:
            string path = "Files/example.txt";
            bool fExists = File.Exists(path);
            Console.WriteLine("Does example.txt exist?  {1}", path, fExists);
        }

        public void Slide_17()
        {
            using (TextReader t = new StreamReader("missing_file.txt"))
            {
                string s = t.ReadLine();
            }
        }

        // This was listed as 'Slide_17' in a video in the PowerPoint slides
        public void Slide_23()
        {
            using (TextReader file = new StreamReader("Files/numbers.txt"))
            {
                for (int i = 0; i < 5; i++)
                {
                    string sLine = file.ReadLine();
                    Console.WriteLine("{0}<", sLine);
                }
            }
        }

        public void Slide_26()
        {
            using (TextReader file = new StreamReader("Files/numbers.txt"))
            {
                double sum = 0.0;
                for (int i = 0; i < 5; i++)
                {
                    string sLine = file.ReadLine();
                    double dNum;
                    if (Double.TryParse(sLine, out dNum))
                    {
                        sum += dNum;
                        Console.WriteLine("number = {0}", dNum);
                    }
                }
                Console.WriteLine("Sum = {0}", sum);
            }
        }

        public void Slide_28()
        {
            using (TextReader file = new StreamReader("Files/numbers2.txt"))
            {
                double sum = 0.0;
                string sLine;
                sLine = file.ReadLine();
                while (sLine != null)
                {
                    double dNum;
                    if (Double.TryParse(sLine, out dNum))
                    {
                        sum += dNum;
                        Console.WriteLine("number = {0}", dNum);
                    }
                    sLine = file.ReadLine();
                }
                Console.WriteLine("Sum = {0}", sum);
            }
        }

        public void Slide_30()
        {
            char[] delimiters = { ' ', '\t' };
            using (TextReader file = new StreamReader("Files/numbers3.txt"))
            {
                double sum = 0.0;
                string sLine = file.ReadLine();
                while (sLine != null)
                {
                    string[] tokensFromLine = sLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string token in tokensFromLine)
                    {
                        double dNum;
                        if (Double.TryParse(token, out dNum))
                        {
                            sum += dNum;
                            Console.WriteLine("number = {0}", dNum);
                            break; // out of foreach
                        }
                    }
                    sLine = file.ReadLine();
                }
                Console.WriteLine("Sum = {0}", sum);
            }
        }

        public void Slide_32()
        {
            char[] delimiters = { ' ', '\t' };
            int obamaVotes = 0, mccainVotes = 0, eVotes = 0;

            using (TextReader t = new StreamReader("Files/poll.txt"))
            {
                string sLine = t.ReadLine();
                while (sLine != null)
                {
                    string[] tokens = sLine.Split(delimiters,
                                StringSplitOptions.RemoveEmptyEntries);
                    if (tokens.Length < 5)
                    {
                        Console.WriteLine("Did not find the expected number of items on line:\n\t{0}", sLine);
                        sLine = t.ReadLine();
                        continue;
                    }

                    int obama;
                    if (!Int32.TryParse(tokens[1], out obama))
                    {
                        Console.WriteLine("Obama's votes not formatted properly on line\n\t{0}", sLine);
                        sLine = t.ReadLine();
                        continue;
                    }
                    int mccain;
                    if (!Int32.TryParse(tokens[2], out mccain))
                    {
                        Console.WriteLine("McCain's votes not formatted properly on line\n\t{0}", sLine);
                        sLine = t.ReadLine();
                        continue;
                    }

                    if (!Int32.TryParse(tokens[3], out eVotes))
                    {
                        Console.WriteLine("Electoral votes not formatted properly on line\n\t{0}", sLine);
                        sLine = t.ReadLine();
                        continue;
                    }
                    if (obama > mccain)
                        obamaVotes += eVotes;
                    else if (mccain > obama)
                        mccainVotes += eVotes;
                    // on tie neither candidate gets the votes

                    sLine = t.ReadLine();
                }
            }
            Console.WriteLine("Obama: {0} votes", obamaVotes);
            Console.WriteLine("McCain: {0} votes", mccainVotes);
            if (obamaVotes > mccainVotes)
                Console.WriteLine("Overall: Obama");
            else
                Console.WriteLine("Overall: McCain");
        }

        public void Slide_37()
        {
            char[] delimiters = { ' ', '\t' };
            using (TextReader file = new StreamReader("Files/numbers4.txt"))
            {
                double sum = 0.0;
                string sFile = file.ReadToEnd();
                string[] tokensFromFile = sFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                foreach (string token in tokensFromFile)
                {
                    double dNum;
                    if (Double.TryParse(token, out dNum))
                    {
                        sum += dNum;
                        Console.WriteLine("number = {0}", dNum);
                    }
                }
                Console.WriteLine("Sum = {0}", sum);
            }
        }

        // This isn't used in the slides, but it's nifty enough
        // that I left it in.  Look it over if you're curious about it, but
        // don't worry about knowing this stuff in detail
        public void Slide_xx_OOP_and_Files()
        {
            using (TextReader t = new StreamReader("Files/poll2.txt"))
            {
                int numLines;  // total number of lines
                int iLine = 0; // which line are we on?

                string sLine = t.ReadLine();
                if (!Int32.TryParse(sLine, out numLines))
                {
                    Console.WriteLine("Expected to find the number of records on the first line, but didn't!");
                    return; // i.e., exit
                }
                PollResult[] results = new PollResult[numLines];


                sLine = t.ReadLine();
                while (iLine < results.Length && sLine != null)
                {
                    results[iLine] = new PollResult(sLine);
                    sLine = t.ReadLine();
                    iLine++;
                }

                foreach (PollResult result in results)
                {
                    result.Print();
                }
            }
        }

        class PollResult
        {
            private string stateAbbrev;
            private int obamaPercent;
            private int mccainPercent;
            private int electoralVotes;
            private string source;
            public string getState() { return stateAbbrev; }
            public int getObamaPercent() { return obamaPercent; }
            public int getMcCainPercent() { return mccainPercent; }
            public int getElectoralVotes() { return electoralVotes; }

            public PollResult(string lineFromFile)
            {
                char[] delimiters = { ' ', '\t' };
                string[] tokens = lineFromFile.Split(delimiters,
                            StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length < 5)
                {
                    Console.WriteLine("Did not find the expected number of items on line:\n\t{0}", lineFromFile);
                    return; // better to throw an exception here
                }

                if (!Int32.TryParse(tokens[1], out obamaPercent))
                {
                    Console.WriteLine("Obama's votes not formatted properly on line\n\t{0}", lineFromFile);
                    return;
                }

                if (!Int32.TryParse(tokens[2], out mccainPercent))
                {
                    Console.WriteLine("McCain's votes not formatted properly on line\n\t{0}", lineFromFile);
                    return;
                }

                if (!Int32.TryParse(tokens[3], out electoralVotes))
                {
                    Console.WriteLine("Electoral votes not formatted properly on line\n\t{0}", lineFromFile);
                    return;
                }
                stateAbbrev = tokens[0];

                source = "";
                for (int i = 4; i < tokens.Length; i++)
                {
                    source += tokens[i] + " ";
                }
            }

            public void Print()
            {
                Console.WriteLine("Results for {0}, as reported by \"{1}\":", stateAbbrev, source);
                Console.WriteLine("\tObama:\n\t\tPercent:{0}", obamaPercent);
                Console.WriteLine("\tMcCain:\n\t\tPercent:{0}", mccainPercent);
                if (obamaPercent > mccainPercent)
                    Console.WriteLine("{0} electoral votes for Obama", electoralVotes);
                else
                    Console.WriteLine("{0} electoral votes for McCain", electoralVotes);
            }
        }
    }

    class SlideExamples_Output
    {
        public void Slide_3()
        {
            StreamWriter output = new StreamWriter("out.txt");
            output.WriteLine("Hello, file!");
            output.WriteLine("This is a second line of output.");
            output.Dispose();
        }

        public void Slide_4()
        {
            using (StreamWriter output = new StreamWriter("out.txt"))
            {
                output.WriteLine("Hello, file!");
                output.WriteLine("This is a second line of output.");
            } // output.Dispose() called here automatically
            // This is C#-specific
        }

        public void Slide_6()
        {
            TextWriter out1 = Console.Out;
            TextWriter out2 = new StreamWriter("data.txt");
            out1.WriteLine("Hello, console!");   // goes to console
            out2.WriteLine("Hello, file!");      // goes to file
            out2.Dispose();
        }

        public void Slide_8()
        {
            char[] delimiters = { ' ', '\t' };
            TextReader input = new StreamReader("Files/hours.txt");
            StreamWriter output = new StreamWriter("Files/hours_out.txt");
            String sLine;
            while ((sLine = input.ReadLine()) != null)
            {
                string[] tokensFromLine = sLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                if (tokensFromLine.Length < 3)
                {
                    Console.WriteLine("Line contained fewer than 3 tokens! {0}", sLine);
                    continue; // get next line
                }
                int ID;
                if (false == Int32.TryParse(tokensFromLine[0], out ID))
                {
                    Console.WriteLine("Line did not start with ID number! {0}", sLine);
                    continue; // get next line
                }
                string name = tokensFromLine[1];

                double sum = 0.0;
                int count = 0;
                for (int i = 2; i < tokensFromLine.Length; i++)
                {
                    double dNum;
                    if (Double.TryParse(tokensFromLine[i], out dNum))
                    {
                        sum += dNum;
                        count++;
                    }
                }
                if (count == 0) // didn't find any hours worked
                {
                    Console.WriteLine("Line did not find any hours worked! {0}", sLine);
                    continue; // get next line
                }

                double average = sum / count;
                output.WriteLine("{0} (ID#{1}) worked {2} hours ({3} hours/day)", name, ID, sum, average);
                // If you change output.WriteLine to Console.WriteLine 
                // you’d see the output on the screen
            }

            output.Dispose();
        }
    }
}

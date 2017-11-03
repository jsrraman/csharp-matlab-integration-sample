using System;
using MathWorks.MATLAB.NET.Arrays;
using Matlab;



namespace Rajaraman.CSharp.Sample
{
    class Program
    {
        private const string INPUT_EXIT = "n";
        private enum APP_OPTIONS { PRINT_MAGIC_SQUARE = 1, PARABOLA_GRAPH, BAR_CHART, QUIT };

        static void Main(string[] args)
        {
            ShowProgramUsageToUser();

            string input = Console.ReadLine();

            if (input.ToLower() == INPUT_EXIT)
            {
                QuitApplication();
            }
            else
            {
                ProcessUserInput();
            }
        }

        private static void QuitApplication()
        {
            Environment.Exit(0);
        }

        private static void PrintMagicSquare()
        {
            SampleClass sampleClass = null;
            MWNumericArray input = null;
            MWNumericArray output = null;
            MWArray[] result = null;

            try
            {
                sampleClass = new SampleClass();
                input = 4;
                result = sampleClass.makeSquare(1, input);
                output = (MWNumericArray)result[0];

                Console.WriteLine(output);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void PlotParabolaGraph()
        {
            SampleClass sampleClass = null;

            try
            {
                sampleClass = new SampleClass();
                MWNumericArray input = new MWNumericArray(1, 7, new int[] {-6, -4, -2, 0, 2, 4, 6});
                sampleClass.parabolaGraph(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ProcessProgramOptions(APP_OPTIONS option)
        {
            switch (option)
            {
                case APP_OPTIONS.PRINT_MAGIC_SQUARE:
                    PrintMagicSquare();
                    break;

                case APP_OPTIONS.PARABOLA_GRAPH:
                    PlotParabolaGraph();
                    break;

                case APP_OPTIONS.BAR_CHART:
                    break;

                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }
        }

        private static void ProcessUserInput()
        {
            while (true)
            {
                ShowProgramOptionsToUser();

                string input = Console.ReadLine();
                int option = 1;

                if (int.TryParse(input, out option))
                {
                    APP_OPTIONS appOption = (APP_OPTIONS)option;

                    if (appOption == APP_OPTIONS.QUIT)
                    {
                        break;
                    }
                    else
                    {
                        ProcessProgramOptions(appOption);
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid option");
                }
            }
        }

        private static void ShowProgramOptionsToUser()
        {
            Console.WriteLine("***");
            Console.WriteLine("1. Magic square");
            Console.WriteLine("2. Parabola graph");
            Console.WriteLine("3. Bar chart");
            Console.WriteLine("4. Quit");
            Console.WriteLine("***");
        }

        private static void ShowProgramUsageToUser()
        {
            Console.WriteLine("This program demonstrates the integration with following MATLAB functions\n");
            Console.WriteLine("Please press 'y' to continue and 'n' to quit");
        }
    }
}

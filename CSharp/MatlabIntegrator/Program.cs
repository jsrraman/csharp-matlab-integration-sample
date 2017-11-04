using System;

using Matlab;

namespace Rajaraman.CSharp.Sample
{
    class Program
    {
        private const string INPUT_EXIT = "n";
        private enum APP_OPTIONS { MAGIC_SQUARE = 1, PARABOLA_GRAPH, BAR_CHART, QUIT };

        static void Main(string[] args)
        {
            ShowAppUsageToUser();
            ProcessUserInput();
        }

        private static void QuitApplication()
        {
            Environment.Exit(0);
        }

        private static void ProcessAppOption(APP_OPTIONS appOption)
        {
            Option option = null;

            switch (appOption)
            {
                case APP_OPTIONS.MAGIC_SQUARE:
                    option = new MagicSquareOption();
                    break;

                case APP_OPTIONS.PARABOLA_GRAPH:
                    option = new ParabolaChartOption();
                    break;

                case APP_OPTIONS.BAR_CHART:
                    option = new BarChartOption();
                    break;

                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }

            if (option != null)
            {
                option.ExecuteOption();
            }
        }

        private static void ProcessUserInput()
        {
            while (true)
            {
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
                        ProcessAppOption(appOption);
                        PrintSeparator();
                        ShowAppOptions();
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid option");
                }
            }
        }

        private static void PrintSeparator()
        {
            Console.WriteLine("***\n");
        }

        private static void ShowAppUsageToUser()
        {
            Console.WriteLine("This program demonstrates the integration with following MATLAB functions\n");
            ShowAppOptions();
        }

        private static void ShowAppOptions()
        {
            Console.WriteLine("Please select one of the following options\n");
            Console.WriteLine("1. Magic square");
            Console.WriteLine("2. Parabola graph");
            Console.WriteLine("3. Bar chart");
            Console.WriteLine("4. Quit\n");
        }
    }
}

using MathWorks.MATLAB.NET.Arrays;
using System;

namespace Rajaraman.CSharp.Sample
{
    public class BarChartOption : Option
    {
        MWNumericArray xValues = null;
        MWNumericArray yValues = null;

        public override bool ProcessInput()
        {
            Console.WriteLine("Please input the values for x separated by commas");

            if (!PopulateValues(ref xValues))
            {
                return false;
            }

            Console.WriteLine("Please input the values for y separated by commas");

            return PopulateValues(ref yValues);
        }

        private bool PopulateValues(ref MWNumericArray valuesArray)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(',');
            int tokensLength = tokens.Length;

            if (tokensLength == 0)
            {
                return false;
            }

            int value = 0, index = 0;
            int[] values = new int[tokensLength];

            foreach (string token in tokens)
            {
                if (int.TryParse(token, out value))
                {
                    values.SetValue(value, index++);
                }
                else
                {
                    return false;
                }
            }

            valuesArray = new MWNumericArray(1, tokensLength, values);

            return true;
        }

        public override void ExecuteOption()
        {
            executeOptionDelegate optionDelegate = new executeOptionDelegate(ExecuteBarChartOption);
            base.ExecuteOption(optionDelegate);
        }

        private void ExecuteBarChartOption()
        {
            sampleClass.barChart(xValues, yValues);
        }
    }
}

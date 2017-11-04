using MathWorks.MATLAB.NET.Arrays;
using System;

namespace Rajaraman.CSharp.Sample
{
    public class ParabolaChartOption : Option
    {
        MWNumericArray xValues = null;

        public override bool ProcessInput()
        {
            Console.WriteLine("Please input the values for x separated by commas");
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

            xValues = new MWNumericArray(1, tokensLength, values);

            return true;
        }

        public override void ExecuteOption()
        {
            executeOptionDelegate optionDelegate = new executeOptionDelegate(ExecuteParabolaGraphOption);
            base.ExecuteOption(optionDelegate);
        }

        private void ExecuteParabolaGraphOption()
        {
            sampleClass.parabolaGraph(xValues);
        }
    }
}

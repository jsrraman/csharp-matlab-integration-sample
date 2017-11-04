using MathWorks.MATLAB.NET.Arrays;
using System;

namespace Rajaraman.CSharp.Sample
{
    public class MagicSquareOption : Option
    {
        private int input = 0;

        public override bool ProcessInput()
        {
            Console.WriteLine("Please input the value of n");
            string inputString = Console.ReadLine();

            return int.TryParse(inputString, out input);
        }

        public override void ExecuteOption()
        {
            executeOptionDelegate optionDelegate = new executeOptionDelegate(ExecuteMagicSquareOption);
            base.ExecuteOption(optionDelegate);
        }

        private void ExecuteMagicSquareOption()
        {
            MWNumericArray output = null;
            MWArray[] result = null;

            result = sampleClass.makeSquare(1, input);
            output = (MWNumericArray)result[0];

            Console.WriteLine(output);
        }
    }
}

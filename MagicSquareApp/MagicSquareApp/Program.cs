using System;
using MathWorks.MATLAB.NET.Arrays;
using MagicSquareML;


namespace MagicSquareApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MagicSquare magicSquare = null;
            MWNumericArray input = null;
            MWNumericArray output = null;
            MWArray[] result = null;

            try
            {
                magicSquare = new MagicSquare();

                input = 4;
                result = magicSquare.makesquare(1, input);

                output = (MWNumericArray)result[0];

                Console.WriteLine(output);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

using Matlab;
using System;

namespace Rajaraman.CSharp.Sample
{
    public abstract class Option
    {
        protected SampleClass sampleClass = null;
        public delegate void executeOptionDelegate();

        protected Option()
        {
            sampleClass = new SampleClass();
        }

        public abstract bool ProcessInput();
        public abstract void ExecuteOption();

        public virtual void ExecuteOption(executeOptionDelegate optionDelegate)
        {
            try
            {
                if (ProcessInput())
                {
                    optionDelegate();
                }
                else
                {
                    Console.WriteLine("\nPlease provide valid input");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

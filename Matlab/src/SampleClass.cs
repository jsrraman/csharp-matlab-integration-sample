/*
* MATLAB Compiler: 4.18 (R2012b)
* Date: Fri Nov 03 13:17:37 2017
* Arguments: "-B" "macro_default" "-W" "dotnet:Matlab,SampleClass,4.0,private" "-T"
* "link:lib" "-d"
* "D:\Users\Rajaraman\Projects\miscellaneous\csharp-matlab-integration-sample\Matlab\src"
* "-w" "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v"
* "class{SampleClass:D:\Users\Rajaraman\Projects\miscellaneous\csharp-matlab-integration-s
* ample\Matlab\barChart.m,D:\Users\Rajaraman\Projects\miscellaneous\csharp-matlab-integrat
* ion-sample\Matlab\makeSquare.m,D:\Users\Rajaraman\Projects\miscellaneous\csharp-matlab-i
* ntegration-sample\Matlab\parabolaGraph.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace Matlab
{

  /// <summary>
  /// The SampleClass class provides a CLS compliant, MWArray interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// D:\Users\Rajaraman\Projects\miscellaneous\csharp-matlab-integration-sample\Matlab\ba
  /// rChart.m
  /// <newpara></newpara>
  /// D:\Users\Rajaraman\Projects\miscellaneous\csharp-matlab-integration-sample\Matlab\ma
  /// keSquare.m
  /// <newpara></newpara>
  /// D:\Users\Rajaraman\Projects\miscellaneous\csharp-matlab-integration-sample\Matlab\pa
  /// rabolaGraph.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 4.0
  /// </remarks>
  public class SampleClass : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static SampleClass()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = "Matlab.ctf";

        Stream embeddedCtfStream = null;

        String[] resourceStrings = assembly.GetManifestResourceNames();

        foreach (String name in resourceStrings)
        {
          if (name.Contains(ctfFileName))
          {
            embeddedCtfStream = assembly.GetManifestResourceStream(name);
            break;
          }
        }
        mcr= new MWMCR("",
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the SampleClass class.
    /// </summary>
    public SampleClass()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~SampleClass()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the barChart M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void barChart()
    {
      mcr.EvaluateFunction(0, "barChart", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the barChart M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    ///
    public void barChart(MWArray x)
    {
      mcr.EvaluateFunction(0, "barChart", x);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the barChart M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    ///
    public void barChart(MWArray x, MWArray y)
    {
      mcr.EvaluateFunction(0, "barChart", x, y);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the barChart M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] barChart(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "barChart", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the barChart M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] barChart(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "barChart", x);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the barChart M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] barChart(int numArgsOut, MWArray x, MWArray y)
    {
      return mcr.EvaluateFunction(numArgsOut, "barChart", x, y);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the makeSquare M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray makeSquare()
    {
      return mcr.EvaluateFunction("makeSquare", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the makeSquare M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray makeSquare(MWArray x)
    {
      return mcr.EvaluateFunction("makeSquare", x);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the makeSquare M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] makeSquare(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "makeSquare", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the makeSquare M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] makeSquare(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "makeSquare", x);
    }


    /// <summary>
    /// Provides an interface for the makeSquare function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void makeSquare(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("makeSquare", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the parabolaGraph M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void parabolaGraph()
    {
      mcr.EvaluateFunction(0, "parabolaGraph", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the parabolaGraph M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    ///
    public void parabolaGraph(MWArray x)
    {
      mcr.EvaluateFunction(0, "parabolaGraph", x);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the parabolaGraph M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] parabolaGraph(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "parabolaGraph", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the parabolaGraph M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] parabolaGraph(int numArgsOut, MWArray x)
    {
      return mcr.EvaluateFunction(numArgsOut, "parabolaGraph", x);
    }



    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private bool disposed= false;

    #endregion Class Members
  }
}

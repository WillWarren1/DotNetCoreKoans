using System;
using DotNetCoreKoans.Engine;

namespace DotNetCoreKoans.Koans
{
  public class PathToEnlightenment : Path
  {
    public PathToEnlightenment()
    {
      Types = new Type[] {
                // START: Explorer Mode
                typeof(AboutAsserts),
                typeof(AboutNull),
                typeof(AboutArrayAssignment),
                typeof(AboutStrings),
                typeof(AboutFloats),
                typeof(AboutControlStatements),
                typeof(AboutArrays),
                typeof(AboutMethods),
                // END: Explorer Mode

                // // START: Adventure mode
                // typeof(AboutDelegates),
                // typeof(AboutLambdas),
                // typeof(AboutLinq),
                // typeof(AboutInheritance),
                // // END: Adventure Mode

                // // START: Epic mode
                // typeof(AboutGenericContainers),
                // typeof(AboutBitwiseAndShiftOperator),
                };
    }
  }
}
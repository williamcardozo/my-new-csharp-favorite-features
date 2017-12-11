using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNewCSharpFavoriteFeatures.LocalFunctions
{
    public class LocalFunctionSample
    {
        public void MethodUsingLocalFunction()
        {
            Console.WriteLine(LocalFunction());

            string LocalFunction() => "My Local Function";
        }
    }
}

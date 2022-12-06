using System;
using System.Collections.Generic;

namespace TextualAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            //var wc = TextualAnalysis.ComputeWordFrequencies("All, the   a faith - he    had had    had     had no effect!!!!!??.", true);
            var wc = TextualAnalysis.ComputeWordFrequenciesFromFile("../../../Data/small.txt", true);
            foreach (var keyValuePair in wc)
            {
                Console.WriteLine(keyValuePair.Key + " -> " + keyValuePair.Value);
            }

        }
    }
}

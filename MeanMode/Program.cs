using System;
using System.Collections.Generic;

namespace MeanMode
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static bool MeanMode(int[] array)
        {
            return computeMode(array) == computeAverage(array);
        }

        // TODO
        private static double computeAverage(int[] array)
        {
            
            double count = 0;
            foreach (var term in array)
            {
                count = count + term;
                
            }
            double average = count / array.Length;

            return average;
        }

        // TODO
        private static double? computeMode(int[] array)
        {

            
            Dictionary<int, int> numCounts = new Dictionary<int, int>();
            foreach(int num in array)
            {
                if (numCounts.ContainsKey(num))
                {
                    numCounts[num]++;
                }
                else
                {
                    numCounts.Add(num, 1);
                }

                
            }
            int maxCount = 0;

            
            foreach (var count in numCounts.Values)
            {
                if(count == maxCount)
                {
                    return null;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                }
            }

           

            foreach (var number in numCounts.Keys)
            {
                if(numCounts[number] == maxCount)
                {
                    return number;
                }
               
            }




            //LinkedList<Bucket<K, V>> list in bucketListsArray
            //foreach(Dictionary<k, v> list in numCounts)

            return null;
        }
    }
}

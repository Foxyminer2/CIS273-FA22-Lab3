using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace StringUtilities
{
    public static class StringUtilities
    {
        public static bool IsUniqueCharacterSet(this string s)
        {
            // remove all space chars from string
            var cleanString = Regex.Replace(s, @"\s+","");


            // check for duplicate letters
            HashSet<char> hashSet = new HashSet<char>();

            foreach(var letter in cleanString.ToLower())
            {
                if (hashSet.Contains(letter))
                {
                    return false;
                }

                

                hashSet.Add(letter);
            }

            return true;
        }
    }
}

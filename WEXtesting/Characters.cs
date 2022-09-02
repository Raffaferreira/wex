using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEXtesting
{
    public class Characters
    {
        /// <summary>
        /// Given a string, determine if the string has all unique characters.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool HasUniqueChars(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}


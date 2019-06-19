using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Isograms
{
    class Program
    {
        static void Main(string[] args)
        {
            IsIsogram("moose");

            IsIsogram("moOse", 1);
        }


        public static bool IsIsogram(string str, int myInt)
        {
        return str.ToLower().Distinct().Count()==str.Length;
        }


        public static bool IsIsogram(string str)
        {
            // Code on you crazy diamond!

            int len = str.Length;
            int cnt = 0;
            char[] myChars = new char[len];

            // poulate myChars array
            for (int i = 0; i < len; i++)
            {
                myChars[i] = str.ToUpper()[i];

                for (int j = 0; j < len; j++)
                {
                    if (myChars[i] == str.ToUpper()[j])
                        cnt++;
                }
                    
            }

            if (cnt > len)
                return false;
            else
                return true;
        }


    }
}

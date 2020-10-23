using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            char[] pleb = new char[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                pleb[i] = original[i];  
            }
            Array.Reverse(pleb);
            string bruh = string.Join("", pleb);
            return bruh;
        }
    }
}

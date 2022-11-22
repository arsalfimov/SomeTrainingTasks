using System;
using System.Linq;

namespace ShortestWord
{
    public class ShortestWord
    {
        static void Main(string[] args)
        {

        }

        public static int FindShort(string s)
        {
            string[] words = s.Split(new char[] { ' ' });
            int min = words[0].Length;
            foreach (var item in words.Where(item => item.Length < min))
            {
                min = item.Length;
            }

            return min;
        }
    }
}

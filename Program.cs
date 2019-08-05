using System;
using System.Collections.Generic;

namespace commonCharCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "aabcc";
            string s2 = "adcaa";

            Algorithm run = new Algorithm();

            int result = run.CommonCharacterCount(s1, s2);

            Console.WriteLine(result);
            // expected = 3
        }
    }

    class Algorithm
    {
        public int CommonCharacterCount(string s1, string s2)
        {

            List<String> List1 = new List<string>();
            List<String> List2 = new List<string>();

            for (int i = 0; i < s1.Length; i++)
            {
                List1.Add(s1.Substring(i, 1));
            }
            for (int j = 0; j < s2.Length; j++)
            {
                List2.Add(s2.Substring(j, 1));
            }

            int counter = 0;

            for (int i = 0; i < List1.Count; i++)
            {
                for (int j = 0; j < List2.Count; j++)
                {
                    if (List1[i] == List2[j])
                    {
                        counter++;
                        List2.RemoveAt(j);
                        break;
                    }
                }
            }
            return counter;
        }
    }
}

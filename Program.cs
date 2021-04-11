using System;

namespace ctci
{
    class Program
    {
        static void Main(string[] args)
        {
            Permutation("Richard");
        }

        static void Permutation(string str)
        {
            Permutation(str, "");
        }
        static void Permutation(string str, string prefix)
        {
            if(str.Length == 0)
            {
                Console.WriteLine(prefix);
            }
            else
            {
                for(int i = 0; i < str.Length; i++)
                {
                    string rem = str.Substring(0, i) + str.Substring(i + 1);
                    Permutation(rem, prefix + str[i]);
                }
            }
        }
    }
}

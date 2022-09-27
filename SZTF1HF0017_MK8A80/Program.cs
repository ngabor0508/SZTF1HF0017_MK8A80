using System;

namespace SZTF1HF0017_MK8A80
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] sajatMeresek = new long[5];
            long[] baratunkMeresei = new long[5];

            for (int i = 0; i < sajatMeresek.Length; i++)
            {
                Console.WriteLine("Add meg a bemeneti értékeket: ");
                sajatMeresek[i] = long.Parse(Console.ReadLine());
            }
            for (int i = 0; i < sajatMeresek.Length; i++)
            {
                Console.WriteLine(sajatMeresek[i]);
            }
                

        }
    }
}

using System;

namespace SZTF1HF0017_MK8A80
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] baratunkMeresei = new long[5];
            long[] sajatMeresek = new long[5];
            long baratunkMereseinekOsszege = 0;
            long sajatMereseinkOsszege = 0;
            long kulonbseg = 0;

            for (int i = 0; i < baratunkMeresei.Length; i++) {
                Console.Write("");
                baratunkMeresei[i] = long.Parse(Console.ReadLine());
                sajatMeresek[i] = baratunkMeresei[i];
                baratunkMereseinekOsszege = baratunkMereseinekOsszege + baratunkMeresei[i];
            }

            for (int i = 0; i < baratunkMeresei.Length; i++) {
                //Ha 0
                if (baratunkMeresei[i] == 0) {
                    sajatMeresek[i] = (i + 1);
                }
                //Ha páros
                else if(baratunkMeresei[i] % 2 == 0 || baratunkMeresei[i] % -2 == 0) {
                    sajatMeresek[i] = sajatMeresek[i] + (2 * (i + 1));
                }
                //Ha páratlan
                else if (baratunkMeresei[i] % 2 == 1 || baratunkMeresei[i] % -2 == -1) {
                    double segedSzamolas = Math.Ceiling(sajatMeresek[i] + ((double)(i + 1) / 2));
                    sajatMeresek[i] = (long)segedSzamolas;
                }
                
                if (i + 1 == baratunkMeresei.Length)
                {    
                    sajatMeresek[i] = 0;
                    kulonbseg = baratunkMereseinekOsszege - sajatMereseinkOsszege;
                    sajatMeresek[i] = kulonbseg;


                    //Console.WriteLine("Utolsó ciklus: " + i + "Mérés i: " + sajatMeresek[i]);
                    //Console.WriteLine("Itt nulla kellene, hogy legyen: " + sajatMeresek[i]);
                    //Console.WriteLine("Barát összeg: " + baratunkMereseinekOsszege);
                    //Console.WriteLine("Saját összeg: " + sajatMereseinkOsszege);
                    //if (sajatMereseinkOsszege < baratunkMereseinekOsszege)
                    //{
                    //    sajatMeresek[i] = baratunkMereseinekOsszege - sajatMereseinkOsszege;
                    //}
                    //else
                    //{
                    //    sajatMeresek[i] = sajatMereseinkOsszege - baratunkMereseinekOsszege;
                    //}
                    //Console.WriteLine("Az utolsó lépésnél vagyunk!");
                }
                sajatMereseinkOsszege = sajatMereseinkOsszege + sajatMeresek[i];
            }

            for (int i = 0; i < sajatMeresek.Length; i++) {
                Console.Write(""+sajatMeresek[i] + ",");
            }


        }
    }
}

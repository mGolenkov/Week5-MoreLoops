﻿using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb 2 mängijat - arvuti (cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskab rohkem, ongi mängu võitja
            //täringuid visatakse 3 korda
            //programm kuulutab võitjat

            Random rnd = new Random();

            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {
                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");

                if (cpuScore > userScore)
                {
                    Console.WriteLine("Arvuti on võitnud!");
                }
                else if (cpuScore < userScore)
                {
                    Console.WriteLine("Kasutaja on võitnud!");
                }
                else
                {
                    Console.WriteLine("Viik!");
                }
            }
        }
    }
}

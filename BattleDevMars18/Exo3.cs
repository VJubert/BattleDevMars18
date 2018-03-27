using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleDevMars18
{
    class Exo3
    {
        static int CalcEcart(int[] myNotes, int[] potesNotes)
        {
            int sum = 0;
            for (var i = 0; i < 5; i++)
            {
                sum += Math.Abs(potesNotes[i] - myNotes[i]);
            }

            return sum;
        }

        public static void ExoMain(string[] args)
        {
            int[] myNotes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int nbPotes = int.Parse(Console.ReadLine());
            int potesImport = int.Parse(Console.ReadLine());
            List<int[]> notesPotes = new List<int[]>();
            for (var i = 0; i < nbPotes; i++)
            {
                notesPotes.Add(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            }

            int sum = notesPotes.OrderBy(x => CalcEcart(myNotes, x)).Take(potesImport).Sum(x => x[5]);
            Console.WriteLine(sum / potesImport);
        }
    }
}

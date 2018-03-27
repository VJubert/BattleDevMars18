using System;

namespace BattleDevMars18
{
    class Exo1
    {
        public static void ExoMain(string[] args)
        {
            int nbResto = int.Parse(Console.ReadLine());
            double maxScore = 0;
            for (var i = 0; i < nbResto; i++)
            {
                var s = Console.ReadLine().Split(' ');
                var no = int.Parse(s[0]);
                var sa = int.Parse(s[1]);
                var se = int.Parse(s[2]);
                var temp = (no + sa + se) / 3.0;
                if (temp > maxScore)
                {
                    maxScore = temp;
                }
            }

            Console.WriteLine((int)Math.Ceiling(maxScore));
        }
    }
}

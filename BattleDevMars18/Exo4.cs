using System;

namespace BattleDevMars18
{
    class Exo4
    {
        static int[] Retourne(int[] def, int index)
        {
            int[] res = new int[6];
            int cpt = 0;
            for (var i = index; i >= 0; i--)
            {
                res[cpt] = def[i];
                cpt++;
            }
            for (var i = cpt; i < def.Length; i++)
            {
                res[i] = def[i];
                cpt++;
            }

            return res;
        }

        static bool Ok(int[] taille)
        {
            int last = 0;
            foreach (int tailleCrepe in taille)
            {
                if (last > tailleCrepe)
                    return false;
                last = tailleCrepe;
            }

            return true;
        }

        static int MainRec(int[] tab, int index, int cpSpatule)
        {
            if (cpSpatule == 7)
                return 7;
            var temp = Retourne(tab, index);
            if (Ok(temp))
                return cpSpatule;

            int min = int.MaxValue;
            for (var i = 0; i < 6; i++)
            {
                int t = MainRec(temp, i, cpSpatule + 1);
                if (min > t)
                    min = t;
            }

            return min;
        }

        public static void ExoMain(string[] args)
        {
            int[] tailleCrepe = new int[6];
            for (var index = 0; index < 6; index++)
            {
                tailleCrepe[index] = int.Parse(Console.ReadLine());
            }

            if (Ok(tailleCrepe))
            {
                Console.WriteLine(0);
                return;
            }

            int min = int.MaxValue;
            for (var i = 0; i < 6; i++)
            {
                var t = MainRec(tailleCrepe, i, 1);
                if (min > t)
                {
                    min = t;
                }
            }
            Console.WriteLine(min);
        }
    }
}

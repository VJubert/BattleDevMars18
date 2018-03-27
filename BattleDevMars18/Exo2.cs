using System;

namespace BattleDevMars18
{
    class Exo2
    {
        public static void ExoMain(string[] args)
        {
            int prixPerso = int.Parse(Console.ReadLine());
            int tableServis = int.Parse(Console.ReadLine());
            double montant = 0;
            for (var i = 0; i < tableServis; i++)
            {
                int nbPerso = int.Parse(Console.ReadLine());
                if (nbPerso >= 10)
                {
                    montant += nbPerso * prixPerso - nbPerso * prixPerso * 0.3;
                }
                else if (nbPerso >= 6)
                {
                    montant += nbPerso * prixPerso - nbPerso * prixPerso * 0.2;
                }
                else if (nbPerso >= 4)
                {
                    montant += nbPerso * prixPerso - nbPerso * prixPerso * 0.1;
                }
                else
                {
                    montant += nbPerso * prixPerso;
                }
            }
            Console.WriteLine((int)Math.Ceiling(montant));
        }
    }
}

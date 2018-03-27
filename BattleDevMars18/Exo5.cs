using System;
using System.Collections.Generic;
using System.Text;

namespace BattleDevMars18
{
    /// <summary>
    /// WIP
    /// </summary>
    class Exo5
    {
        class Node
        {
            public Guid Id => Guid.NewGuid();

            private int X { get; }
            private int Y { get; }

            private readonly List<Node> _next;

            public Node(int x, int y, int nbTerm, bool first = true)
            {
                this.X = x;
                this.Y = y;
                if (first)
                {
                    for (var i = 0; i < nbTerm; i++)
                    {
                        for (var j = 0; j < nbTerm; j++)
                        {
                            _next.Add(new Node(i, j, new List<int>(), nbTerm));
                        }
                    }
                }
            }

            public Node(int x, int y, List<int> disabled, int nbTerm)
            {
                this.X = x;
                this.Y = y;
                _next = new List<Node>();
                for (var i = 0; i < nbTerm; i++)
                {
                    if (disabled.Contains(i))
                        continue;
                    for (var j = 0; j < nbTerm; j++)
                    {
                        if (disabled.Contains(j))
                            continue;
                        if (Math.Min(i, j) > Math.Max(x, y) || Math.Max(i, j) < Math.Min(x, y))
                            _next.Add(new Node(i, j, new List<int>(disabled) { x, y }, nbTerm));
                    }
                }
                _next.Add(new Node(-2, -2, nbTerm, false));
            }

            public int DistToNext(int[,] mat, Node next)
            {
                if (X == -1 || next.X == -2)
                    return 0;
                else
                    return mat[next.X, next.Y];
            }
        }

        static void ExoMain(string[] args)
        {
            int nbTerm = int.Parse(Console.ReadLine());
            int[,] mat = new int[nbTerm, nbTerm];
            for (var i = 0; i < nbTerm; i++)
            {
                var s = Console.ReadLine().Split(' ');
                for (var j = 0; j < nbTerm; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }
            var start = new Node(-1, -1, nbTerm);


            Dictionary<Guid, int> poids = new Dictionary<Guid, int> { [start.Id] = 0 };

            List<Node> allNode;

            //while (allNode.Count != 0)
            //{

            //}
        }
    }
}

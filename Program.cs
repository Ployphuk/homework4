using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        List<int> Node = new List<int>();
        while (true)
        {
            int node = int.Parse(Console.ReadLine());
            if (node >= a) break;
            Node.Add(node);
        }

        int start = int.Parse(Console.ReadLine());
        int finish = int.Parse(Console.ReadLine());

        int[,] matrixedit = new int[a, a];
        for (int i = 0; i < Node.Count; i += 2)
        {
            int startnode = Node[i];
            int endnode = Node[i + 1];
            matrixedit[startnode, endnode] = 1;
        }

        for (int r = 0; r < a; r++)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (matrixedit[i, j] != 1 && matrixedit[i, r] == 1 && matrixedit[r, j] == 1)
                    {
                        matrixedit[i, j] = 1;
                    }
                }
            }
        }

        if (matrixedit[start, finish] == 1)
        {
            Console.WriteLine("Reachable");
        }
        else
        {
            Console.WriteLine("Unreachable");
        }
    }
}

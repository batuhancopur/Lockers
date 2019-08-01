﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lockers
{
    class Program
    {
        static void Main(string[] args)
        {
            int w=3;
            int h=5;
            int i;
            int j;

            var lockers = new int[2, 2] { { 0, 0 }, { 2, 3 } };
            var points = new int[h, w];

            for (i = 0; i < h; i++)
            {
                for (j = 0; j < w; j++)
                {
                    int x1 = Math.Abs(j - lockers[0, 0]);
                    int y1 = Math.Abs(i - lockers[0, 1]);
                    int x2 = Math.Abs(j - lockers[1, 0]);
                    int y2 = Math.Abs(i - lockers[1, 1]);

                    if (x1 + y1 < x2 + y2)
                    {
                        points[i, j] = (x1 + y1);
                    }
                    else
                    {
                        points[i, j] = (x2 + y2);
                    }

                }
            }


            for (i = 0; i < h; i++)
            {
                for (j = 0; j < w; j++)
                {

                    Console.Write(points[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("done");
            Console.ReadLine();
        }
    }
}
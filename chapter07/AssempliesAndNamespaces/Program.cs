﻿using System;
using System.Xml.Linq;

using static System.Console;

using DialectSoftware.Collections;
using DialectSoftware.Collections.Generics;

namespace AssempliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            float fl;

            XDocument doc = new XDocument();

            string s1 = "Hello!";
            String s2 = "World!";

            Axis x = new Axis("x", 0, 10, 1);
            Axis y = new Axis("y", 0, 4, 1);
            Matrix<long> matrix = new Matrix<long> (new[] {x, y});
            for (int i = 0; i < matrix.Axes[0].Points.Length; i++)
            {
                matrix.Axes[0].Points[i].Label = "x" + i.ToString();
            }
            for (int i = 0; i < matrix.Axes[1].Points.Length; i++)
            {
                matrix.Axes[1].Points[i].Label = "x" + i.ToString();
            }
            foreach (long[] c in matrix)
            {
                matrix[c] = c[0] + c[1];
            }
            foreach (long[] c in matrix)
            {
                WriteLine("{0}, {1} ({2}, {3}) = {4}", matrix.Axes[0].Points[c[0]].Label, 
                matrix.Axes[1].Points[c[1]].Label, c[0], c[1], matrix[c]);
            }
        }
    }
}

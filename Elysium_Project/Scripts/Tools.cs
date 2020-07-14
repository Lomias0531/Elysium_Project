using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elysium_Project.Scripts
{
    class Tools:Singletion<Tools>
    {
        readonly Random Rnd = new Random();
        #region 字母表
        private enum Chart
        {
            A, E, I, O, U
        }
        private enum Chart_0
        {
            B, C, D, F, G, H, J, K, L, M, N, P, Q, R, S, T, V, W, X, Y, Z
        }
        private enum Chart_1
        {
            a, e, i, o, u
        }
        private enum Chart_2
        {
            b, c, d, f, g, h, j, k, l, m, n, p, q, r, s, t, v, w, x, y, z
        }
        #endregion
        public string GetRandomName(int min_length,int max_length)
        {
            int Length = Rnd.Next(min_length, max_length);
            string Name = "";
            bool Last = false;
            int Pop = 0;
            switch (Rnd.Next(0, 2))
            {
                case 0:
                    {
                        Chart[] chart = Enum.GetValues(typeof(Chart)) as Chart[];
                        Name += chart[Rnd.Next(0, chart.Length)].ToString();
                        Last = true;
                        Pop = +15;
                        break;
                    }
                case 1:
                    {
                        Chart_0[] chart = Enum.GetValues(typeof(Chart_0)) as Chart_0[];
                        Name += chart[Rnd.Next(0, chart.Length)].ToString();
                        Last = false;
                        Pop = 0;
                        break;
                    }
            }
            while (Name.Length < Length)
            {
                switch (Last)
                {
                    case true:
                        {
                            if (Rnd.Next(0, 100) < 30 - Pop)
                            {
                                Chart_1[] chart = Enum.GetValues(typeof(Chart_1)) as Chart_1[];
                                Name += chart[Rnd.Next(0, chart.Length)].ToString();
                                Last = true;
                                Pop += 15;
                            }
                            else
                            {
                                Chart_2[] chart = Enum.GetValues(typeof(Chart_2)) as Chart_2[];
                                Name += chart[Rnd.Next(0, chart.Length)].ToString();
                                Last = false;
                                Pop = 0;
                            }
                            break;
                        }
                    case false:
                        {
                            Chart_1[] chart = Enum.GetValues(typeof(Chart_1)) as Chart_1[];
                            Name += chart[Rnd.Next(0, chart.Length)].ToString();
                            Last = true;
                            Pop += 15;
                            break;
                        }
                }
            }
            return Name;
        }
    }
}

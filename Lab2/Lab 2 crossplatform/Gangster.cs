﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_crossplatform
{
    class Gangster
    {
        public Gangster(int t, int p, int s)
        {
            T = t;
            P = p;
            S = s;
        }

        public int T { get; set; }
        public int P { get; set; }
        public int S { get; set; }
    }
}

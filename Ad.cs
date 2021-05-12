using System;
using System.Collections.Generic;
using System.Text;

namespace Addition
{
    class Ad
    {
        int x, y;
        public Ad(int i,int j)
        {
            x = i;
            y = j;
        }
        public int Addition(Ad e)
        {
            int z = e.x + e.y;
            return z;
        }
    }
}

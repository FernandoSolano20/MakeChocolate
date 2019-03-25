using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_Chocolate
{
    public static class Chocolate
    {
        static public int MakeChocolate(int smallBars, int bigBars, int goal)
        {
            int cantBigBars = 0;
            while(bigBars > 0 && cantBigBars <= bigBars)
            {
                if ((cantBigBars + 1) * 5 < goal)
                {
                    cantBigBars++;
                }
                bigBars--;
            }

            goal -= (cantBigBars * 5);

            if(goal <= smallBars)
            {
                return goal;
            }
            return -1;
        }
    }
}

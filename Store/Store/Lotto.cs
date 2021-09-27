using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Lotto: Store
    {
        //methods
        public override int AreYouFeelingLucky()
        {
            Random luckyNumber = new Random();
            int luckNum = luckyNumber.Next(1, 100);
            return luckNum;
        }
    }
}

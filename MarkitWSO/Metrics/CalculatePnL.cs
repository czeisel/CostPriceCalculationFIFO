using System;
using System.Collections.Generic;
using System.Text;

namespace MarkitWSO.Metrics
{
    //(Convert.ToDouble(tbSharesSold.Text) * Convert.ToDouble(tbPricePerShare.Text) - soldShareCost).ToString();//PnL
    class CalculatePnL
    {
        public double PnL(int BuyShareCount, double BuyPricePerShare, double SellPerShare)
        {
            return ((BuyShareCount * BuyPricePerShare) - SellPerShare);
        }
    }
}

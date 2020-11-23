using System;
using System.Collections.Generic;
using System.Text;

namespace MarkitWSO.Metrics
{
    class TradeCalculator
    {
        /// <summary>
        /// Shares Cost - Artifact Candidate
        /// </summary>
        /// <returns></returns>
        public double Cost(int count, double price)
        {
            return (count * price);
        }

        /// <summary>
        /// Profit and Loss - Artifact Candidate
        /// </summary>
        /// <returns></returns>
        public double PnL()
        {
            return 0.0;
        }


            
    }
}

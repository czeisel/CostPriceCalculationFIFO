using System;
using System.Collections.Generic;
using System.Text;

namespace MarkitWSO.Metrics
{
    class CalculateCost
    {
        /// <summary>
        /// Shares Cost - Artifact Candidate
        /// </summary>
        /// <returns></returns>
        public double Cost(int count, double price)
        {
            return (count * price);
        }
    }
}

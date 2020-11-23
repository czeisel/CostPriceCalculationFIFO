using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarkitWSO.Trading;
using MarkitWSO.Metrics;

namespace MarkitWSO
{
    public partial class frmMarkitWSO : Form
    {
        //Queue<Share> _QueuedShares = new Queue<Share>();//could use for FIFO 
        readonly TradeCalculator _Calculator = new TradeCalculator();
        List<Share> _SharesList;
        Share _share1 = new Share();
        Share _share2 = new Share();
        Share _share3 = new Share();
        private void frmMarkitWSO_Load(object sender, EventArgs e)
        {
            dtpSellDate.Value = Convert.ToDateTime("2/3/2005");

            _share1 = new Share();
            _share1.PurchaseDate = Convert.ToDateTime("01/01/2005");
            _share1.ShareCount = 100;
            _share1.SharePrice = 10.00;

            _SharesList = new List<Share>();

            _SharesList.Add(_share1);

            _share2.PurchaseDate = Convert.ToDateTime("2/2/2005");
            _share2.ShareCount = 40;
            _share2.SharePrice = 12.00;

            _SharesList.Add(_share2);

            _share3.PurchaseDate = Convert.ToDateTime("03/03/2005");
            _share3.ShareCount = 50;
            _share3.SharePrice = 11.00;

            _SharesList.Add(_share3);
        }

        public frmMarkitWSO()
        {
            InitializeComponent();
        }

        private void processList()
        {
            try
            {
                //get input
                int totalShareCount = _SharesList.Sum(x => x.ShareCount);
                int soldShareCount = Convert.ToInt32(tbSharesSold.Text);

                //process list
                if (soldShareCount <= totalShareCount)
                {
                    double soldShareCost = 0;
                    double remainingShareCost = 0;

                    int sharesSold = Convert.ToInt32(tbSharesSold.Text);
                    int remainingShares = 0;

                    foreach (Share share in _SharesList)
                    {
                        if (sharesSold > 0)
                        {
                            if (sharesSold >= share.ShareCount)
                            {
                                //metrics calculator.Cost implemented.
                                soldShareCost += _Calculator.Cost(share.ShareCount, share.SharePrice);
                            }
                            else if (sharesSold < share.ShareCount)
                            {
                                soldShareCost += sharesSold * share.SharePrice;

                                remainingShareCost = (share.ShareCount - sharesSold) * share.SharePrice;
                            }
                        }
                        else
                        {
                            remainingShareCost += share.ShareCount * share.SharePrice;
                        }
                        sharesSold -= share.ShareCount;
                    }

                    remainingShares = sharesSold * -1;

                    lblRemainingSharesResult.Text = remainingShares.ToString();
                    lblSoldSharesCostResult.Text = (soldShareCost / Convert.ToInt32(tbSharesSold.Text)).ToString();
                    lblSaleGainLossResults.Text = (Convert.ToDouble(tbSharesSold.Text) * Convert.ToDouble(tbPricePerShare.Text) - soldShareCost).ToString();
                    lblRemainingSharesCostResults.Text = (remainingShareCost / remainingShares).ToString();
                }
                else
                {
                    throw new Exception("Requested shares sold exceeds current shares available");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            #region Original Code
            //try
            //{
            //    //get input
            //    int totalShareCount = _SharesList.Sum(x => x.ShareCount);
            //    int soldShareCount = Convert.ToInt32(tbSharesSold.Text);

            //    //process list
            //    if (soldShareCount <= totalShareCount)
            //    {
            //        double soldShareCost = 0;
            //        double remainingShareCost = 0;

            //        int sharesSold = Convert.ToInt32(tbSharesSold.Text);
            //        int remainingShares = 0;

            //        foreach (Share share in _SharesList)
            //        {
            //            if (sharesSold > 0)
            //            {
            //                if (sharesSold >= share.ShareCount)
            //                {
            //                    //metrics calculator.Cost implemented.
            //                    soldShareCost += _Calculator.Cost(share.ShareCount, share.SharePrice);
            //                }
            //                else if (sharesSold < share.ShareCount)
            //                {
            //                    soldShareCost += sharesSold * share.SharePrice;

            //                    remainingShareCost = (share.ShareCount - sharesSold) * share.SharePrice;
            //                }
            //            }
            //            else
            //            {
            //                remainingShareCost += share.ShareCount * share.SharePrice;
            //            }
            //            sharesSold -= share.ShareCount;
            //        }

            //        remainingShares = sharesSold * -1;

            //        lblRemainingSharesResult.Text = remainingShares.ToString();
            //        lblSoldSharesCostResult.Text = (soldShareCost / Convert.ToInt32(tbSharesSold.Text)).ToString();
            //        lblSaleGainLossResults.Text = (Convert.ToDouble(tbSharesSold.Text) * Convert.ToDouble(tbPricePerShare.Text) - soldShareCost).ToString();
            //        lblRemainingSharesCostResults.Text = (remainingShareCost / remainingShares).ToString();
            //    }
            //    else
            //    {
            //        throw new Exception("Requested shares sold exceeds current shares available");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            #endregion
            processList();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            #region Testing Code - Don't Delete...Might need
            //tbLog.Clear();//just for debug

            //double soldShareCost = 0;
            //double remainingShareCost = 0;

            //int sharesSold = Convert.ToInt32(tbSharesSold.Text);
            //int remainingshares = 0;

            //foreach (Share share in qShares)
            //{
            //    if (sharesSold > 0)
            //    {
            //        if (sharesSold >= share.ShareCount)
            //        {
            //            soldShareCost += share.ShareCount * share.SharePrice;
            //        }
            //        else if (sharesSold < share.ShareCount)
            //        {
            //            soldShareCost += sharesSold * share.SharePrice;
            //            remainingShareCost = (share.ShareCount - sharesSold) * share.SharePrice;
            //        }
            //    }
            //    else
            //    {
            //        remainingShareCost += share.ShareCount * share.SharePrice;
            //    }
            //    sharesSold -= share.ShareCount;
            //}

            //remainingshares = sharesSold * -1;

            //lblRemainingSharesResult.Text = remainingshares.ToString();
            //lblSoldSharesCostResult.Text = (soldShareCost / Convert.ToInt32(tbSharesSold.Text)).ToString(); 
            //lblSaleGainLossResults.Text = (Convert.ToDouble(tbSharesSold.Text) * Convert.ToDouble(tbPricePerShare.Text) - soldShareCost).ToString();
            //lblRemainingSharesCostResults.Text = (remainingShareCost / remainingshares).ToString();
            //tbLog.Text += (remainingShareCost / remainingshares).ToString();
            #endregion
            CalculateCost cc = new CalculateCost();

            int totalShareCount = _SharesList.Sum(x => x.ShareCount);//Total number of shares
            int soldShareCount = Convert.ToInt32(tbSharesSold.Text);//Shares Sold

            if (soldShareCount <= totalShareCount)
            {
                double soldShareCost = 0;//cost per share
                double remainingShareCost = 0;//Remaining Share Count

                int sharesSold = Convert.ToInt32(tbSharesSold.Text);//how much the user is selling
                int remainingShares = 0;

                foreach (Share share in _SharesList)
                {
                    if (sharesSold > 0)
                    {
                        if (sharesSold >= share.ShareCount)
                        {
                            soldShareCost += cc.Cost(share.ShareCount, share.SharePrice);
                        }
                        else if (sharesSold < share.ShareCount)
                        {
                            soldShareCost += _Calculator.Cost(sharesSold, share.SharePrice);
                            remainingShareCost = _Calculator.Cost((share.ShareCount - sharesSold), share.SharePrice);
                        }
                    }
                    else
                    {
                        remainingShareCost += cc.Cost(share.ShareCount, share.SharePrice);
                    }
                    sharesSold -= share.ShareCount;
                }

                remainingShares = Math.Abs(sharesSold);//Absolute value for amount to work with 

                //display
                lblRemainingSharesResult.Text = remainingShares.ToString();//amount left
                lblSoldSharesCostResult.Text = (soldShareCost / Convert.ToInt32(tbSharesSold.Text)).ToString();//Cost for Sold Shares
                CalculatePnL cpnl = new CalculatePnL();
                lblSaleGainLossResults.Text = (cpnl.PnL(Convert.ToInt32(tbSharesSold.Text), Convert.ToDouble(tbPricePerShare.Text), soldShareCost)).ToString();
                lblRemainingSharesCostResults.Text = (remainingShareCost / remainingShares).ToString();//Cost Remaining Shares
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbPricePerShare.Clear();
            tbSharesSold.Clear();

            lblSaleGainLossResults.Text = "";
            lblRemainingSharesResult.Text = "";
            lblRemainingSharesCostResults.Text = "";
            lblSoldSharesCostResult.Text = "";
        }
    }
}

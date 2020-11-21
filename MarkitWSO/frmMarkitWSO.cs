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

namespace MarkitWSO
{
    public partial class frmMarkitWSO : Form
    {
        List<Share> SharesList;
        Queue<Share> qShares;
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

            qShares = new Queue<Share>();
            SharesList = new List<Share>();

            qShares.Enqueue(_share1);
            SharesList.Add(_share1);

            _share2.PurchaseDate = Convert.ToDateTime("2/2/2005");
            _share2.ShareCount = 40;
            _share2.SharePrice = 12.00;

            qShares.Enqueue(_share2);
            SharesList.Add(_share2);

            _share3.PurchaseDate = Convert.ToDateTime("03/03/2005");
            _share3.ShareCount = 50;
            _share3.SharePrice = 11.00;

            qShares.Enqueue(_share3);
            SharesList.Add(_share3);
        }

        public frmMarkitWSO()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int totalShareCount = qShares.Sum(x => x.ShareCount);
                int soldShareCount = Convert.ToInt32(tbSharesSold.Text);

                if (soldShareCount <= totalShareCount)
                {
                    double soldShareCost = 0;
                    double remainingShareCost = 0;

                    int sharesSold = Convert.ToInt32(tbSharesSold.Text);
                    int remainingShares = 0;

                    foreach (Share share in qShares)
                    {
                        if (sharesSold > 0)
                        {
                            if (sharesSold >= share.ShareCount)
                            {
                                soldShareCost += share.ShareCount * share.SharePrice;
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
                    tbLog.Text += (remainingShareCost / remainingShares).ToString();
                }
                else
                {
                    throw new Exception("Requested shares sold exceeds current shares available");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            int totalShareCount = qShares.Sum(x => x.ShareCount);
            int soldShareCount = Convert.ToInt32(tbSharesSold.Text);

            if (soldShareCount <= totalShareCount)
            {
                double soldShareCost = 0;
                double remainingShareCost = 0;

                int sharesSold = Convert.ToInt32(tbSharesSold.Text);
                int remainingShares = 0;

                foreach (Share share in SharesList)
                {
                    if (sharesSold > 0)
                    {
                        if (sharesSold >= share.ShareCount)
                        {
                            soldShareCost += share.ShareCount * share.SharePrice;
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

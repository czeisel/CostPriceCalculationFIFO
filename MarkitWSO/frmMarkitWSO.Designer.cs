namespace MarkitWSO
{
    partial class frmMarkitWSO
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarkitWSO));
            this.lblSharesSold = new System.Windows.Forms.Label();
            this.tbSharesSold = new System.Windows.Forms.TextBox();
            this.lblPricePerShare = new System.Windows.Forms.Label();
            this.tbPricePerShare = new System.Windows.Forms.TextBox();
            this.lblSellDate = new System.Windows.Forms.Label();
            this.dtpSellDate = new System.Windows.Forms.DateTimePicker();
            this.lblSoldSharesCost = new System.Windows.Forms.Label();
            this.lblSoldSharesCostResult = new System.Windows.Forms.Label();
            this.lblSaleGainLoss = new System.Windows.Forms.Label();
            this.lblSaleGainLossResults = new System.Windows.Forms.Label();
            this.lblRemainingShares = new System.Windows.Forms.Label();
            this.lblRemainingSharesResult = new System.Windows.Forms.Label();
            this.lblRemainingSharesCostResults = new System.Windows.Forms.Label();
            this.lblRemainingSharesCost = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSharesSold
            // 
            this.lblSharesSold.AutoSize = true;
            this.lblSharesSold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSharesSold.Location = new System.Drawing.Point(103, 14);
            this.lblSharesSold.Name = "lblSharesSold";
            this.lblSharesSold.Size = new System.Drawing.Size(95, 21);
            this.lblSharesSold.TabIndex = 0;
            this.lblSharesSold.Text = "Shares Sold:";
            // 
            // tbSharesSold
            // 
            this.tbSharesSold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSharesSold.Location = new System.Drawing.Point(204, 14);
            this.tbSharesSold.Name = "tbSharesSold";
            this.tbSharesSold.Size = new System.Drawing.Size(140, 29);
            this.tbSharesSold.TabIndex = 1;
            this.tbSharesSold.Text = "120";
            // 
            // lblPricePerShare
            // 
            this.lblPricePerShare.AutoSize = true;
            this.lblPricePerShare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPricePerShare.Location = new System.Drawing.Point(81, 49);
            this.lblPricePerShare.Name = "lblPricePerShare";
            this.lblPricePerShare.Size = new System.Drawing.Size(117, 21);
            this.lblPricePerShare.TabIndex = 2;
            this.lblPricePerShare.Text = "Price Per Share:";
            // 
            // tbPricePerShare
            // 
            this.tbPricePerShare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPricePerShare.Location = new System.Drawing.Point(204, 49);
            this.tbPricePerShare.Name = "tbPricePerShare";
            this.tbPricePerShare.Size = new System.Drawing.Size(140, 29);
            this.tbPricePerShare.TabIndex = 3;
            this.tbPricePerShare.Text = "10.5";
            // 
            // lblSellDate
            // 
            this.lblSellDate.AutoSize = true;
            this.lblSellDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSellDate.Location = new System.Drawing.Point(124, 88);
            this.lblSellDate.Name = "lblSellDate";
            this.lblSellDate.Size = new System.Drawing.Size(74, 21);
            this.lblSellDate.TabIndex = 4;
            this.lblSellDate.Text = "Sell Date:";
            // 
            // dtpSellDate
            // 
            this.dtpSellDate.Enabled = false;
            this.dtpSellDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpSellDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSellDate.Location = new System.Drawing.Point(204, 85);
            this.dtpSellDate.Name = "dtpSellDate";
            this.dtpSellDate.Size = new System.Drawing.Size(140, 29);
            this.dtpSellDate.TabIndex = 5;
            // 
            // lblSoldSharesCost
            // 
            this.lblSoldSharesCost.AutoSize = true;
            this.lblSoldSharesCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoldSharesCost.Location = new System.Drawing.Point(51, 144);
            this.lblSoldSharesCost.Name = "lblSoldSharesCost";
            this.lblSoldSharesCost.Size = new System.Drawing.Size(186, 21);
            this.lblSoldSharesCost.TabIndex = 6;
            this.lblSoldSharesCost.Text = "Cost Price of Sold Shares:";
            // 
            // lblSoldSharesCostResult
            // 
            this.lblSoldSharesCostResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoldSharesCostResult.Location = new System.Drawing.Point(243, 144);
            this.lblSoldSharesCostResult.Name = "lblSoldSharesCostResult";
            this.lblSoldSharesCostResult.Size = new System.Drawing.Size(140, 21);
            this.lblSoldSharesCostResult.TabIndex = 7;
            this.lblSoldSharesCostResult.Text = "Blank";
            this.lblSoldSharesCostResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaleGainLoss
            // 
            this.lblSaleGainLoss.AutoSize = true;
            this.lblSaleGainLoss.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaleGainLoss.Location = new System.Drawing.Point(99, 178);
            this.lblSaleGainLoss.Name = "lblSaleGainLoss";
            this.lblSaleGainLoss.Size = new System.Drawing.Size(138, 21);
            this.lblSaleGainLoss.TabIndex = 8;
            this.lblSaleGainLoss.Text = "Gain Loss On Sale:";
            // 
            // lblSaleGainLossResults
            // 
            this.lblSaleGainLossResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaleGainLossResults.Location = new System.Drawing.Point(243, 178);
            this.lblSaleGainLossResults.Name = "lblSaleGainLossResults";
            this.lblSaleGainLossResults.Size = new System.Drawing.Size(140, 21);
            this.lblSaleGainLossResults.TabIndex = 7;
            this.lblSaleGainLossResults.Text = "Blank";
            this.lblSaleGainLossResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemainingShares
            // 
            this.lblRemainingShares.AutoSize = true;
            this.lblRemainingShares.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRemainingShares.Location = new System.Drawing.Point(18, 210);
            this.lblRemainingShares.Name = "lblRemainingShares";
            this.lblRemainingShares.Size = new System.Drawing.Size(219, 21);
            this.lblRemainingShares.TabIndex = 8;
            this.lblRemainingShares.Text = "Number of Remaining Shares:";
            // 
            // lblRemainingSharesResult
            // 
            this.lblRemainingSharesResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRemainingSharesResult.Location = new System.Drawing.Point(243, 210);
            this.lblRemainingSharesResult.Name = "lblRemainingSharesResult";
            this.lblRemainingSharesResult.Size = new System.Drawing.Size(140, 21);
            this.lblRemainingSharesResult.TabIndex = 7;
            this.lblRemainingSharesResult.Text = "Blank";
            this.lblRemainingSharesResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemainingSharesCostResults
            // 
            this.lblRemainingSharesCostResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRemainingSharesCostResults.Location = new System.Drawing.Point(243, 246);
            this.lblRemainingSharesCostResults.Name = "lblRemainingSharesCostResults";
            this.lblRemainingSharesCostResults.Size = new System.Drawing.Size(140, 21);
            this.lblRemainingSharesCostResults.TabIndex = 7;
            this.lblRemainingSharesCostResults.Text = "Blank";
            this.lblRemainingSharesCostResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemainingSharesCost
            // 
            this.lblRemainingSharesCost.AutoSize = true;
            this.lblRemainingSharesCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRemainingSharesCost.Location = new System.Drawing.Point(7, 246);
            this.lblRemainingSharesCost.Name = "lblRemainingSharesCost";
            this.lblRemainingSharesCost.Size = new System.Drawing.Size(230, 21);
            this.lblRemainingSharesCost.TabIndex = 8;
            this.lblRemainingSharesCost.Text = "Cost Price of Remaining Shares:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(204, 120);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 21);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(301, 309);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(140, 24);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(301, 282);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 21);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmMarkitWSO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 341);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblRemainingSharesCost);
            this.Controls.Add(this.lblRemainingSharesCostResults);
            this.Controls.Add(this.lblRemainingSharesResult);
            this.Controls.Add(this.lblRemainingShares);
            this.Controls.Add(this.lblSaleGainLossResults);
            this.Controls.Add(this.lblSaleGainLoss);
            this.Controls.Add(this.lblSoldSharesCostResult);
            this.Controls.Add(this.lblSoldSharesCost);
            this.Controls.Add(this.dtpSellDate);
            this.Controls.Add(this.lblSellDate);
            this.Controls.Add(this.tbPricePerShare);
            this.Controls.Add(this.lblPricePerShare);
            this.Controls.Add(this.tbSharesSold);
            this.Controls.Add(this.lblSharesSold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMarkitWSO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Markit WSO - Cost Price Calculator";
            this.Load += new System.EventHandler(this.frmMarkitWSO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSharesSold;
        private System.Windows.Forms.TextBox tbSharesSold;
        private System.Windows.Forms.Label lblPricePerShare;
        private System.Windows.Forms.TextBox tbPricePerShare;
        private System.Windows.Forms.Label lblSellDate;
        private System.Windows.Forms.DateTimePicker dtpSellDate;
        private System.Windows.Forms.Label lblSoldSharesCost;
        private System.Windows.Forms.Label lblSoldSharesCostResult;
        private System.Windows.Forms.Label lblSaleGainLoss;
        private System.Windows.Forms.Label lblSaleGainLossResults;
        private System.Windows.Forms.Label lblRemainingShares;
        private System.Windows.Forms.Label lblRemainingSharesResult;
        private System.Windows.Forms.Label lblRemainingSharesCostResults;
        private System.Windows.Forms.Label lblRemainingSharesCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnReset;
    }
}


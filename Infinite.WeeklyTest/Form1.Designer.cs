namespace Infinite.WeeklyTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblCustCity = new System.Windows.Forms.Label();
            this.LblSortBy = new System.Windows.Forms.Label();
            this.TxtCustCity = new System.Windows.Forms.TextBox();
            this.CbSortBy = new System.Windows.Forms.ComboBox();
            this.BtnGetData = new System.Windows.Forms.Button();
            this.GridCust = new System.Windows.Forms.DataGridView();
            this.LblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridCust)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCustCity
            // 
            this.LblCustCity.AutoSize = true;
            this.LblCustCity.Location = new System.Drawing.Point(106, 72);
            this.LblCustCity.Name = "LblCustCity";
            this.LblCustCity.Size = new System.Drawing.Size(71, 13);
            this.LblCustCity.TabIndex = 0;
            this.LblCustCity.Text = "Customer City";
            // 
            // LblSortBy
            // 
            this.LblSortBy.AutoSize = true;
            this.LblSortBy.Location = new System.Drawing.Point(106, 109);
            this.LblSortBy.Name = "LblSortBy";
            this.LblSortBy.Size = new System.Drawing.Size(41, 13);
            this.LblSortBy.TabIndex = 1;
            this.LblSortBy.Text = "Sort By";
            // 
            // TxtCustCity
            // 
            this.TxtCustCity.Location = new System.Drawing.Point(253, 72);
            this.TxtCustCity.Name = "TxtCustCity";
            this.TxtCustCity.Size = new System.Drawing.Size(100, 20);
            this.TxtCustCity.TabIndex = 2;
            // 
            // CbSortBy
            // 
            this.CbSortBy.DisplayMember = "Credit Limit High to Low";
            this.CbSortBy.FormattingEnabled = true;
            this.CbSortBy.Items.AddRange(new object[] {
            "Credit Limit : Low to Hight"});
            this.CbSortBy.Location = new System.Drawing.Point(253, 109);
            this.CbSortBy.Name = "CbSortBy";
            this.CbSortBy.Size = new System.Drawing.Size(255, 21);
            this.CbSortBy.TabIndex = 3;
            // 
            // BtnGetData
            // 
            this.BtnGetData.Location = new System.Drawing.Point(677, 72);
            this.BtnGetData.Name = "BtnGetData";
            this.BtnGetData.Size = new System.Drawing.Size(75, 23);
            this.BtnGetData.TabIndex = 4;
            this.BtnGetData.Text = "Get Data";
            this.BtnGetData.UseVisualStyleBackColor = true;
            this.BtnGetData.Click += new System.EventHandler(this.BtnGetData_Click);
            // 
            // GridCust
            // 
            this.GridCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCust.Location = new System.Drawing.Point(109, 156);
            this.GridCust.Name = "GridCust";
            this.GridCust.Size = new System.Drawing.Size(464, 212);
            this.GridCust.TabIndex = 5;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Location = new System.Drawing.Point(338, 408);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(0, 13);
            this.LblMessage.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.GridCust);
            this.Controls.Add(this.BtnGetData);
            this.Controls.Add(this.CbSortBy);
            this.Controls.Add(this.TxtCustCity);
            this.Controls.Add(this.LblSortBy);
            this.Controls.Add(this.LblCustCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCustCity;
        private System.Windows.Forms.Label LblSortBy;
        private System.Windows.Forms.TextBox TxtCustCity;
        private System.Windows.Forms.ComboBox CbSortBy;
        private System.Windows.Forms.Button BtnGetData;
        private System.Windows.Forms.DataGridView GridCust;
        private System.Windows.Forms.Label LblMessage;
    }
}


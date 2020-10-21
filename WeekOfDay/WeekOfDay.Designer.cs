namespace WeekOfDay
{
    partial class weekOfDay
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblOutputDayOfWeek = new System.Windows.Forms.Label();
            this.txtInputYear = new System.Windows.Forms.TextBox();
            this.txtInputMonth = new System.Windows.Forms.TextBox();
            this.txtInputDay = new System.Windows.Forms.TextBox();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.numDay = new System.Windows.Forms.NumericUpDown();
            this.btnCalculation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(45, 134);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(41, 12);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "西暦年";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(213, 134);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(17, 12);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "月";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(323, 134);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(17, 12);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "日";
            // 
            // lblOutputDayOfWeek
            // 
            this.lblOutputDayOfWeek.AutoSize = true;
            this.lblOutputDayOfWeek.Location = new System.Drawing.Point(486, 156);
            this.lblOutputDayOfWeek.Name = "lblOutputDayOfWeek";
            this.lblOutputDayOfWeek.Size = new System.Drawing.Size(61, 12);
            this.lblOutputDayOfWeek.TabIndex = 3;
            this.lblOutputDayOfWeek.Text = "日曜日です";
            // 
            // txtInputYear
            // 
            this.txtInputYear.Location = new System.Drawing.Point(47, 149);
            this.txtInputYear.Name = "txtInputYear";
            this.txtInputYear.Size = new System.Drawing.Size(91, 19);
            this.txtInputYear.TabIndex = 4;
            this.txtInputYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputYear_KeyPress);
            // 
            // txtInputMonth
            // 
            this.txtInputMonth.Location = new System.Drawing.Point(215, 149);
            this.txtInputMonth.Name = "txtInputMonth";
            this.txtInputMonth.Size = new System.Drawing.Size(56, 19);
            this.txtInputMonth.TabIndex = 5;
            this.txtInputMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputMonth_KeyPress);
            // 
            // txtInputDay
            // 
            this.txtInputDay.Location = new System.Drawing.Point(325, 149);
            this.txtInputDay.Name = "txtInputDay";
            this.txtInputDay.Size = new System.Drawing.Size(56, 19);
            this.txtInputDay.TabIndex = 6;
            this.txtInputDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputDay_KeyPress);
            // 
            // numMonth
            // 
            this.numMonth.Location = new System.Drawing.Point(277, 150);
            this.numMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(20, 19);
            this.numMonth.TabIndex = 7;
            this.numMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDay
            // 
            this.numDay.Location = new System.Drawing.Point(387, 149);
            this.numDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDay.Name = "numDay";
            this.numDay.Size = new System.Drawing.Size(20, 19);
            this.numDay.TabIndex = 8;
            this.numDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalculation
            // 
            this.btnCalculation.Location = new System.Drawing.Point(47, 223);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(500, 25);
            this.btnCalculation.TabIndex = 9;
            this.btnCalculation.Text = "曜日算出";
            this.btnCalculation.UseVisualStyleBackColor = true;
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // weekOfDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculation);
            this.Controls.Add(this.numDay);
            this.Controls.Add(this.numMonth);
            this.Controls.Add(this.txtInputDay);
            this.Controls.Add(this.txtInputMonth);
            this.Controls.Add(this.txtInputYear);
            this.Controls.Add(this.lblOutputDayOfWeek);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblYear);
            this.Name = "weekOfDay";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblOutputDayOfWeek;
        private System.Windows.Forms.TextBox txtInputYear;
        private System.Windows.Forms.TextBox txtInputMonth;
        private System.Windows.Forms.TextBox txtInputDay;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.NumericUpDown numDay;
        private System.Windows.Forms.Button btnCalculation;
    }
}


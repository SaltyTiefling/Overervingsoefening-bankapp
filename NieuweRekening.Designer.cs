namespace Overervingsoefening_bankapp
{
    partial class fNieuweRekening
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
            this.cbxAntwoord = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numSaldo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxAntwoord
            // 
            this.cbxAntwoord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxAntwoord.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxAntwoord.FormattingEnabled = true;
            this.cbxAntwoord.Items.AddRange(new object[] {
            "Debit",
            "Credit",
            "Spaarrekening"});
            this.cbxAntwoord.Location = new System.Drawing.Point(13, 13);
            this.cbxAntwoord.Name = "cbxAntwoord";
            this.cbxAntwoord.Size = new System.Drawing.Size(213, 21);
            this.cbxAntwoord.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(151, 74);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "startbedrag";
            // 
            // numSaldo
            // 
            this.numSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numSaldo.DecimalPlaces = 2;
            this.numSaldo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numSaldo.Location = new System.Drawing.Point(78, 41);
            this.numSaldo.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numSaldo.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.numSaldo.Name = "numSaldo";
            this.numSaldo.Size = new System.Drawing.Size(147, 20);
            this.numSaldo.TabIndex = 3;
            this.numSaldo.ThousandsSeparator = true;
            // 
            // fNieuweRekening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 114);
            this.Controls.Add(this.numSaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbxAntwoord);
            this.Name = "fNieuweRekening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "nieuwe rekening";
            this.Load += new System.EventHandler(this.fNieuweRekening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSaldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxAntwoord;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSaldo;
    }
}
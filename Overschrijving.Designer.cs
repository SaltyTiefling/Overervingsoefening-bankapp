namespace Overervingsoefening_bankapp
{
    partial class fOverschrijving
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.numSaldo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.epAccount = new System.Windows.Forms.ErrorProvider(this.components);
            this.epbedrag = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epbedrag)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "naar:";
            // 
            // txtAccount
            // 
            this.txtAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAccount.Location = new System.Drawing.Point(51, 13);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(176, 20);
            this.txtAccount.TabIndex = 1;
            this.txtAccount.TextChanged += new System.EventHandler(this.txtAccount_TextChanged);
            // 
            // numSaldo
            // 
            this.numSaldo.DecimalPlaces = 2;
            this.numSaldo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numSaldo.Location = new System.Drawing.Point(62, 39);
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
            this.numSaldo.Size = new System.Drawing.Size(165, 20);
            this.numSaldo.TabIndex = 5;
            this.numSaldo.ThousandsSeparator = true;
            this.numSaldo.ValueChanged += new System.EventHandler(this.numSaldo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bedrag:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Overschrijven";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // epAccount
            // 
            this.epAccount.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epAccount.ContainerControl = this;
            // 
            // epbedrag
            // 
            this.epbedrag.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epbedrag.ContainerControl = this;
            // 
            // fOverschrijving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 100);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label1);
            this.Name = "fOverschrijving";
            this.Text = "Overschrijving";
            this.Load += new System.EventHandler(this.fOverschrijving_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epbedrag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.NumericUpDown numSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider epAccount;
        private System.Windows.Forms.ErrorProvider epbedrag;
    }
}
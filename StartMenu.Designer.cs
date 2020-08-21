namespace Overervingsoefening_bankapp
{
    partial class fStartMenu
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
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.lbxRekeningen = new System.Windows.Forms.ListBox();
            this.btnOverschrijven = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewAccount.Location = new System.Drawing.Point(12, 12);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(100, 121);
            this.btnNewAccount.TabIndex = 0;
            this.btnNewAccount.Text = "nieuw rekening";
            this.btnNewAccount.UseVisualStyleBackColor = true;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // lbxRekeningen
            // 
            this.lbxRekeningen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxRekeningen.FormattingEnabled = true;
            this.lbxRekeningen.Location = new System.Drawing.Point(118, 12);
            this.lbxRekeningen.Name = "lbxRekeningen";
            this.lbxRekeningen.Size = new System.Drawing.Size(319, 121);
            this.lbxRekeningen.TabIndex = 2;
            this.lbxRekeningen.SelectedIndexChanged += new System.EventHandler(this.lbxRekeningen_SelectedIndexChanged);
            // 
            // btnOverschrijven
            // 
            this.btnOverschrijven.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOverschrijven.Location = new System.Drawing.Point(443, 13);
            this.btnOverschrijven.Name = "btnOverschrijven";
            this.btnOverschrijven.Size = new System.Drawing.Size(84, 21);
            this.btnOverschrijven.TabIndex = 3;
            this.btnOverschrijven.Text = "Overschrijven";
            this.btnOverschrijven.UseVisualStyleBackColor = true;
            this.btnOverschrijven.Click += new System.EventHandler(this.btnOverschrijven_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerwijderen.BackColor = System.Drawing.Color.Red;
            this.btnVerwijderen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerwijderen.Location = new System.Drawing.Point(443, 40);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(84, 21);
            this.btnVerwijderen.TabIndex = 4;
            this.btnVerwijderen.Text = "Verwijder";
            this.btnVerwijderen.UseVisualStyleBackColor = false;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // fStartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 158);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnOverschrijven);
            this.Controls.Add(this.lbxRekeningen);
            this.Controls.Add(this.btnNewAccount);
            this.Name = "fStartMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fNewAccount_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.ListBox lbxRekeningen;
        private System.Windows.Forms.Button btnOverschrijven;
        private System.Windows.Forms.Button btnVerwijderen;
    }
}


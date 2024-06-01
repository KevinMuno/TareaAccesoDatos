namespace EntityFramework
{
    partial class frmPrincipal
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
            btnCustomers = new Button();
            btnCreditRisks = new Button();
            SuspendLayout();
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(59, 168);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(382, 147);
            btnCustomers.TabIndex = 0;
            btnCustomers.Text = "CRUD DE CUSTOMERS";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnCreditRisks
            // 
            btnCreditRisks.Location = new Point(579, 168);
            btnCreditRisks.Name = "btnCreditRisks";
            btnCreditRisks.Size = new Size(382, 147);
            btnCreditRisks.TabIndex = 1;
            btnCreditRisks.Text = "CRUD DE CREDIT_RISKS";
            btnCreditRisks.UseVisualStyleBackColor = true;
            btnCreditRisks.Click += btnCreditRisks_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 534);
            Controls.Add(btnCreditRisks);
            Controls.Add(btnCustomers);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCustomers;
        private Button btnCreditRisks;
    }
}
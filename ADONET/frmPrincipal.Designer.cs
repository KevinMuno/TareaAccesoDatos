namespace ADONET
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
            btnMakes = new Button();
            btnInventory = new Button();
            SuspendLayout();
            // 
            // btnMakes
            // 
            btnMakes.Location = new Point(92, 137);
            btnMakes.Name = "btnMakes";
            btnMakes.Size = new Size(299, 181);
            btnMakes.TabIndex = 0;
            btnMakes.Text = "CRUD DE MAKES";
            btnMakes.UseVisualStyleBackColor = true;
            btnMakes.Click += btnMakes_Click;
            // 
            // btnInventory
            // 
            btnInventory.Location = new Point(547, 137);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(299, 181);
            btnInventory.TabIndex = 1;
            btnInventory.Text = "CRUD DE INVENTORY";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 514);
            Controls.Add(btnInventory);
            Controls.Add(btnMakes);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMakes;
        private Button btnInventory;
    }
}
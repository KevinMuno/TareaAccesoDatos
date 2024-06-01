namespace ADONET_Inventory
{
    partial class FrmInventory
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
            label1 = new Label();
            label2 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtIDInventory = new TextBox();
            txtNameInv = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtColor = new TextBox();
            txtMakeId = new TextBox();
            dgvInventory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 78);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 17;
            label1.Text = "PetName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 168);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 32);
            label2.TabIndex = 20;
            label2.Text = "ID";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 408);
            btnAdd.Margin = new Padding(5, 6, 5, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(187, 50);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(322, 408);
            btnDelete.Margin = new Padding(5, 6, 5, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(202, 50);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(648, 408);
            btnUpdate.Margin = new Padding(5, 6, 5, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(184, 50);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtIDInventory
            // 
            txtIDInventory.Location = new Point(265, 163);
            txtIDInventory.Margin = new Padding(5, 6, 5, 6);
            txtIDInventory.Name = "txtIDInventory";
            txtIDInventory.Size = new Size(332, 39);
            txtIDInventory.TabIndex = 24;
            // 
            // txtNameInv
            // 
            txtNameInv.Location = new Point(265, 78);
            txtNameInv.Margin = new Padding(5, 6, 5, 6);
            txtNameInv.Name = "txtNameInv";
            txtNameInv.Size = new Size(332, 39);
            txtNameInv.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 339);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 27;
            label3.Text = "Color";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 254);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 32);
            label4.TabIndex = 28;
            label4.Text = "MakeID";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(265, 314);
            txtColor.Margin = new Padding(5, 6, 5, 6);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(332, 39);
            txtColor.TabIndex = 29;
            // 
            // txtMakeId
            // 
            txtMakeId.Location = new Point(265, 243);
            txtMakeId.Margin = new Padding(5, 6, 5, 6);
            txtMakeId.Name = "txtMakeId";
            txtMakeId.Size = new Size(332, 39);
            txtMakeId.TabIndex = 30;
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(20, 498);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersWidth = 82;
            dgvInventory.Size = new Size(812, 400);
            dgvInventory.TabIndex = 31;
            // 
            // FrmInventory
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 933);
            Controls.Add(dgvInventory);
            Controls.Add(txtMakeId);
            Controls.Add(txtColor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNameInv);
            Controls.Add(txtIDInventory);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FrmInventory";
            Text = "FrmInventory";
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtIDInventory;
        private TextBox txtNameInv;
        private Label label3;
        private Label label4;
        private TextBox txtColor;
        private TextBox txtMakeId;
        private DataGridView dgvInventory;
    }
}
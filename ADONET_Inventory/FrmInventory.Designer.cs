﻿namespace ADONET_Inventory
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
            dgvInventory = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            txtColor = new TextBox();
            txtMakeId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 49);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 17;
            label1.Text = "PetName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 105);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 20;
            label2.Text = "ID";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 255);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 31);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(198, 255);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 31);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(399, 255);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 31);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtIDInventory
            // 
            txtIDInventory.Location = new Point(163, 102);
            txtIDInventory.Margin = new Padding(3, 4, 3, 4);
            txtIDInventory.Name = "txtIDInventory";
            txtIDInventory.Size = new Size(206, 27);
            txtIDInventory.TabIndex = 24;
            // 
            // txtNameInv
            // 
            txtNameInv.Location = new Point(163, 49);
            txtNameInv.Margin = new Padding(3, 4, 3, 4);
            txtNameInv.Name = "txtNameInv";
            txtNameInv.Size = new Size(206, 27);
            txtNameInv.TabIndex = 25;
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(35, 320);
            dgvInventory.Margin = new Padding(3, 4, 3, 4);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(477, 227);
            dgvInventory.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 212);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 27;
            label3.Text = "Color";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 159);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 28;
            label4.Text = "MakeID";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(163, 196);
            txtColor.Margin = new Padding(3, 4, 3, 4);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(206, 27);
            txtColor.TabIndex = 29;
            // 
            // txtMakeId
            // 
            txtMakeId.Location = new Point(163, 152);
            txtMakeId.Margin = new Padding(3, 4, 3, 4);
            txtMakeId.Name = "txtMakeId";
            txtMakeId.Size = new Size(206, 27);
            txtMakeId.TabIndex = 30;
            // 
            // FrmInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 583);
            Controls.Add(txtMakeId);
            Controls.Add(txtColor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvInventory);
            Controls.Add(txtNameInv);
            Controls.Add(txtIDInventory);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private DataGridView dgvInventory;
        private Label label3;
        private Label label4;
        private TextBox txtColor;
        private TextBox txtMakeId;
    }
}
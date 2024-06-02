namespace ADONETInventory
{
    partial class frmInventory
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
            label3 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            txtMakeId = new TextBox();
            txtColor = new TextBox();
            txtPetName = new TextBox();
            dgvInventory = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 44);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 83);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "MakeID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 119);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Color";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 159);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "PetName";
            // 
            // txtID
            // 
            txtID.Location = new Point(120, 41);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(128, 23);
            txtID.TabIndex = 4;
            // 
            // txtMakeId
            // 
            txtMakeId.Location = new Point(120, 80);
            txtMakeId.Name = "txtMakeId";
            txtMakeId.Size = new Size(128, 23);
            txtMakeId.TabIndex = 5;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(120, 119);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(128, 23);
            txtColor.TabIndex = 6;
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(120, 156);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(128, 23);
            txtPetName.TabIndex = 7;
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(54, 278);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.Size = new Size(416, 194);
            dgvInventory.TabIndex = 8;
            dgvInventory.SelectionChanged += dgvInventory_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(55, 220);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "AGREGAR";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(175, 220);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "ACTUALIZAR";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(305, 220);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "ELIMINAR";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 544);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvInventory);
            Controls.Add(txtPetName);
            Controls.Add(txtColor);
            Controls.Add(txtMakeId);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmInventory";
            Text = "frmInventory";
            Load += frmInventory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private TextBox txtMakeId;
        private TextBox txtColor;
        private TextBox txtPetName;
        private DataGridView dgvInventory;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
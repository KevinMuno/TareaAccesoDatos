namespace InventoryADONET
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
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvInventory = new DataGridView();
            txtPetName = new TextBox();
            txtColor = new TextBox();
            txtMakeId = new TextBox();
            txtID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(293, 208);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "ELIMINAR";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(175, 208);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 23);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "ACTUALIZAR";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(55, 208);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "AGREGAR";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(54, 266);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.Size = new Size(416, 194);
            dgvInventory.TabIndex = 20;
            dgvInventory.SelectionChanged += dgvInventory_SelectionChanged;
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(120, 144);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(128, 23);
            txtPetName.TabIndex = 19;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(120, 107);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(128, 23);
            txtColor.TabIndex = 18;
            // 
            // txtMakeId
            // 
            txtMakeId.Location = new Point(120, 68);
            txtMakeId.Name = "txtMakeId";
            txtMakeId.Size = new Size(128, 23);
            txtMakeId.TabIndex = 17;
            // 
            // txtID
            // 
            txtID.Location = new Point(120, 29);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(128, 23);
            txtID.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 147);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 15;
            label4.Text = "PetName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 107);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 14;
            label3.Text = "Color";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 71);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 13;
            label2.Text = "MakeID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 32);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 12;
            label1.Text = "ID";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(395, 208);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 488);
            Controls.Add(btnLimpiar);
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

        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvInventory;
        private TextBox txtPetName;
        private TextBox txtColor;
        private TextBox txtMakeId;
        private TextBox txtID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLimpiar;
    }
}
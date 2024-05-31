namespace ADONETMake
{
    partial class frmMakes
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
            dgvMakes = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtID = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            txtName = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMakes).BeginInit();
            SuspendLayout();
            // 
            // dgvMakes
            // 
            dgvMakes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMakes.Location = new Point(20, 222);
            dgvMakes.Name = "dgvMakes";
            dgvMakes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMakes.Size = new Size(417, 170);
            dgvMakes.TabIndex = 23;
            dgvMakes.SelectionChanged += dgvMakes_SelectionChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(242, 158);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(131, 158);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(95, 111);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 114);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 19;
            label2.Text = "ID";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 158);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(95, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 71);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 16;
            label1.Text = "Nombre";
            // 
            // frmMakes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 461);
            Controls.Add(dgvMakes);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "frmMakes";
            Text = "frmMakes";
            Load += frmMakes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMakes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMakes;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtID;
        private Label label2;
        private Button btnAdd;
        private TextBox txtName;
        private Label label1;
    }
}
namespace ADONET
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
            txtMakeId = new TextBox();
            txtColor = new TextBox();
            txtPetName = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvInventory = new DataGridView();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 41);
            label1.Name = "label1";
            label1.Size = new Size(93, 32);
            label1.TabIndex = 0;
            label1.Text = "MakeId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 155);
            label2.Name = "label2";
            label2.Size = new Size(71, 32);
            label2.TabIndex = 1;
            label2.Text = "Color";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 263);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 2;
            label3.Text = "PetName";
            // 
            // txtMakeId
            // 
            txtMakeId.Location = new Point(179, 38);
            txtMakeId.Name = "txtMakeId";
            txtMakeId.Size = new Size(279, 39);
            txtMakeId.TabIndex = 3;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(179, 148);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(279, 39);
            txtColor.TabIndex = 4;
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(179, 256);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(279, 39);
            txtPetName.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(569, 16);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(223, 83);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(569, 212);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(223, 83);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(859, 212);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(223, 83);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(62, 326);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersWidth = 82;
            dgvInventory.Size = new Size(1020, 439);
            dgvInventory.TabIndex = 9;
            dgvInventory.SelectionChanged += dgvInventory_SelectionChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(859, 16);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(223, 83);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "LIMPIAR CAMPOS";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 801);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvInventory);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtPetName);
            Controls.Add(txtColor);
            Controls.Add(txtMakeId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmInventory";
            Text = "frmInventory";
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMakeId;
        private TextBox txtColor;
        private TextBox txtPetName;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private DataGridView dgvInventory;
        private Button btnLimpiar;
    }
}
namespace ADONET
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
            label1 = new Label();
            txtName = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvMakes = new DataGridView();
            label2 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMakes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 41);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(117, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 39);
            txtName.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(33, 119);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(215, 76);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(282, 119);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(215, 76);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(530, 119);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(215, 76);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvMakes
            // 
            dgvMakes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMakes.Location = new Point(33, 222);
            dgvMakes.Name = "dgvMakes";
            dgvMakes.RowHeadersWidth = 82;
            dgvMakes.Size = new Size(712, 429);
            dgvMakes.TabIndex = 5;
            dgvMakes.SelectionChanged += dgvMakes_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 42);
            label2.Name = "label2";
            label2.Size = new Size(37, 32);
            label2.TabIndex = 6;
            label2.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(504, 42);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(241, 39);
            txtId.TabIndex = 7;
            // 
            // frmMakes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 675);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(dgvMakes);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "frmMakes";
            Text = "frmMakes";
            ((System.ComponentModel.ISupportInitialize)dgvMakes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private DataGridView dgvMakes;
        private Label label2;
        private TextBox txtId;
    }
}
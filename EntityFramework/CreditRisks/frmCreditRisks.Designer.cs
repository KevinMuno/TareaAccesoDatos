namespace EntityFramework.CreditRisks
{
    partial class frmCreditRisks
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtCustomerId = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvCreditRisks = new DataGridView();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCreditRisks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 56);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 0;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 192);
            label2.Name = "label2";
            label2.Size = new Size(119, 32);
            label2.TabIndex = 1;
            label2.Text = "LastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 314);
            label3.Name = "label3";
            label3.Size = new Size(137, 32);
            label3.TabIndex = 2;
            label3.Text = "CustomerId";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(190, 49);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(336, 39);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(190, 185);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(336, 39);
            txtLastName.TabIndex = 4;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(190, 307);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(336, 39);
            txtCustomerId.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(671, 32);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(304, 72);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "CREAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(671, 124);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(304, 72);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(671, 218);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(304, 72);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvCreditRisks
            // 
            dgvCreditRisks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCreditRisks.Location = new Point(33, 419);
            dgvCreditRisks.Name = "dgvCreditRisks";
            dgvCreditRisks.RowHeadersWidth = 82;
            dgvCreditRisks.Size = new Size(942, 395);
            dgvCreditRisks.TabIndex = 9;
            dgvCreditRisks.SelectionChanged += dgvCreditRisks_SelectionChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(671, 314);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(304, 72);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "LIMPIAR CAMPOS";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmCreditRisks
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 842);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvCreditRisks);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtCustomerId);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCreditRisks";
            Text = "frmCreditRisks";
            ((System.ComponentModel.ISupportInitialize)dgvCreditRisks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtCustomerId;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private DataGridView dgvCreditRisks;
        private Button btnLimpiar;
    }
}
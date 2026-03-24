namespace SistemaUPGrafica
{
    partial class BuscarUsuarios
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
            buscarBtn = new Button();
            buscarTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btnAceptar = new Button();
            rechazarBtn = new Button();
            refrescarBtn = new Button();
            btnRefrescarLista = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buscarBtn
            // 
            buscarBtn.BackColor = SystemColors.Highlight;
            buscarBtn.FlatStyle = FlatStyle.Flat;
            buscarBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buscarBtn.ForeColor = SystemColors.ButtonHighlight;
            buscarBtn.Location = new Point(535, 79);
            buscarBtn.Margin = new Padding(4);
            buscarBtn.Name = "buscarBtn";
            buscarBtn.Size = new Size(88, 26);
            buscarBtn.TabIndex = 0;
            buscarBtn.Text = "Buscar";
            buscarBtn.UseVisualStyleBackColor = false;
            buscarBtn.Click += buscarBtn_Click;
            // 
            // buscarTxt
            // 
            buscarTxt.Location = new Point(256, 79);
            buscarTxt.Margin = new Padding(4);
            buscarTxt.Name = "buscarTxt";
            buscarTxt.PlaceholderText = "Ingrese el nombre de usuario";
            buscarTxt.Size = new Size(231, 23);
            buscarTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 16);
            label1.TabIndex = 2;
            label1.Text = "Buscar Usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(328, 149);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 16);
            label2.TabIndex = 3;
            label2.Text = "Usuarios";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(81, 169);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(591, 206);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Lime;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(106, 382);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(114, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar Usuario";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // rechazarBtn
            // 
            rechazarBtn.BackColor = Color.FromArgb(192, 0, 0);
            rechazarBtn.FlatStyle = FlatStyle.Flat;
            rechazarBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rechazarBtn.Location = new Point(237, 382);
            rechazarBtn.Name = "rechazarBtn";
            rechazarBtn.RightToLeft = RightToLeft.Yes;
            rechazarBtn.Size = new Size(114, 23);
            rechazarBtn.TabIndex = 6;
            rechazarBtn.Text = "Rechazar Usuario";
            rechazarBtn.UseVisualStyleBackColor = false;
            rechazarBtn.Click += rechazarBtn_Click;
            // 
            // refrescarBtn
            // 
            refrescarBtn.BackColor = Color.Yellow;
            refrescarBtn.FlatStyle = FlatStyle.Flat;
            refrescarBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            refrescarBtn.Location = new Point(376, 382);
            refrescarBtn.Name = "refrescarBtn";
            refrescarBtn.RightToLeft = RightToLeft.Yes;
            refrescarBtn.Size = new Size(146, 23);
            refrescarBtn.TabIndex = 8;
            refrescarBtn.Text = "Refrescar contraseña";
            refrescarBtn.UseVisualStyleBackColor = false;
            refrescarBtn.Click += refrescarBtn_Click;
            // 
            // btnRefrescarLista
            // 
            btnRefrescarLista.BackColor = SystemColors.Highlight;
            btnRefrescarLista.FlatStyle = FlatStyle.Flat;
            btnRefrescarLista.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefrescarLista.ForeColor = SystemColors.Control;
            btnRefrescarLista.Location = new Point(81, 139);
            btnRefrescarLista.Name = "btnRefrescarLista";
            btnRefrescarLista.Size = new Size(119, 23);
            btnRefrescarLista.TabIndex = 9;
            btnRefrescarLista.Text = "Refrescar Lista";
            btnRefrescarLista.UseVisualStyleBackColor = false;
            btnRefrescarLista.Click += btnRefrescarLista_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(545, 382);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.RightToLeft = RightToLeft.Yes;
            btnEliminar.Size = new Size(114, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // BuscarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(777, 482);
            Controls.Add(btnEliminar);
            Controls.Add(btnRefrescarLista);
            Controls.Add(refrescarBtn);
            Controls.Add(rechazarBtn);
            Controls.Add(btnAceptar);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buscarTxt);
            Controls.Add(buscarBtn);
            Margin = new Padding(4);
            Name = "BuscarUsuarios";
            Text = "BuscarUsuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.TextBox buscarTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button btnAceptar;
        private Button rechazarBtn;
        private Button refrescarBtn;
        private Button btnRefrescarLista;
        private Button btnEliminar;
    }
}
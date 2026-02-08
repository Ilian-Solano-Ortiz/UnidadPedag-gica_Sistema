namespace SistemaHojasDeMatricula
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registrarseBtn = new System.Windows.Forms.Button();
            this.contraseñaTxt = new System.Windows.Forms.TextBox();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.ingresarBtn = new System.Windows.Forms.Button();
            this.contrasenalbl = new System.Windows.Forms.Label();
            this.usuariolbl = new System.Windows.Forms.Label();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contenedor.Controls.Add(this.label2);
            this.contenedor.Controls.Add(this.label1);
            this.contenedor.Controls.Add(this.pictureBox1);
            this.contenedor.Controls.Add(this.registrarseBtn);
            this.contenedor.Controls.Add(this.contraseñaTxt);
            this.contenedor.Controls.Add(this.usuarioTxt);
            this.contenedor.Controls.Add(this.ingresarBtn);
            this.contenedor.Controls.Add(this.contrasenalbl);
            this.contenedor.Controls.Add(this.usuariolbl);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 0);
            this.contenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1067, 554);
            this.contenedor.TabIndex = 0;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sistema Formulario de Matrícula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Unidad Pedagógica Río Cuba";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaHojasDeMatricula.Properties.Resources.UPLogo;
            this.pictureBox1.Location = new System.Drawing.Point(39, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // registrarseBtn
            // 
            this.registrarseBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registrarseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registrarseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarseBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registrarseBtn.Location = new System.Drawing.Point(511, 341);
            this.registrarseBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registrarseBtn.Name = "registrarseBtn";
            this.registrarseBtn.Size = new System.Drawing.Size(203, 34);
            this.registrarseBtn.TabIndex = 5;
            this.registrarseBtn.Text = "Registrarse";
            this.registrarseBtn.UseVisualStyleBackColor = false;
            this.registrarseBtn.Click += new System.EventHandler(this.registrarseBtn_Click);
            // 
            // contraseñaTxt
            // 
            this.contraseñaTxt.Location = new System.Drawing.Point(511, 240);
            this.contraseñaTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contraseñaTxt.Name = "contraseñaTxt";
            this.contraseñaTxt.Size = new System.Drawing.Size(201, 22);
            this.contraseñaTxt.TabIndex = 4;
            this.contraseñaTxt.UseSystemPasswordChar = true;
            this.contraseñaTxt.TextChanged += new System.EventHandler(this.contraseñaTxt_TextChanged);
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Location = new System.Drawing.Point(511, 188);
            this.usuarioTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(201, 22);
            this.usuarioTxt.TabIndex = 3;
            // 
            // ingresarBtn
            // 
            this.ingresarBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ingresarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ingresarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ingresarBtn.Location = new System.Drawing.Point(511, 300);
            this.ingresarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ingresarBtn.Name = "ingresarBtn";
            this.ingresarBtn.Size = new System.Drawing.Size(203, 33);
            this.ingresarBtn.TabIndex = 2;
            this.ingresarBtn.Text = "Ingresar";
            this.ingresarBtn.UseVisualStyleBackColor = false;
            this.ingresarBtn.Click += new System.EventHandler(this.ingresarBtn_Click);
            // 
            // contrasenalbl
            // 
            this.contrasenalbl.AutoSize = true;
            this.contrasenalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenalbl.Location = new System.Drawing.Point(379, 245);
            this.contrasenalbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contrasenalbl.Name = "contrasenalbl";
            this.contrasenalbl.Size = new System.Drawing.Size(95, 20);
            this.contrasenalbl.TabIndex = 1;
            this.contrasenalbl.Text = "Contraseña";
            // 
            // usuariolbl
            // 
            this.usuariolbl.AutoSize = true;
            this.usuariolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariolbl.Location = new System.Drawing.Point(379, 193);
            this.usuariolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usuariolbl.Name = "usuariolbl";
            this.usuariolbl.Size = new System.Drawing.Size(67, 20);
            this.usuariolbl.TabIndex = 0;
            this.usuariolbl.Text = "Usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.contenedor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Form1";
            this.contenedor.ResumeLayout(false);
            this.contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label contrasenalbl;
        private System.Windows.Forms.Label usuariolbl;
        private System.Windows.Forms.TextBox contraseñaTxt;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.Button ingresarBtn;
        private System.Windows.Forms.Button registrarseBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


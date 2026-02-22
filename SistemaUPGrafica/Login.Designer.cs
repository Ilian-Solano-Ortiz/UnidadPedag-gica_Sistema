namespace SistemaUPGrafica
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
            contenedor = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            registrarseBtn = new Button();
            contraseñaTxt = new TextBox();
            usuarioTxt = new TextBox();
            ingresarBtn = new Button();
            contrasenalbl = new Label();
            usuariolbl = new Label();
            contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contenedor
            // 
            contenedor.BackColor = SystemColors.ButtonHighlight;
            contenedor.Controls.Add(label2);
            contenedor.Controls.Add(label1);
            contenedor.Controls.Add(pictureBox1);
            contenedor.Controls.Add(registrarseBtn);
            contenedor.Controls.Add(contraseñaTxt);
            contenedor.Controls.Add(usuarioTxt);
            contenedor.Controls.Add(ingresarBtn);
            contenedor.Controls.Add(contrasenalbl);
            contenedor.Controls.Add(usuariolbl);
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 0);
            contenedor.Margin = new Padding(4, 5, 4, 5);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1067, 692);
            contenedor.TabIndex = 0;
            contenedor.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(379, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(310, 24);
            label2.TabIndex = 8;
            label2.Text = "Sistema Formulario de Matrícula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 435);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 17);
            label1.TabIndex = 7;
            label1.Text = "Unidad Pedagógica Río Cuba";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.UPLogo;
            pictureBox1.Location = new Point(39, 128);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 303);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // registrarseBtn
            // 
            registrarseBtn.BackColor = SystemColors.ActiveCaptionText;
            registrarseBtn.FlatStyle = FlatStyle.Popup;
            registrarseBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registrarseBtn.ForeColor = SystemColors.ButtonHighlight;
            registrarseBtn.Location = new Point(511, 426);
            registrarseBtn.Margin = new Padding(4, 5, 4, 5);
            registrarseBtn.Name = "registrarseBtn";
            registrarseBtn.Size = new Size(203, 43);
            registrarseBtn.TabIndex = 5;
            registrarseBtn.Text = "Registrarse";
            registrarseBtn.UseVisualStyleBackColor = false;
            registrarseBtn.Click += registrarseBtn_Click;
            // 
            // contraseñaTxt
            // 
            contraseñaTxt.Location = new Point(511, 300);
            contraseñaTxt.Margin = new Padding(4, 5, 4, 5);
            contraseñaTxt.Name = "contraseñaTxt";
            contraseñaTxt.Size = new Size(201, 27);
            contraseñaTxt.TabIndex = 4;
            contraseñaTxt.UseSystemPasswordChar = true;
            // 
            // usuarioTxt
            // 
            usuarioTxt.Location = new Point(511, 235);
            usuarioTxt.Margin = new Padding(4, 5, 4, 5);
            usuarioTxt.Name = "usuarioTxt";
            usuarioTxt.Size = new Size(201, 27);
            usuarioTxt.TabIndex = 3;
            // 
            // ingresarBtn
            // 
            ingresarBtn.BackColor = SystemColors.ActiveCaptionText;
            ingresarBtn.FlatStyle = FlatStyle.Popup;
            ingresarBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ingresarBtn.ForeColor = SystemColors.ButtonHighlight;
            ingresarBtn.Location = new Point(511, 375);
            ingresarBtn.Margin = new Padding(4, 5, 4, 5);
            ingresarBtn.Name = "ingresarBtn";
            ingresarBtn.Size = new Size(203, 42);
            ingresarBtn.TabIndex = 2;
            ingresarBtn.Text = "Ingresar";
            ingresarBtn.UseVisualStyleBackColor = false;
            ingresarBtn.Click += ingresarBtn_Click;
            // 
            // contrasenalbl
            // 
            contrasenalbl.AutoSize = true;
            contrasenalbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contrasenalbl.Location = new Point(379, 306);
            contrasenalbl.Margin = new Padding(4, 0, 4, 0);
            contrasenalbl.Name = "contrasenalbl";
            contrasenalbl.Size = new Size(95, 20);
            contrasenalbl.TabIndex = 1;
            contrasenalbl.Text = "Contraseña";
            // 
            // usuariolbl
            // 
            usuariolbl.AutoSize = true;
            usuariolbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usuariolbl.Location = new Point(379, 242);
            usuariolbl.Margin = new Padding(4, 0, 4, 0);
            usuariolbl.Name = "usuariolbl";
            usuariolbl.Size = new Size(67, 20);
            usuariolbl.TabIndex = 0;
            usuariolbl.Text = "Usuario";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(contenedor);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            Text = "Form1";
            contenedor.ResumeLayout(false);
            contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

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


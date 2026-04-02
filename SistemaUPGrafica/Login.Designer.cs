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
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            registrarseBtn = new Button();
            contraseñaTxt = new TextBox();
            cedulaTxt = new TextBox();
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
            contenedor.Controls.Add(button2);
            contenedor.Controls.Add(label2);
            contenedor.Controls.Add(label1);
            contenedor.Controls.Add(pictureBox1);
            contenedor.Controls.Add(registrarseBtn);
            contenedor.Controls.Add(contraseñaTxt);
            contenedor.Controls.Add(cedulaTxt);
            contenedor.Controls.Add(ingresarBtn);
            contenedor.Controls.Add(contrasenalbl);
            contenedor.Controls.Add(usuariolbl);
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 0);
            contenedor.Margin = new Padding(4);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(934, 519);
            contenedor.TabIndex = 0;
            contenedor.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(642, 227);
            button2.Name = "button2";
            button2.Size = new Size(61, 23);
            button2.TabIndex = 14;
            button2.Text = "Ver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(332, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(253, 18);
            label2.TabIndex = 8;
            label2.Text = "Sistema Formulario de Matrícula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 326);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 13);
            label1.TabIndex = 7;
            label1.Text = "Unidad Pedagógica Río Cuba";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.UPLogo;
            pictureBox1.Location = new Point(34, 96);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 227);
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
            registrarseBtn.Location = new Point(447, 320);
            registrarseBtn.Margin = new Padding(4);
            registrarseBtn.Name = "registrarseBtn";
            registrarseBtn.Size = new Size(178, 32);
            registrarseBtn.TabIndex = 5;
            registrarseBtn.Text = "Registrarse";
            registrarseBtn.UseVisualStyleBackColor = false;
            registrarseBtn.Click += registrarseBtn_Click;
            // 
            // contraseñaTxt
            // 
            contraseñaTxt.Location = new Point(447, 225);
            contraseñaTxt.Margin = new Padding(4);
            contraseñaTxt.Name = "contraseñaTxt";
            contraseñaTxt.Size = new Size(176, 23);
            contraseñaTxt.TabIndex = 4;
            contraseñaTxt.UseSystemPasswordChar = true;
            // 
            // cedulaTxt
            // 
            cedulaTxt.Location = new Point(447, 176);
            cedulaTxt.Margin = new Padding(4);
            cedulaTxt.Name = "cedulaTxt";
            cedulaTxt.Size = new Size(176, 23);
            cedulaTxt.TabIndex = 3;
            // 
            // ingresarBtn
            // 
            ingresarBtn.BackColor = SystemColors.ActiveCaptionText;
            ingresarBtn.FlatStyle = FlatStyle.Popup;
            ingresarBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ingresarBtn.ForeColor = SystemColors.ButtonHighlight;
            ingresarBtn.Location = new Point(447, 281);
            ingresarBtn.Margin = new Padding(4);
            ingresarBtn.Name = "ingresarBtn";
            ingresarBtn.Size = new Size(178, 32);
            ingresarBtn.TabIndex = 2;
            ingresarBtn.Text = "Ingresar";
            ingresarBtn.UseVisualStyleBackColor = false;
            ingresarBtn.Click += ingresarBtn_Click;
            // 
            // contrasenalbl
            // 
            contrasenalbl.AutoSize = true;
            contrasenalbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contrasenalbl.Location = new Point(332, 230);
            contrasenalbl.Margin = new Padding(4, 0, 4, 0);
            contrasenalbl.Name = "contrasenalbl";
            contrasenalbl.Size = new Size(76, 16);
            contrasenalbl.TabIndex = 1;
            contrasenalbl.Text = "Contraseña";
            // 
            // usuariolbl
            // 
            usuariolbl.AutoSize = true;
            usuariolbl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usuariolbl.Location = new Point(332, 182);
            usuariolbl.Margin = new Padding(4, 0, 4, 0);
            usuariolbl.Name = "usuariolbl";
            usuariolbl.Size = new Size(50, 16);
            usuariolbl.TabIndex = 0;
            usuariolbl.Text = "Cédula";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 519);
            Controls.Add(contenedor);
            Margin = new Padding(4);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
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
        private System.Windows.Forms.TextBox cedulaTxt;
        private System.Windows.Forms.Button ingresarBtn;
        private System.Windows.Forms.Button registrarseBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Button button2;
    }
}


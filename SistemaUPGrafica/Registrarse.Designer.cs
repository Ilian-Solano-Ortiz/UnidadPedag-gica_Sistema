namespace SistemaUPGrafica
{
    partial class Registrarse
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
            label5 = new Label();
            nombreTxt = new TextBox();
            contrasenaTxt = new TextBox();
            confirmarContraTxt = new TextBox();
            pictureBox1 = new PictureBox();
            atrasBtn = new Button();
            registrarseBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            cedulaTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(491, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 18);
            label1.TabIndex = 0;
            label1.Text = "Registrarse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(309, 127);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 16);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(309, 240);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 16);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(309, 291);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 16);
            label5.TabIndex = 4;
            label5.Text = "Confimar Contraseña";
            // 
            // nombreTxt
            // 
            nombreTxt.Location = new Point(470, 126);
            nombreTxt.Margin = new Padding(4, 3, 4, 3);
            nombreTxt.Name = "nombreTxt";
            nombreTxt.Size = new Size(184, 23);
            nombreTxt.TabIndex = 5;
            // 
            // contrasenaTxt
            // 
            contrasenaTxt.Location = new Point(470, 233);
            contrasenaTxt.Margin = new Padding(4, 3, 4, 3);
            contrasenaTxt.Name = "contrasenaTxt";
            contrasenaTxt.Size = new Size(184, 23);
            contrasenaTxt.TabIndex = 7;
            contrasenaTxt.UseSystemPasswordChar = true;
            // 
            // confirmarContraTxt
            // 
            confirmarContraTxt.Location = new Point(470, 284);
            confirmarContraTxt.Margin = new Padding(4, 3, 4, 3);
            confirmarContraTxt.Name = "confirmarContraTxt";
            confirmarContraTxt.Size = new Size(184, 23);
            confirmarContraTxt.TabIndex = 8;
            confirmarContraTxt.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.UPLogo;
            pictureBox1.Location = new Point(4, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // atrasBtn
            // 
            atrasBtn.BackColor = SystemColors.ActiveCaptionText;
            atrasBtn.FlatStyle = FlatStyle.Flat;
            atrasBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            atrasBtn.ForeColor = SystemColors.ButtonHighlight;
            atrasBtn.Location = new Point(4, 489);
            atrasBtn.Margin = new Padding(4, 3, 4, 3);
            atrasBtn.Name = "atrasBtn";
            atrasBtn.Size = new Size(88, 27);
            atrasBtn.TabIndex = 10;
            atrasBtn.Text = "Atrás";
            atrasBtn.UseVisualStyleBackColor = false;
            atrasBtn.Click += button1_Click;
            // 
            // registrarseBtn
            // 
            registrarseBtn.BackColor = SystemColors.ActiveCaptionText;
            registrarseBtn.FlatStyle = FlatStyle.Flat;
            registrarseBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registrarseBtn.ForeColor = SystemColors.ButtonHighlight;
            registrarseBtn.Location = new Point(470, 352);
            registrarseBtn.Margin = new Padding(4, 3, 4, 3);
            registrarseBtn.Name = "registrarseBtn";
            registrarseBtn.Size = new Size(184, 27);
            registrarseBtn.TabIndex = 11;
            registrarseBtn.Text = "Registrarse";
            registrarseBtn.UseVisualStyleBackColor = false;
            registrarseBtn.Click += registrarseBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(673, 233);
            button1.Name = "button1";
            button1.Size = new Size(52, 23);
            button1.TabIndex = 12;
            button1.Text = "Ver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(673, 284);
            button2.Name = "button2";
            button2.Size = new Size(52, 23);
            button2.TabIndex = 13;
            button2.Text = "Ver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(309, 183);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 16);
            label4.TabIndex = 14;
            label4.Text = "Cédula";
            // 
            // cedulaTxt
            // 
            cedulaTxt.Location = new Point(470, 183);
            cedulaTxt.Margin = new Padding(4, 3, 4, 3);
            cedulaTxt.Name = "cedulaTxt";
            cedulaTxt.Size = new Size(184, 23);
            cedulaTxt.TabIndex = 15;
            // 
            // Registrarse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(933, 519);
            Controls.Add(cedulaTxt);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(registrarseBtn);
            Controls.Add(atrasBtn);
            Controls.Add(pictureBox1);
            Controls.Add(confirmarContraTxt);
            Controls.Add(contrasenaTxt);
            Controls.Add(nombreTxt);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Registrarse";
            Text = "Form1";
            Load += Registrarse_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox contrasenaTxt;
        private System.Windows.Forms.TextBox confirmarContraTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button atrasBtn;
        private System.Windows.Forms.Button registrarseBtn;
        private Button button1;
        private Button button2;
        private Label label4;
        private TextBox cedulaTxt;
    }
}
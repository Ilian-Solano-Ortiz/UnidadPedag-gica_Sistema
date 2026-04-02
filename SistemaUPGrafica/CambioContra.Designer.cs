namespace SistemaUPGrafica
{
    partial class CambioContra
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            contraNuevaTxt = new TextBox();
            contraAnteriorTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            confirmarBtn = new Button();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2026_01_26_230308;
            pictureBox1.Location = new Point(274, 59);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 121);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 16);
            label1.TabIndex = 1;
            label1.Text = "Cambiar Contraseña";
            // 
            // contraNuevaTxt
            // 
            contraNuevaTxt.Location = new Point(274, 288);
            contraNuevaTxt.Margin = new Padding(4, 3, 4, 3);
            contraNuevaTxt.Name = "contraNuevaTxt";
            contraNuevaTxt.Size = new Size(192, 23);
            contraNuevaTxt.TabIndex = 2;
            contraNuevaTxt.UseSystemPasswordChar = true;
            // 
            // contraAnteriorTxt
            // 
            contraAnteriorTxt.Location = new Point(274, 234);
            contraAnteriorTxt.Margin = new Padding(4, 3, 4, 3);
            contraAnteriorTxt.Name = "contraAnteriorTxt";
            contraAnteriorTxt.Size = new Size(192, 23);
            contraAnteriorTxt.TabIndex = 3;
            contraAnteriorTxt.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(299, 216);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 16);
            label2.TabIndex = 5;
            label2.Text = "Contraseña Actual";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(299, 270);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 16);
            label3.TabIndex = 6;
            label3.Text = "Contraseña Nueva";
            // 
            // confirmarBtn
            // 
            confirmarBtn.BackColor = SystemColors.ActiveCaptionText;
            confirmarBtn.FlatStyle = FlatStyle.Flat;
            confirmarBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmarBtn.ForeColor = Color.White;
            confirmarBtn.Location = new Point(274, 350);
            confirmarBtn.Margin = new Padding(4, 3, 4, 3);
            confirmarBtn.Name = "confirmarBtn";
            confirmarBtn.Size = new Size(192, 27);
            confirmarBtn.TabIndex = 8;
            confirmarBtn.Text = "Confirmar";
            confirmarBtn.UseVisualStyleBackColor = false;
            confirmarBtn.Click += confirmarBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(321, 27);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 9;
            label5.Text = "Usuario: ";
            // 
            // button2
            // 
            button2.Location = new Point(473, 234);
            button2.Name = "button2";
            button2.Size = new Size(61, 23);
            button2.TabIndex = 15;
            button2.Text = "Ver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(473, 288);
            button1.Name = "button1";
            button1.Size = new Size(61, 23);
            button1.TabIndex = 16;
            button1.Text = "Ver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CambioContra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(778, 474);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(confirmarBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(contraAnteriorTxt);
            Controls.Add(contraNuevaTxt);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CambioContra";
            Text = "CambioContra";
            Load += CambioContra_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contraNuevaTxt;
        private System.Windows.Forms.TextBox contraAnteriorTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confirmarBtn;
        private Label label5;
        private Button button2;
        private Button button1;
    }
}
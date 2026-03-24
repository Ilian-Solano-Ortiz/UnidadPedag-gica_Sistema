namespace SistemaUPGrafica
{
    partial class FrmContenedor
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
            navegacionPanel = new Panel();
            pictureBox1 = new PictureBox();
            cambiarContraBtn = new Button();
            cerrarSesionBtn = new Button();
            usuariosBtn = new Button();
            estudiantesBtn = new Button();
            panel1 = new Panel();
            contenedor = new Panel();
            navegacionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // navegacionPanel
            // 
            navegacionPanel.BackColor = SystemColors.ButtonHighlight;
            navegacionPanel.BorderStyle = BorderStyle.Fixed3D;
            navegacionPanel.Controls.Add(pictureBox1);
            navegacionPanel.Controls.Add(cambiarContraBtn);
            navegacionPanel.Controls.Add(cerrarSesionBtn);
            navegacionPanel.Controls.Add(usuariosBtn);
            navegacionPanel.Controls.Add(estudiantesBtn);
            navegacionPanel.Controls.Add(panel1);
            navegacionPanel.Dock = DockStyle.Left;
            navegacionPanel.Location = new Point(0, 0);
            navegacionPanel.Margin = new Padding(4, 3, 4, 3);
            navegacionPanel.Name = "navegacionPanel";
            navegacionPanel.Size = new Size(136, 519);
            navegacionPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.UPLogo;
            pictureBox1.Location = new Point(10, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // cambiarContraBtn
            // 
            cambiarContraBtn.BackColor = SystemColors.ActiveCaptionText;
            cambiarContraBtn.FlatStyle = FlatStyle.Flat;
            cambiarContraBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cambiarContraBtn.ForeColor = SystemColors.ButtonHighlight;
            cambiarContraBtn.Location = new Point(4, 451);
            cambiarContraBtn.Margin = new Padding(4, 3, 4, 3);
            cambiarContraBtn.Name = "cambiarContraBtn";
            cambiarContraBtn.Size = new Size(124, 27);
            cambiarContraBtn.TabIndex = 4;
            cambiarContraBtn.Text = "Contraseña";
            cambiarContraBtn.UseVisualStyleBackColor = false;
            cambiarContraBtn.Click += cambiarContraBtn_Click;
            // 
            // cerrarSesionBtn
            // 
            cerrarSesionBtn.BackColor = Color.Red;
            cerrarSesionBtn.FlatStyle = FlatStyle.Flat;
            cerrarSesionBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cerrarSesionBtn.ForeColor = SystemColors.ButtonHighlight;
            cerrarSesionBtn.Location = new Point(4, 485);
            cerrarSesionBtn.Margin = new Padding(4, 3, 4, 3);
            cerrarSesionBtn.Name = "cerrarSesionBtn";
            cerrarSesionBtn.Size = new Size(124, 27);
            cerrarSesionBtn.TabIndex = 3;
            cerrarSesionBtn.Text = "Cerrar Sesión";
            cerrarSesionBtn.UseVisualStyleBackColor = false;
            cerrarSesionBtn.Click += cerrarSesionBtn_Click;
            // 
            // usuariosBtn
            // 
            usuariosBtn.BackColor = SystemColors.ActiveCaptionText;
            usuariosBtn.FlatStyle = FlatStyle.Flat;
            usuariosBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usuariosBtn.ForeColor = SystemColors.ButtonHighlight;
            usuariosBtn.Location = new Point(4, 173);
            usuariosBtn.Margin = new Padding(4, 3, 4, 3);
            usuariosBtn.Name = "usuariosBtn";
            usuariosBtn.Size = new Size(124, 27);
            usuariosBtn.TabIndex = 2;
            usuariosBtn.Text = "Usuarios";
            usuariosBtn.UseVisualStyleBackColor = false;
            usuariosBtn.Click += usuariosBtn_Click;
            // 
            // estudiantesBtn
            // 
            estudiantesBtn.BackColor = SystemColors.ActiveCaptionText;
            estudiantesBtn.FlatStyle = FlatStyle.Flat;
            estudiantesBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            estudiantesBtn.ForeColor = SystemColors.ButtonHighlight;
            estudiantesBtn.Location = new Point(5, 140);
            estudiantesBtn.Margin = new Padding(4, 3, 4, 3);
            estudiantesBtn.Name = "estudiantesBtn";
            estudiantesBtn.Size = new Size(124, 27);
            estudiantesBtn.TabIndex = 0;
            estudiantesBtn.Text = "Estudiantes";
            estudiantesBtn.UseVisualStyleBackColor = false;
            estudiantesBtn.Click += estudiantesBtn_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(144, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 519);
            panel1.TabIndex = 1;
            // 
            // contenedor
            // 
            contenedor.BackColor = SystemColors.ButtonHighlight;
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(136, 0);
            contenedor.Margin = new Padding(4, 3, 4, 3);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(797, 519);
            contenedor.TabIndex = 1;
            // 
            // FrmContenedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(contenedor);
            Controls.Add(navegacionPanel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmContenedor";
            Text = "Form1";
            navegacionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navegacionPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cerrarSesionBtn;
        private System.Windows.Forms.Button usuariosBtn;
        private System.Windows.Forms.Button estudiantesBtn;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Button cambiarContraBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
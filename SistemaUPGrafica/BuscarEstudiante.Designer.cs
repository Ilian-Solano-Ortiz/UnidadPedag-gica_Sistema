namespace SistemaUPGrafica
{
    partial class BuscarEstudiante
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
            pictureBox1 = new PictureBox();
            cedulaEstudianteTxt = new TextBox();
            buscarBtn = new Button();
            contenedor = new Panel();
            btnNuevoEstudiante = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 23);
            label1.TabIndex = 0;
            label1.Text = "Buscar Estudiante";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2026_01_26_124651;
            pictureBox1.Location = new Point(259, 105);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // cedulaEstudianteTxt
            // 
            cedulaEstudianteTxt.Location = new Point(259, 279);
            cedulaEstudianteTxt.Margin = new Padding(4);
            cedulaEstudianteTxt.Name = "cedulaEstudianteTxt";
            cedulaEstudianteTxt.Size = new Size(210, 23);
            cedulaEstudianteTxt.TabIndex = 3;
            // 
            // buscarBtn
            // 
            buscarBtn.BackColor = SystemColors.MenuHighlight;
            buscarBtn.FlatStyle = FlatStyle.Flat;
            buscarBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buscarBtn.ForeColor = SystemColors.ButtonHighlight;
            buscarBtn.Location = new Point(503, 279);
            buscarBtn.Margin = new Padding(4);
            buscarBtn.Name = "buscarBtn";
            buscarBtn.Size = new Size(88, 26);
            buscarBtn.TabIndex = 4;
            buscarBtn.Text = "Buscar";
            buscarBtn.UseVisualStyleBackColor = false;
            buscarBtn.Click += buscarBtn_Click;
            // 
            // contenedor
            // 
            contenedor.Controls.Add(btnNuevoEstudiante);
            contenedor.Controls.Add(buscarBtn);
            contenedor.Controls.Add(label1);
            contenedor.Controls.Add(pictureBox1);
            contenedor.Controls.Add(cedulaEstudianteTxt);
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 0);
            contenedor.Margin = new Padding(4);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(778, 474);
            contenedor.TabIndex = 7;
            // 
            // btnNuevoEstudiante
            // 
            btnNuevoEstudiante.BackColor = SystemColors.MenuHighlight;
            btnNuevoEstudiante.FlatStyle = FlatStyle.Flat;
            btnNuevoEstudiante.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoEstudiante.ForeColor = SystemColors.ControlLightLight;
            btnNuevoEstudiante.Location = new Point(264, 325);
            btnNuevoEstudiante.Margin = new Padding(3, 2, 3, 2);
            btnNuevoEstudiante.Name = "btnNuevoEstudiante";
            btnNuevoEstudiante.Size = new Size(205, 37);
            btnNuevoEstudiante.TabIndex = 5;
            btnNuevoEstudiante.Text = "Ingresar nuevo estudiante";
            btnNuevoEstudiante.UseVisualStyleBackColor = false;
            btnNuevoEstudiante.Click += btnNuevoEstudiante_Click;
            // 
            // BuscarEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(778, 474);
            Controls.Add(contenedor);
            Margin = new Padding(4);
            Name = "BuscarEstudiante";
            Text = "BuscarEstudiante";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contenedor.ResumeLayout(false);
            contenedor.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cedulaEstudianteTxt;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Panel contenedor;
        private Button btnNuevoEstudiante;
    }
}
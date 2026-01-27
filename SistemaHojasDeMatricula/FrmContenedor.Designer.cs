namespace SistemaHojasDeMatricula
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
            this.navegacionPanel = new System.Windows.Forms.Panel();
            this.cerrarSesionBtn = new System.Windows.Forms.Button();
            this.usuariosBtn = new System.Windows.Forms.Button();
            this.estudiantesBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contenedor = new System.Windows.Forms.Panel();
            this.cambiarContraBtn = new System.Windows.Forms.Button();
            this.navegacionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegacionPanel
            // 
            this.navegacionPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.navegacionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.navegacionPanel.Controls.Add(this.cambiarContraBtn);
            this.navegacionPanel.Controls.Add(this.cerrarSesionBtn);
            this.navegacionPanel.Controls.Add(this.usuariosBtn);
            this.navegacionPanel.Controls.Add(this.estudiantesBtn);
            this.navegacionPanel.Controls.Add(this.panel1);
            this.navegacionPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navegacionPanel.Location = new System.Drawing.Point(0, 0);
            this.navegacionPanel.Name = "navegacionPanel";
            this.navegacionPanel.Size = new System.Drawing.Size(117, 450);
            this.navegacionPanel.TabIndex = 0;
            // 
            // cerrarSesionBtn
            // 
            this.cerrarSesionBtn.BackColor = System.Drawing.Color.Red;
            this.cerrarSesionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarSesionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesionBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cerrarSesionBtn.Location = new System.Drawing.Point(3, 420);
            this.cerrarSesionBtn.Name = "cerrarSesionBtn";
            this.cerrarSesionBtn.Size = new System.Drawing.Size(106, 23);
            this.cerrarSesionBtn.TabIndex = 3;
            this.cerrarSesionBtn.Text = "Cerrar Sesión";
            this.cerrarSesionBtn.UseVisualStyleBackColor = false;
            this.cerrarSesionBtn.Click += new System.EventHandler(this.cerrarSesionBtn_Click);
            // 
            // usuariosBtn
            // 
            this.usuariosBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usuariosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usuariosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usuariosBtn.Location = new System.Drawing.Point(3, 76);
            this.usuariosBtn.Name = "usuariosBtn";
            this.usuariosBtn.Size = new System.Drawing.Size(106, 23);
            this.usuariosBtn.TabIndex = 2;
            this.usuariosBtn.Text = "Usuarios";
            this.usuariosBtn.UseVisualStyleBackColor = false;
            this.usuariosBtn.Click += new System.EventHandler(this.usuariosBtn_Click);
            // 
            // estudiantesBtn
            // 
            this.estudiantesBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.estudiantesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estudiantesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estudiantesBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.estudiantesBtn.Location = new System.Drawing.Point(3, 31);
            this.estudiantesBtn.Name = "estudiantesBtn";
            this.estudiantesBtn.Size = new System.Drawing.Size(106, 23);
            this.estudiantesBtn.TabIndex = 0;
            this.estudiantesBtn.Text = "Estudiantes";
            this.estudiantesBtn.UseVisualStyleBackColor = false;
            this.estudiantesBtn.Click += new System.EventHandler(this.estudiantesBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(123, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 450);
            this.panel1.TabIndex = 1;
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(117, 0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(683, 450);
            this.contenedor.TabIndex = 1;
            // 
            // cambiarContraBtn
            // 
            this.cambiarContraBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cambiarContraBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cambiarContraBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambiarContraBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cambiarContraBtn.Location = new System.Drawing.Point(3, 391);
            this.cambiarContraBtn.Name = "cambiarContraBtn";
            this.cambiarContraBtn.Size = new System.Drawing.Size(106, 23);
            this.cambiarContraBtn.TabIndex = 4;
            this.cambiarContraBtn.Text = "Cambiar contraseña";
            this.cambiarContraBtn.UseVisualStyleBackColor = false;
            this.cambiarContraBtn.Click += new System.EventHandler(this.cambiarContraBtn_Click);
            // 
            // FrmContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.navegacionPanel);
            this.Name = "FrmContenedor";
            this.Text = "Form1";
            this.navegacionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navegacionPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cerrarSesionBtn;
        private System.Windows.Forms.Button usuariosBtn;
        private System.Windows.Forms.Button estudiantesBtn;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Button cambiarContraBtn;
    }
}
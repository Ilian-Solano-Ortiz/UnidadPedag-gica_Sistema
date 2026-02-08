namespace SistemaHojasDeMatricula
{
    partial class FrmMatriculaNoExistente
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkPrimaria = new System.Windows.Forms.CheckBox();
            this.checkPreescolar = new System.Windows.Forms.CheckBox();
            this.checkSecundaria = new System.Windows.Forms.CheckBox();
            this.nivelCbx = new System.Windows.Forms.ComboBox();
            this.nivel = new System.Windows.Forms.Label();
            this.fechaMatri = new System.Windows.Forms.Label();
            this.nombreCompleto = new System.Windows.Forms.Label();
            this.txtNombreEst = new System.Windows.Forms.TextBox();
            this.fechaNac = new System.Windows.Forms.Label();
            this.cedula = new System.Windows.Forms.Label();
            this.dateFechNac = new System.Windows.Forms.DateTimePicker();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.direccionText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.siCheck = new System.Windows.Forms.CheckBox();
            this.noCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.siCheck2 = new System.Windows.Forms.CheckBox();
            this.noCheck2 = new System.Windows.Forms.CheckBox();
            this.enfermedadText = new System.Windows.Forms.TextBox();
            this.tratamientoMedText = new System.Windows.Forms.TextBox();
            this.dateMatricula = new System.Windows.Forms.DateTimePicker();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula no existente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkPrimaria
            // 
            this.checkPrimaria.AutoSize = true;
            this.checkPrimaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPrimaria.Location = new System.Drawing.Point(375, 65);
            this.checkPrimaria.Name = "checkPrimaria";
            this.checkPrimaria.Size = new System.Drawing.Size(94, 24);
            this.checkPrimaria.TabIndex = 1;
            this.checkPrimaria.Text = "Primaria";
            this.checkPrimaria.UseVisualStyleBackColor = true;
            this.checkPrimaria.CheckedChanged += new System.EventHandler(this.primariaCheckNo_CheckedChanged);
            // 
            // checkPreescolar
            // 
            this.checkPreescolar.AutoSize = true;
            this.checkPreescolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPreescolar.Location = new System.Drawing.Point(167, 65);
            this.checkPreescolar.Name = "checkPreescolar";
            this.checkPreescolar.Size = new System.Drawing.Size(112, 24);
            this.checkPreescolar.TabIndex = 2;
            this.checkPreescolar.Text = "Preescolar";
            this.checkPreescolar.UseVisualStyleBackColor = true;
            this.checkPreescolar.CheckedChanged += new System.EventHandler(this.checkPreescolar_CheckedChanged);
            // 
            // checkSecundaria
            // 
            this.checkSecundaria.AutoSize = true;
            this.checkSecundaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSecundaria.Location = new System.Drawing.Point(573, 65);
            this.checkSecundaria.Name = "checkSecundaria";
            this.checkSecundaria.Size = new System.Drawing.Size(115, 24);
            this.checkSecundaria.TabIndex = 3;
            this.checkSecundaria.Text = "Secundaria";
            this.checkSecundaria.UseVisualStyleBackColor = true;
            this.checkSecundaria.CheckedChanged += new System.EventHandler(this.checkSecundaria_CheckedChanged);
            // 
            // nivelCbx
            // 
            this.nivelCbx.FormattingEnabled = true;
            this.nivelCbx.Location = new System.Drawing.Point(167, 102);
            this.nivelCbx.Name = "nivelCbx";
            this.nivelCbx.Size = new System.Drawing.Size(121, 24);
            this.nivelCbx.TabIndex = 4;
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivel.Location = new System.Drawing.Point(75, 102);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(46, 20);
            this.nivel.TabIndex = 5;
            this.nivel.Text = "Nivel";
            // 
            // fechaMatri
            // 
            this.fechaMatri.AutoSize = true;
            this.fechaMatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaMatri.Location = new System.Drawing.Point(371, 106);
            this.fechaMatri.Name = "fechaMatri";
            this.fechaMatri.Size = new System.Drawing.Size(152, 20);
            this.fechaMatri.TabIndex = 6;
            this.fechaMatri.Text = "Fecha de matricula";
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.AutoSize = true;
            this.nombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCompleto.Location = new System.Drawing.Point(75, 150);
            this.nombreCompleto.Name = "nombreCompleto";
            this.nombreCompleto.Size = new System.Drawing.Size(250, 20);
            this.nombreCompleto.TabIndex = 8;
            this.nombreCompleto.Text = "Nombre completo del estudiante";
            // 
            // txtNombreEst
            // 
            this.txtNombreEst.Location = new System.Drawing.Point(351, 150);
            this.txtNombreEst.Name = "txtNombreEst";
            this.txtNombreEst.Size = new System.Drawing.Size(415, 22);
            this.txtNombreEst.TabIndex = 9;
            // 
            // fechaNac
            // 
            this.fechaNac.AutoSize = true;
            this.fechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaNac.Location = new System.Drawing.Point(75, 191);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(141, 20);
            this.fechaNac.TabIndex = 10;
            this.fechaNac.Text = "Fecha nacimiento";
            this.fechaNac.Click += new System.EventHandler(this.fechaNac_Click);
            // 
            // cedula
            // 
            this.cedula.AutoSize = true;
            this.cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedula.Location = new System.Drawing.Point(462, 191);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(61, 20);
            this.cedula.TabIndex = 11;
            this.cedula.Text = "Cedula";
            // 
            // dateFechNac
            // 
            this.dateFechNac.Location = new System.Drawing.Point(245, 191);
            this.dateFechNac.Name = "dateFechNac";
            this.dateFechNac.Size = new System.Drawing.Size(200, 22);
            this.dateFechNac.TabIndex = 12;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(542, 193);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(224, 22);
            this.txtCedula.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dirección exacta del estudiante";
            // 
            // direccionText
            // 
            this.direccionText.Location = new System.Drawing.Point(335, 232);
            this.direccionText.Name = "direccionText";
            this.direccionText.Size = new System.Drawing.Size(431, 22);
            this.direccionText.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Si cursa el nivel 11, indique si ya realizó TC:";
            // 
            // siCheck
            // 
            this.siCheck.AutoSize = true;
            this.siCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siCheck.Location = new System.Drawing.Point(451, 273);
            this.siCheck.Name = "siCheck";
            this.siCheck.Size = new System.Drawing.Size(46, 24);
            this.siCheck.TabIndex = 17;
            this.siCheck.Text = "Sí";
            this.siCheck.UseVisualStyleBackColor = true;
            // 
            // noCheck
            // 
            this.noCheck.AutoSize = true;
            this.noCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noCheck.Location = new System.Drawing.Point(542, 273);
            this.noCheck.Name = "noCheck";
            this.noCheck.Size = new System.Drawing.Size(52, 24);
            this.noCheck.TabIndex = 18;
            this.noCheck.Text = "No";
            this.noCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cuenta con adecuación curricular aprobada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "¿Presenta alguna enfermedad? Especifique";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "¿Tiene prescrito tratamiento médico?";
            // 
            // siCheck2
            // 
            this.siCheck2.AutoSize = true;
            this.siCheck2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siCheck2.Location = new System.Drawing.Point(451, 321);
            this.siCheck2.Name = "siCheck2";
            this.siCheck2.Size = new System.Drawing.Size(46, 24);
            this.siCheck2.TabIndex = 22;
            this.siCheck2.Text = "Sí";
            this.siCheck2.UseVisualStyleBackColor = true;
            // 
            // noCheck2
            // 
            this.noCheck2.AutoSize = true;
            this.noCheck2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noCheck2.Location = new System.Drawing.Point(542, 321);
            this.noCheck2.Name = "noCheck2";
            this.noCheck2.Size = new System.Drawing.Size(52, 24);
            this.noCheck2.TabIndex = 23;
            this.noCheck2.Text = "No";
            this.noCheck2.UseVisualStyleBackColor = true;
            // 
            // enfermedadText
            // 
            this.enfermedadText.Location = new System.Drawing.Point(433, 361);
            this.enfermedadText.Name = "enfermedadText";
            this.enfermedadText.Size = new System.Drawing.Size(333, 22);
            this.enfermedadText.TabIndex = 24;
            // 
            // tratamientoMedText
            // 
            this.tratamientoMedText.Location = new System.Drawing.Point(433, 402);
            this.tratamientoMedText.Name = "tratamientoMedText";
            this.tratamientoMedText.Size = new System.Drawing.Size(333, 22);
            this.tratamientoMedText.TabIndex = 25;
            // 
            // dateMatricula
            // 
            this.dateMatricula.Location = new System.Drawing.Point(552, 106);
            this.dateMatricula.Name = "dateMatricula";
            this.dateMatricula.Size = new System.Drawing.Size(200, 22);
            this.dateMatricula.TabIndex = 26;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(741, 459);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 36);
            this.btnNext.TabIndex = 27;
            this.btnNext.Text = "Siguiente";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtras.Location = new System.Drawing.Point(26, 459);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 36);
            this.btnAtras.TabIndex = 28;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FrmMatriculaNoExistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(894, 507);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dateMatricula);
            this.Controls.Add(this.tratamientoMedText);
            this.Controls.Add(this.enfermedadText);
            this.Controls.Add(this.noCheck2);
            this.Controls.Add(this.siCheck2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noCheck);
            this.Controls.Add(this.siCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.direccionText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.dateFechNac);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.fechaNac);
            this.Controls.Add(this.txtNombreEst);
            this.Controls.Add(this.nombreCompleto);
            this.Controls.Add(this.fechaMatri);
            this.Controls.Add(this.nivel);
            this.Controls.Add(this.nivelCbx);
            this.Controls.Add(this.checkSecundaria);
            this.Controls.Add(this.checkPreescolar);
            this.Controls.Add(this.checkPrimaria);
            this.Controls.Add(this.label1);
            this.Name = "FrmMatriculaNoExistente";
            this.Text = "frmMatriculaNoExistente1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkPrimaria;
        private System.Windows.Forms.CheckBox checkPreescolar;
        private System.Windows.Forms.CheckBox checkSecundaria;
        private System.Windows.Forms.ComboBox nivelCbx;
        private System.Windows.Forms.Label nivel;
        private System.Windows.Forms.Label fechaMatri;
        private System.Windows.Forms.Label nombreCompleto;
        private System.Windows.Forms.TextBox txtNombreEst;
        private System.Windows.Forms.Label fechaNac;
        private System.Windows.Forms.Label cedula;
        private System.Windows.Forms.DateTimePicker dateFechNac;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox direccionText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox siCheck;
        private System.Windows.Forms.CheckBox noCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox siCheck2;
        private System.Windows.Forms.CheckBox noCheck2;
        private System.Windows.Forms.TextBox enfermedadText;
        private System.Windows.Forms.TextBox tratamientoMedText;
        private System.Windows.Forms.DateTimePicker dateMatricula;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAtras;
    }
}
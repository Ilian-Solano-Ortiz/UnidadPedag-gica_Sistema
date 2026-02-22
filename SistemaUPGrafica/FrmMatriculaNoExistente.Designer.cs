namespace SistemaUPGrafica
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
            label1 = new Label();
            checkPrimaria = new CheckBox();
            checkPreescolar = new CheckBox();
            checkSecundaria = new CheckBox();
            nivelCbx = new ComboBox();
            nivel = new Label();
            fechaMatri = new Label();
            nombreCompleto = new Label();
            txtNombreEst = new TextBox();
            fechaNac = new Label();
            cedula = new Label();
            dateFechNac = new DateTimePicker();
            txtCedula = new TextBox();
            label2 = new Label();
            direccionText = new TextBox();
            label3 = new Label();
            siCheck = new CheckBox();
            noCheck = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            siCheck2 = new CheckBox();
            noCheck2 = new CheckBox();
            enfermedadText = new TextBox();
            tratamientoMedText = new TextBox();
            dateMatricula = new DateTimePicker();
            btnNext = new Button();
            label7 = new Label();
            inglesCheck = new CheckBox();
            francesCheck = new CheckBox();
            label9 = new Label();
            txtAlergia = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 11);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 0;
            label1.Text = "Matricula no existente";
            label1.Click += label1_Click;
            // 
            // checkPrimaria
            // 
            checkPrimaria.AutoSize = true;
            checkPrimaria.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkPrimaria.Location = new Point(371, 43);
            checkPrimaria.Margin = new Padding(3, 4, 3, 4);
            checkPrimaria.Name = "checkPrimaria";
            checkPrimaria.Size = new Size(94, 24);
            checkPrimaria.TabIndex = 1;
            checkPrimaria.Text = "Primaria";
            checkPrimaria.UseVisualStyleBackColor = true;
            checkPrimaria.CheckedChanged += primariaCheckNo_CheckedChanged;
            // 
            // checkPreescolar
            // 
            checkPreescolar.AutoSize = true;
            checkPreescolar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkPreescolar.Location = new Point(167, 43);
            checkPreescolar.Margin = new Padding(3, 4, 3, 4);
            checkPreescolar.Name = "checkPreescolar";
            checkPreescolar.Size = new Size(112, 24);
            checkPreescolar.TabIndex = 2;
            checkPreescolar.Text = "Preescolar";
            checkPreescolar.UseVisualStyleBackColor = true;
            checkPreescolar.CheckedChanged += checkPreescolar_CheckedChanged;
            // 
            // checkSecundaria
            // 
            checkSecundaria.AutoSize = true;
            checkSecundaria.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkSecundaria.Location = new Point(575, 43);
            checkSecundaria.Margin = new Padding(3, 4, 3, 4);
            checkSecundaria.Name = "checkSecundaria";
            checkSecundaria.Size = new Size(115, 24);
            checkSecundaria.TabIndex = 3;
            checkSecundaria.Text = "Secundaria";
            checkSecundaria.UseVisualStyleBackColor = true;
            checkSecundaria.CheckedChanged += checkSecundaria_CheckedChanged;
            // 
            // nivelCbx
            // 
            nivelCbx.FormattingEnabled = true;
            nivelCbx.Location = new Point(158, 80);
            nivelCbx.Margin = new Padding(3, 4, 3, 4);
            nivelCbx.Name = "nivelCbx";
            nivelCbx.Size = new Size(121, 28);
            nivelCbx.TabIndex = 4;
            // 
            // nivel
            // 
            nivel.AutoSize = true;
            nivel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nivel.Location = new Point(75, 80);
            nivel.Name = "nivel";
            nivel.Size = new Size(46, 20);
            nivel.TabIndex = 5;
            nivel.Text = "Nivel";
            // 
            // fechaMatri
            // 
            fechaMatri.AutoSize = true;
            fechaMatri.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fechaMatri.Location = new Point(374, 88);
            fechaMatri.Name = "fechaMatri";
            fechaMatri.Size = new Size(152, 20);
            fechaMatri.TabIndex = 6;
            fechaMatri.Text = "Fecha de matricula";
            // 
            // nombreCompleto
            // 
            nombreCompleto.AutoSize = true;
            nombreCompleto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreCompleto.Location = new Point(75, 134);
            nombreCompleto.Name = "nombreCompleto";
            nombreCompleto.Size = new Size(250, 20);
            nombreCompleto.TabIndex = 8;
            nombreCompleto.Text = "Nombre completo del estudiante";
            // 
            // txtNombreEst
            // 
            txtNombreEst.Location = new Point(331, 131);
            txtNombreEst.Margin = new Padding(3, 4, 3, 4);
            txtNombreEst.Name = "txtNombreEst";
            txtNombreEst.Size = new Size(468, 27);
            txtNombreEst.TabIndex = 9;
            // 
            // fechaNac
            // 
            fechaNac.AutoSize = true;
            fechaNac.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fechaNac.Location = new Point(75, 191);
            fechaNac.Name = "fechaNac";
            fechaNac.Size = new Size(141, 20);
            fechaNac.TabIndex = 10;
            fechaNac.Text = "Fecha nacimiento";
            fechaNac.Click += fechaNac_Click;
            // 
            // cedula
            // 
            cedula.AutoSize = true;
            cedula.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cedula.Location = new Point(509, 191);
            cedula.Name = "cedula";
            cedula.Size = new Size(61, 20);
            cedula.TabIndex = 11;
            cedula.Text = "Cedula";
            // 
            // dateFechNac
            // 
            dateFechNac.Location = new Point(222, 186);
            dateFechNac.Margin = new Padding(3, 4, 3, 4);
            dateFechNac.Name = "dateFechNac";
            dateFechNac.Size = new Size(255, 27);
            dateFechNac.TabIndex = 12;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(576, 184);
            txtCedula.Margin = new Padding(3, 4, 3, 4);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(223, 27);
            txtCedula.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 247);
            label2.Name = "label2";
            label2.Size = new Size(244, 20);
            label2.TabIndex = 14;
            label2.Text = "Dirección exacta del estudiante";
            // 
            // direccionText
            // 
            direccionText.Location = new Point(335, 240);
            direccionText.Margin = new Padding(3, 4, 3, 4);
            direccionText.Name = "direccionText";
            direccionText.Size = new Size(431, 27);
            direccionText.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 345);
            label3.Name = "label3";
            label3.Size = new Size(340, 20);
            label3.TabIndex = 16;
            label3.Text = "Si cursa el nivel 11, indique si ya realizó TC:";
            // 
            // siCheck
            // 
            siCheck.AutoSize = true;
            siCheck.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            siCheck.Location = new Point(451, 345);
            siCheck.Margin = new Padding(3, 4, 3, 4);
            siCheck.Name = "siCheck";
            siCheck.Size = new Size(46, 24);
            siCheck.TabIndex = 17;
            siCheck.Text = "Sí";
            siCheck.UseVisualStyleBackColor = true;
            siCheck.CheckedChanged += siCheck_CheckedChanged;
            // 
            // noCheck
            // 
            noCheck.AutoSize = true;
            noCheck.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noCheck.Location = new Point(559, 345);
            noCheck.Margin = new Padding(3, 4, 3, 4);
            noCheck.Name = "noCheck";
            noCheck.Size = new Size(52, 24);
            noCheck.TabIndex = 18;
            noCheck.Text = "No";
            noCheck.UseVisualStyleBackColor = true;
            noCheck.CheckedChanged += noCheck_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(76, 382);
            label4.Name = "label4";
            label4.Size = new Size(339, 20);
            label4.TabIndex = 19;
            label4.Text = "Cuenta con adecuación curricular aprobada:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(75, 431);
            label5.Name = "label5";
            label5.Size = new Size(334, 20);
            label5.TabIndex = 20;
            label5.Text = "¿Presenta alguna enfermedad? Especifique";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(76, 480);
            label6.Name = "label6";
            label6.Size = new Size(288, 20);
            label6.TabIndex = 21;
            label6.Text = "¿Tiene prescrito tratamiento médico?";
            // 
            // siCheck2
            // 
            siCheck2.AutoSize = true;
            siCheck2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            siCheck2.Location = new Point(451, 382);
            siCheck2.Margin = new Padding(3, 4, 3, 4);
            siCheck2.Name = "siCheck2";
            siCheck2.Size = new Size(46, 24);
            siCheck2.TabIndex = 22;
            siCheck2.Text = "Sí";
            siCheck2.UseVisualStyleBackColor = true;
            siCheck2.CheckedChanged += siCheck2_CheckedChanged;
            // 
            // noCheck2
            // 
            noCheck2.AutoSize = true;
            noCheck2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noCheck2.Location = new Point(559, 392);
            noCheck2.Margin = new Padding(3, 4, 3, 4);
            noCheck2.Name = "noCheck2";
            noCheck2.Size = new Size(52, 24);
            noCheck2.TabIndex = 23;
            noCheck2.Text = "No";
            noCheck2.UseVisualStyleBackColor = true;
            noCheck2.CheckedChanged += noCheck2_CheckedChanged;
            // 
            // enfermedadText
            // 
            enfermedadText.Location = new Point(451, 428);
            enfermedadText.Margin = new Padding(3, 4, 3, 4);
            enfermedadText.Name = "enfermedadText";
            enfermedadText.Size = new Size(333, 27);
            enfermedadText.TabIndex = 24;
            // 
            // tratamientoMedText
            // 
            tratamientoMedText.Location = new Point(451, 480);
            tratamientoMedText.Margin = new Padding(3, 4, 3, 4);
            tratamientoMedText.Name = "tratamientoMedText";
            tratamientoMedText.Size = new Size(333, 27);
            tratamientoMedText.TabIndex = 25;
            // 
            // dateMatricula
            // 
            dateMatricula.Location = new Point(532, 88);
            dateMatricula.Margin = new Padding(3, 4, 3, 4);
            dateMatricula.Name = "dateMatricula";
            dateMatricula.Size = new Size(267, 27);
            dateMatricula.TabIndex = 26;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.ActiveCaptionText;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = SystemColors.ButtonHighlight;
            btnNext.Location = new Point(741, 573);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(123, 45);
            btnNext.TabIndex = 27;
            btnNext.Text = "Siguiente";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(75, 300);
            label7.Name = "label7";
            label7.Size = new Size(281, 20);
            label7.TabIndex = 28;
            label7.Text = "Si cursa el nivel de 10 elija el idioma";
            // 
            // inglesCheck
            // 
            inglesCheck.AutoSize = true;
            inglesCheck.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inglesCheck.Location = new Point(451, 300);
            inglesCheck.Margin = new Padding(3, 4, 3, 4);
            inglesCheck.Name = "inglesCheck";
            inglesCheck.Size = new Size(75, 24);
            inglesCheck.TabIndex = 29;
            inglesCheck.Text = "Inglés";
            inglesCheck.UseVisualStyleBackColor = true;
            inglesCheck.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // francesCheck
            // 
            francesCheck.AutoSize = true;
            francesCheck.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            francesCheck.Location = new Point(559, 300);
            francesCheck.Margin = new Padding(3, 4, 3, 4);
            francesCheck.Name = "francesCheck";
            francesCheck.Size = new Size(92, 24);
            francesCheck.TabIndex = 30;
            francesCheck.Text = "Francés";
            francesCheck.UseVisualStyleBackColor = true;
            francesCheck.CheckedChanged += francesCheck_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(75, 528);
            label9.Name = "label9";
            label9.Size = new Size(376, 20);
            label9.TabIndex = 32;
            label9.Text = "¿El estudiante es alérgico a algún medicamento?";
            // 
            // txtAlergia
            // 
            txtAlergia.Location = new Point(457, 528);
            txtAlergia.Name = "txtAlergia";
            txtAlergia.Size = new Size(327, 27);
            txtAlergia.TabIndex = 33;
            txtAlergia.TextChanged += txtAlergia_TextChanged;
            // 
            // FrmMatriculaNoExistente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(894, 633);
            Controls.Add(txtAlergia);
            Controls.Add(label9);
            Controls.Add(francesCheck);
            Controls.Add(inglesCheck);
            Controls.Add(label7);
            Controls.Add(btnNext);
            Controls.Add(dateMatricula);
            Controls.Add(tratamientoMedText);
            Controls.Add(enfermedadText);
            Controls.Add(noCheck2);
            Controls.Add(siCheck2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(noCheck);
            Controls.Add(siCheck);
            Controls.Add(label3);
            Controls.Add(direccionText);
            Controls.Add(label2);
            Controls.Add(txtCedula);
            Controls.Add(dateFechNac);
            Controls.Add(cedula);
            Controls.Add(fechaNac);
            Controls.Add(txtNombreEst);
            Controls.Add(nombreCompleto);
            Controls.Add(fechaMatri);
            Controls.Add(nivel);
            Controls.Add(nivelCbx);
            Controls.Add(checkSecundaria);
            Controls.Add(checkPreescolar);
            Controls.Add(checkPrimaria);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMatriculaNoExistente";
            Text = "frmMatriculaNoExistente1";
            ResumeLayout(false);
            PerformLayout();

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
        private Label label7;
        private CheckBox inglesCheck;
        private CheckBox francesCheck;
        private Label label9;
        private TextBox txtAlergia;
    }
}
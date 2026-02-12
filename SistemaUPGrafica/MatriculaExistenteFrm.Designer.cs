namespace SistemaUPGrafica
{
    partial class MatriculaExistenteFrm
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
            preescolarCheck = new CheckBox();
            secundariaCheck = new CheckBox();
            primariaCheck = new CheckBox();
            nivelCbx = new ComboBox();
            label2 = new Label();
            labelMatricula = new Label();
            label3 = new Label();
            nombreCompletoTxt = new TextBox();
            label4 = new Label();
            cedulaTxt = new TextBox();
            label5 = new Label();
            telefonoEncargadoTxt = new TextBox();
            label6 = new Label();
            inglesCheck = new CheckBox();
            francesCheck = new CheckBox();
            label7 = new Label();
            siCheckTC = new CheckBox();
            noCheckTC = new CheckBox();
            fechaMatricula = new DateTimePicker();
            generarBtn = new Button();
            label8 = new Label();
            siCheckAdecuacion = new CheckBox();
            noCheckAdecuacion = new CheckBox();
            label9 = new Label();
            siCheckPatronato = new CheckBox();
            noCheckPatronato = new CheckBox();
            label10 = new Label();
            montoPatronatoTxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 16);
            label1.TabIndex = 0;
            label1.Text = "Matrícula Existente";
            // 
            // preescolarCheck
            // 
            preescolarCheck.AutoSize = true;
            preescolarCheck.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            preescolarCheck.Location = new Point(159, 91);
            preescolarCheck.Margin = new Padding(4, 3, 4, 3);
            preescolarCheck.Name = "preescolarCheck";
            preescolarCheck.Size = new Size(92, 20);
            preescolarCheck.TabIndex = 1;
            preescolarCheck.Text = "Preescolar";
            preescolarCheck.UseVisualStyleBackColor = true;
            preescolarCheck.CheckedChanged += preescolarCheck_CheckedChanged;
            // 
            // secundariaCheck
            // 
            secundariaCheck.AutoSize = true;
            secundariaCheck.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secundariaCheck.Location = new Point(471, 91);
            secundariaCheck.Margin = new Padding(4, 3, 4, 3);
            secundariaCheck.Name = "secundariaCheck";
            secundariaCheck.Size = new Size(95, 20);
            secundariaCheck.TabIndex = 2;
            secundariaCheck.Text = "Secundaria";
            secundariaCheck.UseVisualStyleBackColor = true;
            secundariaCheck.CheckedChanged += secundariaCheck_CheckedChanged;
            // 
            // primariaCheck
            // 
            primariaCheck.AutoSize = true;
            primariaCheck.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            primariaCheck.Location = new Point(326, 91);
            primariaCheck.Margin = new Padding(4, 3, 4, 3);
            primariaCheck.Name = "primariaCheck";
            primariaCheck.Size = new Size(76, 20);
            primariaCheck.TabIndex = 3;
            primariaCheck.Text = "Primaria";
            primariaCheck.UseVisualStyleBackColor = true;
            primariaCheck.CheckedChanged += primariaCheck_CheckedChanged;
            // 
            // nivelCbx
            // 
            nivelCbx.FormattingEnabled = true;
            nivelCbx.Location = new Point(92, 170);
            nivelCbx.Margin = new Padding(4, 3, 4, 3);
            nivelCbx.Name = "nivelCbx";
            nivelCbx.Size = new Size(140, 23);
            nivelCbx.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 171);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 16);
            label2.TabIndex = 5;
            label2.Text = "Nivel";
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMatricula.Location = new Point(287, 171);
            labelMatricula.Margin = new Padding(4, 0, 4, 0);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(121, 16);
            labelMatricula.TabIndex = 6;
            labelMatricula.Text = "Fecha de Matrícula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 226);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(202, 16);
            label3.TabIndex = 8;
            label3.Text = "Nombre completo del estudiante";
            // 
            // nombreCompletoTxt
            // 
            nombreCompletoTxt.Location = new Point(290, 222);
            nombreCompletoTxt.Margin = new Padding(4, 3, 4, 3);
            nombreCompletoTxt.Name = "nombreCompletoTxt";
            nombreCompletoTxt.Size = new Size(328, 23);
            nombreCompletoTxt.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 270);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 16);
            label4.TabIndex = 10;
            label4.Text = "Cédula";
            // 
            // cedulaTxt
            // 
            cedulaTxt.Location = new Point(99, 270);
            cedulaTxt.Margin = new Padding(4, 3, 4, 3);
            cedulaTxt.Name = "cedulaTxt";
            cedulaTxt.Size = new Size(182, 23);
            cedulaTxt.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(312, 270);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(152, 16);
            label5.TabIndex = 12;
            label5.Text = "Teléfono del encargado";
            // 
            // telefonoEncargadoTxt
            // 
            telefonoEncargadoTxt.Location = new Point(496, 270);
            telefonoEncargadoTxt.Margin = new Padding(4, 3, 4, 3);
            telefonoEncargadoTxt.Name = "telefonoEncargadoTxt";
            telefonoEncargadoTxt.Size = new Size(182, 23);
            telefonoEncargadoTxt.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 324);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(222, 16);
            label6.TabIndex = 14;
            label6.Text = "Si cursa el nivel de 10 elija el idioma";
            // 
            // inglesCheck
            // 
            inglesCheck.AutoSize = true;
            inglesCheck.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inglesCheck.Location = new Point(326, 324);
            inglesCheck.Margin = new Padding(4, 3, 4, 3);
            inglesCheck.Name = "inglesCheck";
            inglesCheck.Size = new Size(62, 20);
            inglesCheck.TabIndex = 15;
            inglesCheck.Text = "Inglés";
            inglesCheck.UseVisualStyleBackColor = true;
            inglesCheck.CheckedChanged += inglesCheck_CheckedChanged;
            // 
            // francesCheck
            // 
            francesCheck.AutoSize = true;
            francesCheck.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            francesCheck.Location = new Point(447, 324);
            francesCheck.Margin = new Padding(4, 3, 4, 3);
            francesCheck.Name = "francesCheck";
            francesCheck.Size = new Size(75, 20);
            francesCheck.TabIndex = 16;
            francesCheck.Text = "Francés";
            francesCheck.UseVisualStyleBackColor = true;
            francesCheck.CheckedChanged += francesCheck_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(30, 372);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(315, 16);
            label7.TabIndex = 17;
            label7.Text = "Si cursa el nivel de 11 indique si ya realizó horas TC";
            // 
            // siCheckTC
            // 
            siCheckTC.AutoSize = true;
            siCheckTC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            siCheckTC.Location = new Point(416, 367);
            siCheckTC.Margin = new Padding(4, 3, 4, 3);
            siCheckTC.Name = "siCheckTC";
            siCheckTC.Size = new Size(38, 20);
            siCheckTC.TabIndex = 18;
            siCheckTC.Text = "Sí";
            siCheckTC.UseVisualStyleBackColor = true;
            siCheckTC.CheckedChanged += siCheck_CheckedChanged;
            // 
            // noCheckTC
            // 
            noCheckTC.AutoSize = true;
            noCheckTC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noCheckTC.Location = new Point(510, 367);
            noCheckTC.Margin = new Padding(4, 3, 4, 3);
            noCheckTC.Name = "noCheckTC";
            noCheckTC.Size = new Size(44, 20);
            noCheckTC.TabIndex = 19;
            noCheckTC.Text = "No";
            noCheckTC.UseVisualStyleBackColor = true;
            noCheckTC.CheckedChanged += noCheck_CheckedChanged;
            // 
            // fechaMatricula
            // 
            fechaMatricula.Location = new Point(446, 170);
            fechaMatricula.Margin = new Padding(4, 3, 4, 3);
            fechaMatricula.Name = "fechaMatricula";
            fechaMatricula.Size = new Size(233, 23);
            fechaMatricula.TabIndex = 20;
            // 
            // generarBtn
            // 
            generarBtn.BackColor = SystemColors.ActiveCaptionText;
            generarBtn.FlatStyle = FlatStyle.Flat;
            generarBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generarBtn.ForeColor = SystemColors.ButtonHighlight;
            generarBtn.Location = new Point(312, 477);
            generarBtn.Margin = new Padding(4, 3, 4, 3);
            generarBtn.Name = "generarBtn";
            generarBtn.Size = new Size(127, 27);
            generarBtn.TabIndex = 21;
            generarBtn.Text = "Generar";
            generarBtn.UseVisualStyleBackColor = false;
            generarBtn.Click += generarBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(30, 407);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(268, 16);
            label8.TabIndex = 22;
            label8.Text = "Cuenta con adecuación curricular aprobada";
            // 
            // siCheckAdecuacion
            // 
            siCheckAdecuacion.AutoSize = true;
            siCheckAdecuacion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            siCheckAdecuacion.Location = new Point(416, 406);
            siCheckAdecuacion.Margin = new Padding(4, 3, 4, 3);
            siCheckAdecuacion.Name = "siCheckAdecuacion";
            siCheckAdecuacion.Size = new Size(38, 20);
            siCheckAdecuacion.TabIndex = 23;
            siCheckAdecuacion.Text = "Sí";
            siCheckAdecuacion.UseVisualStyleBackColor = true;
            siCheckAdecuacion.CheckedChanged += siCheckAdecuacion_CheckedChanged;
            // 
            // noCheckAdecuacion
            // 
            noCheckAdecuacion.AutoSize = true;
            noCheckAdecuacion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noCheckAdecuacion.Location = new Point(510, 406);
            noCheckAdecuacion.Margin = new Padding(4, 3, 4, 3);
            noCheckAdecuacion.Name = "noCheckAdecuacion";
            noCheckAdecuacion.Size = new Size(44, 20);
            noCheckAdecuacion.TabIndex = 24;
            noCheckAdecuacion.Text = "No";
            noCheckAdecuacion.UseVisualStyleBackColor = true;
            noCheckAdecuacion.CheckedChanged += noCheckAdecuacion_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(30, 442);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 16);
            label9.TabIndex = 25;
            label9.Text = "Pagó patronato";
            // 
            // siCheckPatronato
            // 
            siCheckPatronato.AutoSize = true;
            siCheckPatronato.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            siCheckPatronato.Location = new Point(416, 440);
            siCheckPatronato.Margin = new Padding(4, 3, 4, 3);
            siCheckPatronato.Name = "siCheckPatronato";
            siCheckPatronato.Size = new Size(38, 20);
            siCheckPatronato.TabIndex = 26;
            siCheckPatronato.Text = "Sí";
            siCheckPatronato.UseVisualStyleBackColor = true;
            siCheckPatronato.CheckedChanged += siCheckPatronato_CheckedChanged;
            // 
            // noCheckPatronato
            // 
            noCheckPatronato.AutoSize = true;
            noCheckPatronato.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noCheckPatronato.Location = new Point(510, 441);
            noCheckPatronato.Margin = new Padding(4, 3, 4, 3);
            noCheckPatronato.Name = "noCheckPatronato";
            noCheckPatronato.Size = new Size(44, 20);
            noCheckPatronato.TabIndex = 27;
            noCheckPatronato.Text = "No";
            noCheckPatronato.UseVisualStyleBackColor = true;
            noCheckPatronato.CheckedChanged += noCheckPatronato_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(589, 442);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(44, 16);
            label10.TabIndex = 28;
            label10.Text = "Monto";
            // 
            // montoPatronatoTxt
            // 
            montoPatronatoTxt.Location = new Point(651, 437);
            montoPatronatoTxt.Margin = new Padding(4, 3, 4, 3);
            montoPatronatoTxt.Name = "montoPatronatoTxt";
            montoPatronatoTxt.Size = new Size(90, 23);
            montoPatronatoTxt.TabIndex = 29;
            montoPatronatoTxt.Enabled = false;
            // 
            // MatriculaExistenteFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(778, 505);
            Controls.Add(montoPatronatoTxt);
            Controls.Add(label10);
            Controls.Add(noCheckPatronato);
            Controls.Add(siCheckPatronato);
            Controls.Add(label9);
            Controls.Add(noCheckAdecuacion);
            Controls.Add(siCheckAdecuacion);
            Controls.Add(label8);
            Controls.Add(generarBtn);
            Controls.Add(fechaMatricula);
            Controls.Add(noCheckTC);
            Controls.Add(siCheckTC);
            Controls.Add(label7);
            Controls.Add(francesCheck);
            Controls.Add(inglesCheck);
            Controls.Add(label6);
            Controls.Add(telefonoEncargadoTxt);
            Controls.Add(label5);
            Controls.Add(cedulaTxt);
            Controls.Add(label4);
            Controls.Add(nombreCompletoTxt);
            Controls.Add(label3);
            Controls.Add(labelMatricula);
            Controls.Add(label2);
            Controls.Add(nivelCbx);
            Controls.Add(primariaCheck);
            Controls.Add(secundariaCheck);
            Controls.Add(preescolarCheck);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MatriculaExistenteFrm";
            Text = "MatriculaExistenteFrm";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox preescolarCheck;
        private System.Windows.Forms.CheckBox secundariaCheck;
        private System.Windows.Forms.CheckBox primariaCheck;
        private System.Windows.Forms.ComboBox nivelCbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreCompletoTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cedulaTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox telefonoEncargadoTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox inglesCheck;
        private System.Windows.Forms.CheckBox francesCheck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox siCheckTC;
        private System.Windows.Forms.CheckBox noCheckTC;
        private System.Windows.Forms.DateTimePicker fechaMatricula;
        private System.Windows.Forms.Button generarBtn;
        private Label label8;
        private CheckBox siCheckAdecuacion;
        private CheckBox noCheckAdecuacion;
        private Label label9;
        private CheckBox siCheckPatronato;
        private CheckBox noCheckPatronato;
        private Label label10;
        private TextBox montoPatronatoTxt;
    }
}
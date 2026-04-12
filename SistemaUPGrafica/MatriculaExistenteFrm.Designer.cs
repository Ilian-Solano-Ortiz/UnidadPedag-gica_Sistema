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
            cedulaEstudianteTxt = new TextBox();
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
            label11 = new Label();
            correoEncargadoTxt = new TextBox();
            label12 = new Label();
            label13 = new Label();
            observacionesTxt = new TextBox();
            label14 = new Label();
            cedulaEncargadoTxt = new TextBox();
            nombreEncargadoTxt = new TextBox();
            label15 = new Label();
            encargadosCb = new ComboBox();
            encargadosLabel = new Label();
            annoLectivoTxt = new TextBox();
            nuevoEncargadoCheck = new CheckBox();
            nuevoEncargadoPanel = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 16);
            label1.TabIndex = 0;
            label1.Text = "Reafirmación hoja de matrícula";
            // 
            // preescolarCheck
            // 
            preescolarCheck.AutoSize = true;
            preescolarCheck.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            preescolarCheck.Location = new Point(166, 41);
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
            secundariaCheck.Location = new Point(478, 41);
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
            primariaCheck.Location = new Point(333, 41);
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
            nivelCbx.Location = new Point(80, 98);
            nivelCbx.Margin = new Padding(4, 3, 4, 3);
            nivelCbx.Name = "nivelCbx";
            nivelCbx.Size = new Size(140, 23);
            nivelCbx.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 100);
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
            labelMatricula.Location = new Point(402, 100);
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
            label3.Location = new Point(213, 154);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(202, 16);
            label3.TabIndex = 8;
            label3.Text = "Nombre completo del estudiante";
            // 
            // nombreCompletoTxt
            // 
            nombreCompletoTxt.Location = new Point(423, 152);
            nombreCompletoTxt.Margin = new Padding(4, 3, 4, 3);
            nombreCompletoTxt.Name = "nombreCompletoTxt";
            nombreCompletoTxt.Size = new Size(325, 23);
            nombreCompletoTxt.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 154);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 16);
            label4.TabIndex = 10;
            label4.Text = "Cédula";
            // 
            // cedulaEstudianteTxt
            // 
            cedulaEstudianteTxt.Location = new Point(95, 152);
            cedulaEstudianteTxt.Margin = new Padding(4, 3, 4, 3);
            cedulaEstudianteTxt.Name = "cedulaEstudianteTxt";
            cedulaEstudianteTxt.Size = new Size(112, 23);
            cedulaEstudianteTxt.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(371, 267);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(152, 16);
            label5.TabIndex = 12;
            label5.Text = "Teléfono del encargado";
            // 
            // telefonoEncargadoTxt
            // 
            telefonoEncargadoTxt.Location = new Point(531, 265);
            telefonoEncargadoTxt.Margin = new Padding(4, 3, 4, 3);
            telefonoEncargadoTxt.Name = "telefonoEncargadoTxt";
            telefonoEncargadoTxt.Size = new Size(182, 23);
            telefonoEncargadoTxt.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(36, 304);
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
            inglesCheck.Location = new Point(281, 303);
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
            francesCheck.Location = new Point(351, 303);
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
            label7.Location = new Point(37, 335);
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
            siCheckTC.Location = new Point(423, 330);
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
            noCheckTC.Location = new Point(517, 330);
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
            fechaMatricula.Location = new Point(531, 95);
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
            label8.Location = new Point(37, 370);
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
            siCheckAdecuacion.Location = new Point(423, 369);
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
            noCheckAdecuacion.Location = new Point(517, 369);
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
            label9.Location = new Point(37, 405);
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
            siCheckPatronato.Location = new Point(423, 403);
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
            noCheckPatronato.Location = new Point(517, 404);
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
            label10.Location = new Point(596, 405);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(44, 16);
            label10.TabIndex = 28;
            label10.Text = "Monto";
            // 
            // montoPatronatoTxt
            // 
            montoPatronatoTxt.Enabled = false;
            montoPatronatoTxt.Location = new Point(658, 400);
            montoPatronatoTxt.Margin = new Padding(4, 3, 4, 3);
            montoPatronatoTxt.Name = "montoPatronatoTxt";
            montoPatronatoTxt.Size = new Size(90, 23);
            montoPatronatoTxt.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(37, 267);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(139, 16);
            label11.TabIndex = 30;
            label11.Text = "Correo del encargado";
            // 
            // correoEncargadoTxt
            // 
            correoEncargadoTxt.Location = new Point(184, 265);
            correoEncargadoTxt.Margin = new Padding(4, 3, 4, 3);
            correoEncargadoTxt.Name = "correoEncargadoTxt";
            correoEncargadoTxt.Size = new Size(182, 23);
            correoEncargadoTxt.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(228, 103);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(77, 16);
            label12.TabIndex = 33;
            label12.Text = "Año Lectivo";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(37, 431);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(99, 16);
            label13.TabIndex = 34;
            label13.Text = "Observaciones";
            // 
            // observacionesTxt
            // 
            observacionesTxt.Location = new Point(158, 429);
            observacionesTxt.Name = "observacionesTxt";
            observacionesTxt.Size = new Size(590, 23);
            observacionesTxt.TabIndex = 35;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(37, 235);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(141, 16);
            label14.TabIndex = 36;
            label14.Text = "Cédula del encargado";
            // 
            // cedulaEncargadoTxt
            // 
            cedulaEncargadoTxt.Location = new Point(184, 233);
            cedulaEncargadoTxt.Margin = new Padding(4, 3, 4, 3);
            cedulaEncargadoTxt.Name = "cedulaEncargadoTxt";
            cedulaEncargadoTxt.Size = new Size(182, 23);
            cedulaEncargadoTxt.TabIndex = 37;
            // 
            // nombreEncargadoTxt
            // 
            nombreEncargadoTxt.Location = new Point(531, 235);
            nombreEncargadoTxt.Margin = new Padding(4, 3, 4, 3);
            nombreEncargadoTxt.Name = "nombreEncargadoTxt";
            nombreEncargadoTxt.Size = new Size(217, 23);
            nombreEncargadoTxt.TabIndex = 39;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(370, 237);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(147, 16);
            label15.TabIndex = 38;
            label15.Text = "Nombre del encargado";
            // 
            // encargadosCb
            // 
            encargadosCb.FormattingEnabled = true;
            encargadosCb.Location = new Point(212, 196);
            encargadosCb.Name = "encargadosCb";
            encargadosCb.Size = new Size(311, 23);
            encargadosCb.TabIndex = 40;
            encargadosCb.SelectedIndexChanged += encargadosCb_SelectedIndexChanged;
            // 
            // encargadosLabel
            // 
            encargadosLabel.AutoSize = true;
            encargadosLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            encargadosLabel.Location = new Point(35, 198);
            encargadosLabel.Margin = new Padding(4, 0, 4, 0);
            encargadosLabel.Name = "encargadosLabel";
            encargadosLabel.Size = new Size(172, 16);
            encargadosLabel.TabIndex = 41;
            encargadosLabel.Text = "Seleccione a un encargado";
            // 
            // annoLectivoTxt
            // 
            annoLectivoTxt.Location = new Point(312, 98);
            annoLectivoTxt.Name = "annoLectivoTxt";
            annoLectivoTxt.Size = new Size(83, 23);
            annoLectivoTxt.TabIndex = 42;
            // 
            // nuevoEncargadoCheck
            // 
            nuevoEncargadoCheck.AutoSize = true;
            nuevoEncargadoCheck.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nuevoEncargadoCheck.Location = new Point(560, 196); // junto al ComboBox
            nuevoEncargadoCheck.Name = "nuevoEncargadoCheck";
            nuevoEncargadoCheck.Size = new Size(160, 20);
            nuevoEncargadoCheck.Text = "Encargado diferente";
            nuevoEncargadoCheck.UseVisualStyleBackColor = true;
            nuevoEncargadoCheck.CheckedChanged += nuevoEncargadoCheck_CheckedChanged;
            // 
            // MatriculaExistenteFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(778, 505);
            Controls.Add(nuevoEncargadoCheck);
            Controls.Add(annoLectivoTxt);
            Controls.Add(encargadosLabel);
            Controls.Add(encargadosCb);
            Controls.Add(nombreEncargadoTxt);
            Controls.Add(label15);
            Controls.Add(cedulaEncargadoTxt);
            Controls.Add(label14);
            Controls.Add(observacionesTxt);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(correoEncargadoTxt);
            Controls.Add(label11);
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
            Controls.Add(cedulaEstudianteTxt);
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
        private System.Windows.Forms.TextBox cedulaEstudianteTxt;
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
        private Label label11;
        private TextBox correoEncargadoTxt;
        private Label label12;
        private Label label13;
        private TextBox observacionesTxt;
        private Label label14;
        private TextBox cedulaEncargadoTxt;
        private TextBox nombreEncargadoTxt;
        private Label label15;
        private ComboBox encargadosCb;
        private Label encargadosLabel;
        private TextBox annoLectivoTxt;
        private CheckBox nuevoEncargadoCheck;
        private Panel nuevoEncargadoPanel;
    }
}
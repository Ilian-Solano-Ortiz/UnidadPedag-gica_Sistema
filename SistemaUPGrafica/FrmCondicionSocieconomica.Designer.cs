namespace SistemaUPGrafica
{
    partial class FrmCondicionSocieconomica
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
            checkSi = new CheckBox();
            checkNo = new CheckBox();
            label3 = new Label();
            checkImas = new CheckBox();
            checkComedor = new CheckBox();
            checkTransporte = new CheckBox();
            label4 = new Label();
            checkPadre = new CheckBox();
            checkMadre = new CheckBox();
            checkPadreyMadre = new CheckBox();
            label5 = new Label();
            checkOtros = new CheckBox();
            checkPrimariaInc = new CheckBox();
            checkPrimariaCom = new CheckBox();
            checkSecundariaInc = new CheckBox();
            checkSecundariaCom = new CheckBox();
            checkUniversidad = new CheckBox();
            btnAtras = new Button();
            btnImprimir = new Button();
            label6 = new Label();
            checkSiPatronato = new CheckBox();
            checkNoPatronato = new CheckBox();
            label7 = new Label();
            montoTxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(190, 17);
            label1.TabIndex = 0;
            label1.Text = "Condición socieconómica\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 52);
            label2.Name = "label2";
            label2.Size = new Size(95, 17);
            label2.TabIndex = 1;
            label2.Text = "¿Tiene beca?";
            // 
            // checkSi
            // 
            checkSi.AutoSize = true;
            checkSi.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkSi.Location = new Point(122, 56);
            checkSi.Name = "checkSi";
            checkSi.Size = new Size(39, 21);
            checkSi.TabIndex = 2;
            checkSi.Text = "Sí";
            checkSi.UseVisualStyleBackColor = true;
            checkSi.CheckedChanged += checkSi_CheckedChanged;
            // 
            // checkNo
            // 
            checkNo.AutoSize = true;
            checkNo.Location = new Point(193, 56);
            checkNo.Name = "checkNo";
            checkNo.Size = new Size(42, 19);
            checkNo.TabIndex = 3;
            checkNo.Text = "No";
            checkNo.UseVisualStyleBackColor = true;
            checkNo.CheckedChanged += checkNo_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 98);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 4;
            label3.Text = "¿Cuál posee?";
            // 
            // checkImas
            // 
            checkImas.AutoSize = true;
            checkImas.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkImas.Location = new Point(122, 98);
            checkImas.Name = "checkImas";
            checkImas.Size = new Size(59, 21);
            checkImas.TabIndex = 5;
            checkImas.Text = "IMAS";
            checkImas.UseVisualStyleBackColor = true;
            checkImas.CheckedChanged += checkImas_CheckedChanged;
            // 
            // checkComedor
            // 
            checkComedor.AutoSize = true;
            checkComedor.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkComedor.Location = new Point(193, 98);
            checkComedor.Name = "checkComedor";
            checkComedor.Size = new Size(152, 21);
            checkComedor.TabIndex = 6;
            checkComedor.Text = "Comedor estudiantil";
            checkComedor.UseVisualStyleBackColor = true;
            checkComedor.CheckedChanged += checkComedor_CheckedChanged;
            // 
            // checkTransporte
            // 
            checkTransporte.AutoSize = true;
            checkTransporte.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkTransporte.Location = new Point(351, 98);
            checkTransporte.Name = "checkTransporte";
            checkTransporte.Size = new Size(165, 21);
            checkTransporte.TabIndex = 7;
            checkTransporte.Text = "Transporte estudiantil";
            checkTransporte.UseVisualStyleBackColor = true;
            checkTransporte.CheckedChanged += checkTransporte_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 140);
            label4.Name = "label4";
            label4.Size = new Size(117, 17);
            label4.TabIndex = 8;
            label4.Text = "¿Núcleo familiar?";
            label4.Click += label4_Click;
            // 
            // checkPadre
            // 
            checkPadre.AutoSize = true;
            checkPadre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkPadre.Location = new Point(136, 140);
            checkPadre.Name = "checkPadre";
            checkPadre.Size = new Size(65, 21);
            checkPadre.TabIndex = 9;
            checkPadre.Text = "Padre";
            checkPadre.UseVisualStyleBackColor = true;
            checkPadre.CheckedChanged += checkPadre_CheckedChanged;
            // 
            // checkMadre
            // 
            checkMadre.AutoSize = true;
            checkMadre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkMadre.Location = new Point(232, 139);
            checkMadre.Name = "checkMadre";
            checkMadre.Size = new Size(67, 21);
            checkMadre.TabIndex = 10;
            checkMadre.Text = "Madre";
            checkMadre.UseVisualStyleBackColor = true;
            checkMadre.CheckedChanged += checkMadre_CheckedChanged;
            // 
            // checkPadreyMadre
            // 
            checkPadreyMadre.AutoSize = true;
            checkPadreyMadre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkPadreyMadre.Location = new Point(341, 143);
            checkPadreyMadre.Name = "checkPadreyMadre";
            checkPadreyMadre.Size = new Size(120, 21);
            checkPadreyMadre.TabIndex = 11;
            checkPadreyMadre.Text = "Padre y Madre";
            checkPadreyMadre.UseVisualStyleBackColor = true;
            checkPadreyMadre.CheckedChanged += checkPadreyMadre_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 187);
            label5.Name = "label5";
            label5.Size = new Size(468, 17);
            label5.TabIndex = 12;
            label5.Text = "Nivel académico del padre, madre de familia o encargado del estudiante:";
            // 
            // checkOtros
            // 
            checkOtros.AutoSize = true;
            checkOtros.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkOtros.Location = new Point(497, 143);
            checkOtros.Name = "checkOtros";
            checkOtros.Size = new Size(62, 21);
            checkOtros.TabIndex = 13;
            checkOtros.Text = "Otros";
            checkOtros.UseVisualStyleBackColor = true;
            checkOtros.CheckedChanged += checkOtros_CheckedChanged;
            // 
            // checkPrimariaInc
            // 
            checkPrimariaInc.AutoSize = true;
            checkPrimariaInc.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkPrimariaInc.Location = new Point(14, 230);
            checkPrimariaInc.Name = "checkPrimariaInc";
            checkPrimariaInc.Size = new Size(151, 21);
            checkPrimariaInc.TabIndex = 14;
            checkPrimariaInc.Text = "Primaria Incompleta";
            checkPrimariaInc.UseVisualStyleBackColor = true;
            checkPrimariaInc.CheckedChanged += checkPrimariaInc_CheckedChanged;
            // 
            // checkPrimariaCom
            // 
            checkPrimariaCom.AutoSize = true;
            checkPrimariaCom.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkPrimariaCom.Location = new Point(232, 230);
            checkPrimariaCom.Name = "checkPrimariaCom";
            checkPrimariaCom.Size = new Size(140, 21);
            checkPrimariaCom.TabIndex = 15;
            checkPrimariaCom.Text = "Primaria completa";
            checkPrimariaCom.UseVisualStyleBackColor = true;
            checkPrimariaCom.CheckedChanged += checkPrimariaCom_CheckedChanged;
            // 
            // checkSecundariaInc
            // 
            checkSecundariaInc.AutoSize = true;
            checkSecundariaInc.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkSecundariaInc.Location = new Point(14, 282);
            checkSecundariaInc.Name = "checkSecundariaInc";
            checkSecundariaInc.Size = new Size(171, 21);
            checkSecundariaInc.TabIndex = 16;
            checkSecundariaInc.Text = "Secundaria incompleta";
            checkSecundariaInc.UseVisualStyleBackColor = true;
            checkSecundariaInc.CheckedChanged += checkSecundariaInc_CheckedChanged;
            // 
            // checkSecundariaCom
            // 
            checkSecundariaCom.AutoSize = true;
            checkSecundariaCom.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkSecundariaCom.Location = new Point(232, 282);
            checkSecundariaCom.Name = "checkSecundariaCom";
            checkSecundariaCom.Size = new Size(160, 21);
            checkSecundariaCom.TabIndex = 17;
            checkSecundariaCom.Text = "Secundaria completa";
            checkSecundariaCom.UseVisualStyleBackColor = true;
            checkSecundariaCom.CheckedChanged += checkSecundariaCom_CheckedChanged;
            // 
            // checkUniversidad
            // 
            checkUniversidad.AutoSize = true;
            checkUniversidad.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkUniversidad.Location = new Point(14, 335);
            checkUniversidad.Name = "checkUniversidad";
            checkUniversidad.Size = new Size(102, 21);
            checkUniversidad.TabIndex = 18;
            checkUniversidad.Text = "Universidad";
            checkUniversidad.TextAlign = ContentAlignment.TopCenter;
            checkUniversidad.UseVisualStyleBackColor = true;
            checkUniversidad.CheckedChanged += checkUniversidad_CheckedChanged;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ActiveCaptionText;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtras.ForeColor = SystemColors.ButtonHighlight;
            btnAtras.Location = new Point(14, 426);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(76, 30);
            btnAtras.TabIndex = 19;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = SystemColors.ActiveCaptionText;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = SystemColors.ButtonHighlight;
            btnImprimir.Location = new Point(666, 434);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(87, 30);
            btnImprimir.TabIndex = 20;
            btnImprimir.Text = "Generar";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 378);
            label6.Name = "label6";
            label6.Size = new Size(106, 17);
            label6.TabIndex = 21;
            label6.Text = "Pagó patronato";
            // 
            // checkSiPatronato
            // 
            checkSiPatronato.AutoSize = true;
            checkSiPatronato.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkSiPatronato.Location = new Point(136, 378);
            checkSiPatronato.Name = "checkSiPatronato";
            checkSiPatronato.Size = new Size(39, 21);
            checkSiPatronato.TabIndex = 22;
            checkSiPatronato.Text = "Sí";
            checkSiPatronato.UseVisualStyleBackColor = true;
            checkSiPatronato.CheckedChanged += checkSiPatronato_CheckedChanged;
            // 
            // checkNoPatronato
            // 
            checkNoPatronato.AutoSize = true;
            checkNoPatronato.Location = new Point(193, 379);
            checkNoPatronato.Name = "checkNoPatronato";
            checkNoPatronato.Size = new Size(42, 19);
            checkNoPatronato.TabIndex = 23;
            checkNoPatronato.Text = "No";
            checkNoPatronato.UseVisualStyleBackColor = true;
            checkNoPatronato.CheckedChanged += checkNoPatronato_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(266, 378);
            label7.Name = "label7";
            label7.Size = new Size(47, 17);
            label7.TabIndex = 24;
            label7.Text = "Monto";
            // 
            // montoTxt
            // 
            montoTxt.Location = new Point(329, 377);
            montoTxt.Name = "montoTxt";
            montoTxt.Size = new Size(149, 23);
            montoTxt.TabIndex = 25;
            // 
            // FrmCondicionSocieconomica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(782, 475);
            Controls.Add(montoTxt);
            Controls.Add(label7);
            Controls.Add(checkNoPatronato);
            Controls.Add(checkSiPatronato);
            Controls.Add(label6);
            Controls.Add(btnImprimir);
            Controls.Add(btnAtras);
            Controls.Add(checkUniversidad);
            Controls.Add(checkSecundariaCom);
            Controls.Add(checkSecundariaInc);
            Controls.Add(checkPrimariaCom);
            Controls.Add(checkPrimariaInc);
            Controls.Add(checkOtros);
            Controls.Add(label5);
            Controls.Add(checkPadreyMadre);
            Controls.Add(checkMadre);
            Controls.Add(checkPadre);
            Controls.Add(label4);
            Controls.Add(checkTransporte);
            Controls.Add(checkComedor);
            Controls.Add(checkImas);
            Controls.Add(label3);
            Controls.Add(checkNo);
            Controls.Add(checkSi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCondicionSocieconomica";
            Text = "FrmCondicionSocieconomica";
            Load += FrmCondicionSocieconomica_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkSi;
        private System.Windows.Forms.CheckBox checkNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkImas;
        private System.Windows.Forms.CheckBox checkComedor;
        private System.Windows.Forms.CheckBox checkTransporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkPadre;
        private System.Windows.Forms.CheckBox checkMadre;
        private System.Windows.Forms.CheckBox checkPadreyMadre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkOtros;
        private System.Windows.Forms.CheckBox checkPrimariaInc;
        private System.Windows.Forms.CheckBox checkPrimariaCom;
        private System.Windows.Forms.CheckBox checkSecundariaInc;
        private System.Windows.Forms.CheckBox checkSecundariaCom;
        private System.Windows.Forms.CheckBox checkUniversidad;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnImprimir;
        private Label label6;
        private CheckBox checkSiPatronato;
        private CheckBox checkNoPatronato;
        private Label label7;
        private TextBox montoTxt;
    }
}
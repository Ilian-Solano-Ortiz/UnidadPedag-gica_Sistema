namespace SistemaUPGrafica
{
    partial class BuscarUsuarios
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
            buscarBtn = new Button();
            buscarTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buscarBtn
            // 
            buscarBtn.BackColor = SystemColors.Highlight;
            buscarBtn.FlatStyle = FlatStyle.Flat;
            buscarBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buscarBtn.ForeColor = SystemColors.ButtonHighlight;
            buscarBtn.Location = new Point(611, 105);
            buscarBtn.Margin = new Padding(4, 5, 4, 5);
            buscarBtn.Name = "buscarBtn";
            buscarBtn.Size = new Size(100, 35);
            buscarBtn.TabIndex = 0;
            buscarBtn.Text = "Buscar";
            buscarBtn.UseVisualStyleBackColor = false;
            buscarBtn.Click += buscarBtn_Click;
            // 
            // buscarTxt
            // 
            buscarTxt.Location = new Point(292, 105);
            buscarTxt.Margin = new Padding(4, 5, 4, 5);
            buscarTxt.Name = "buscarTxt";
            buscarTxt.Size = new Size(263, 27);
            buscarTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 2;
            label1.Text = "Buscar Usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(365, 195);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 3;
            label2.Text = "Usuarios";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(93, 225);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(675, 275);
            dataGridView1.TabIndex = 4;
            // 
            // BuscarUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(888, 642);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buscarTxt);
            Controls.Add(buscarBtn);
            Margin = new Padding(4, 5, 4, 5);
            Name = "BuscarUsuarios";
            Text = "BuscarUsuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.TextBox buscarTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
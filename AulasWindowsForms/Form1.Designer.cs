namespace AulasWindowsForms
{
    partial class FrmRestoDivisao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDividendo = new TextBox();
            txtDivisor = new TextBox();
            txtResto = new TextBox();
            BtnDivisao = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(123, 138);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Dividendo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 138);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Divisor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 203);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Resto:";
            // 
            // txtDividendo
            // 
            txtDividendo.BackColor = SystemColors.WindowFrame;
            txtDividendo.ForeColor = SystemColors.ControlLightLight;
            txtDividendo.Location = new Point(193, 135);
            txtDividendo.Name = "txtDividendo";
            txtDividendo.Size = new Size(100, 23);
            txtDividendo.TabIndex = 0;
            // 
            // txtDivisor
            // 
            txtDivisor.BackColor = SystemColors.WindowFrame;
            txtDivisor.ForeColor = SystemColors.ControlLightLight;
            txtDivisor.Location = new Point(395, 135);
            txtDivisor.Name = "txtDivisor";
            txtDivisor.Size = new Size(100, 23);
            txtDivisor.TabIndex = 1;
            // 
            // txtResto
            // 
            txtResto.BackColor = SystemColors.ScrollBar;
            txtResto.Enabled = false;
            txtResto.ForeColor = SystemColors.ControlText;
            txtResto.Location = new Point(395, 200);
            txtResto.Name = "txtResto";
            txtResto.ReadOnly = true;
            txtResto.Size = new Size(100, 23);
            txtResto.TabIndex = 5;
            txtResto.TabStop = false;
            // 
            // BtnDivisao
            // 
            BtnDivisao.ForeColor = SystemColors.Desktop;
            BtnDivisao.Location = new Point(193, 203);
            BtnDivisao.Name = "BtnDivisao";
            BtnDivisao.Size = new Size(100, 23);
            BtnDivisao.TabIndex = 2;
            BtnDivisao.Text = "Realizar Divisão";
            BtnDivisao.UseVisualStyleBackColor = true;
            BtnDivisao.Click += BtnDivisao_Click;
            // 
            // FrmRestoDivisao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnDivisao);
            Controls.Add(txtResto);
            Controls.Add(txtDivisor);
            Controls.Add(txtDividendo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRestoDivisao";
            Text = "Resto da Divisão";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDividendo;
        private TextBox txtDivisor;
        private TextBox txtResto;
        private Button BtnDivisao;
    }
}

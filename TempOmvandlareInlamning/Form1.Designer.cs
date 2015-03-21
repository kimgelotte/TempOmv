namespace TempOmvandlareInlamning
{
    partial class Form1
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
            this.Input = new System.Windows.Forms.TextBox();
            this.Resultat = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.Konvertera = new System.Windows.Forms.Button();
            this.CtillF = new System.Windows.Forms.RadioButton();
            this.FtillC = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(90, 115);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(100, 20);
            this.Input.TabIndex = 0;
            this.Input.Text = "0";
            this.Input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Resultat
            // 
            this.Resultat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Resultat.Location = new System.Drawing.Point(90, 141);
            this.Resultat.MaxLength = 6;
            this.Resultat.Name = "Resultat";
            this.Resultat.ReadOnly = true;
            this.Resultat.Size = new System.Drawing.Size(100, 20);
            this.Resultat.TabIndex = 1;
            this.Resultat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(12, 118);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(78, 13);
            this.labelInput.TabIndex = 2;
            this.labelInput.Text = "Mata in värdet:";
            this.labelInput.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(41, 144);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(49, 13);
            this.labelOutput.TabIndex = 3;
            this.labelOutput.Text = "Resultat:";
            this.labelOutput.Click += new System.EventHandler(this.label2_Click);
            // 
            // Konvertera
            // 
            this.Konvertera.Location = new System.Drawing.Point(101, 167);
            this.Konvertera.Name = "Konvertera";
            this.Konvertera.Size = new System.Drawing.Size(75, 23);
            this.Konvertera.TabIndex = 4;
            this.Konvertera.Text = "Konvertera";
            this.Konvertera.UseVisualStyleBackColor = true;
            this.Konvertera.Click += new System.EventHandler(this.button1_Click);
            // 
            // CtillF
            // 
            this.CtillF.AutoSize = true;
            this.CtillF.Location = new System.Drawing.Point(90, 63);
            this.CtillF.Name = "CtillF";
            this.CtillF.Size = new System.Drawing.Size(123, 17);
            this.CtillF.TabIndex = 5;
            this.CtillF.TabStop = true;
            this.CtillF.Text = "Celsius till Fahrenheit";
            this.CtillF.UseVisualStyleBackColor = true;
            // 
            // FtillC
            // 
            this.FtillC.AutoSize = true;
            this.FtillC.Location = new System.Drawing.Point(90, 80);
            this.FtillC.Name = "FtillC";
            this.FtillC.Size = new System.Drawing.Size(123, 17);
            this.FtillC.TabIndex = 6;
            this.FtillC.TabStop = true;
            this.FtillC.Text = "Fahrenheit till Celsius";
            this.FtillC.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 248);
            this.Controls.Add(this.FtillC);
            this.Controls.Add(this.CtillF);
            this.Controls.Add(this.Konvertera);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.Resultat);
            this.Controls.Add(this.Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Temperaturomvandlaren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Resultat;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button Konvertera;
        private System.Windows.Forms.RadioButton CtillF;
        private System.Windows.Forms.RadioButton FtillC;
    }
}


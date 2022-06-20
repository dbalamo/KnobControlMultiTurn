
namespace KnobControlTest
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.knobControl1 = new KnobControl.KnobControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btpStepOne = new System.Windows.Forms.Button();
            this.btnStepTen = new System.Windows.Forms.Button();
            this.btnStepHundred = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // knobControl1
            // 
            this.knobControl1.BackColor = System.Drawing.Color.Black;
            this.knobControl1.EndAngle = 450F;
            this.knobControl1.ForeColor = System.Drawing.Color.White;
            this.knobControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.knobControl1.KnobBackColor = System.Drawing.Color.Gray;
            this.knobControl1.KnobPointerStyle = KnobControl.KnobControl.KnobPointerStyles.line;            
            this.knobControl1.Location = new System.Drawing.Point(191, 12);
            this.knobControl1.Maximum = 29999;
            this.knobControl1.Minimum = 0;
            this.knobControl1.Name = "knobControl1";
            this.knobControl1.PointerColor = System.Drawing.Color.White;
            this.knobControl1.ScaleColor = System.Drawing.Color.White;
            this.knobControl1.ScaleDivisions = 11;
            this.knobControl1.ScaleFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.knobControl1.ScaleSubDivisions = 4;
            this.knobControl1.ShowLargeScale = true;
            this.knobControl1.ShowSmallScale = true;
            this.knobControl1.Size = new System.Drawing.Size(423, 423);            
            this.knobControl1.StartAngle = 90F;
            this.knobControl1.Step = 1;
            this.knobControl1.TabIndex = 0;
            this.knobControl1.Value = 0;
            this.knobControl1.ValueChanged += new KnobControl.ValueChangedEventHandler(this.knobControl1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(285, 469);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 34);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "00000";
            // 
            // btpStepOne
            // 
            this.btpStepOne.Location = new System.Drawing.Point(716, 13);
            this.btpStepOne.Name = "btpStepOne";
            this.btpStepOne.Size = new System.Drawing.Size(94, 50);
            this.btpStepOne.TabIndex = 2;
            this.btpStepOne.Text = "Step 1";
            this.btpStepOne.UseVisualStyleBackColor = true;
            this.btpStepOne.Click += new System.EventHandler(this.btpStepOne_Click);
            // 
            // btnStepTen
            // 
            this.btnStepTen.Location = new System.Drawing.Point(716, 80);
            this.btnStepTen.Name = "btnStepTen";
            this.btnStepTen.Size = new System.Drawing.Size(94, 50);
            this.btnStepTen.TabIndex = 3;
            this.btnStepTen.Text = "Step 10";
            this.btnStepTen.UseVisualStyleBackColor = true;
            this.btnStepTen.Click += new System.EventHandler(this.btnStepTen_Click);
            // 
            // btnStepHundred
            // 
            this.btnStepHundred.Location = new System.Drawing.Point(716, 152);
            this.btnStepHundred.Name = "btnStepHundred";
            this.btnStepHundred.Size = new System.Drawing.Size(94, 50);
            this.btnStepHundred.TabIndex = 4;
            this.btnStepHundred.Text = "Step 100";
            this.btnStepHundred.UseVisualStyleBackColor = true;
            this.btnStepHundred.Click += new System.EventHandler(this.btnStepHundred_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(822, 532);
            this.Controls.Add(this.btnStepHundred);
            this.Controls.Add(this.btnStepTen);
            this.Controls.Add(this.btpStepOne);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.knobControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KnobControl.KnobControl knobControl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btpStepOne;
        private System.Windows.Forms.Button btnStepTen;
        private System.Windows.Forms.Button btnStepHundred;
    }
}


namespace Physics_Formulas
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
            this.label1 = new System.Windows.Forms.Label();
            this.formulaInput = new System.Windows.Forms.TextBox();
            this.formulaOut = new System.Windows.Forms.TextBox();
            this.launchCalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search the term you wish to view (all terms in lower case):";
            // 
            // formulaInput
            // 
            this.formulaInput.Location = new System.Drawing.Point(53, 53);
            this.formulaInput.Name = "formulaInput";
            this.formulaInput.Size = new System.Drawing.Size(177, 20);
            this.formulaInput.TabIndex = 1;
            this.formulaInput.TextChanged += new System.EventHandler(this.formulaInput_TextChanged);
            // 
            // formulaOut
            // 
            this.formulaOut.Location = new System.Drawing.Point(53, 107);
            this.formulaOut.Multiline = true;
            this.formulaOut.Name = "formulaOut";
            this.formulaOut.Size = new System.Drawing.Size(180, 120);
            this.formulaOut.TabIndex = 2;
            this.formulaOut.TextChanged += new System.EventHandler(this.formulaOut_TextChanged);
            // 
            // launchCalc
            // 
            this.launchCalc.Location = new System.Drawing.Point(105, 233);
            this.launchCalc.Name = "launchCalc";
            this.launchCalc.Size = new System.Drawing.Size(75, 23);
            this.launchCalc.TabIndex = 3;
            this.launchCalc.Text = "Calculator";
            this.launchCalc.UseVisualStyleBackColor = true;
            this.launchCalc.Click += new System.EventHandler(this.launchCalc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Formula/Definition below:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "e.g. force, velocity, newton\'s second law";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.launchCalc);
            this.Controls.Add(this.formulaOut);
            this.Controls.Add(this.formulaInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Physics Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox formulaInput;
        private System.Windows.Forms.TextBox formulaOut;
        private System.Windows.Forms.Button launchCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


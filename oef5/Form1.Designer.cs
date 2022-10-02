namespace oef5
{
    partial class Form1
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
            this.celcius = new System.Windows.Forms.Label();
            this.fahrenheit = new System.Windows.Forms.Label();
            this.celciusnumber = new System.Windows.Forms.TextBox();
            this.fahrenheitnumber = new System.Windows.Forms.TextBox();
            this.ctof = new System.Windows.Forms.Button();
            this.ftoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // celcius
            // 
            this.celcius.AutoSize = true;
            this.celcius.Location = new System.Drawing.Point(171, 50);
            this.celcius.Name = "celcius";
            this.celcius.Size = new System.Drawing.Size(55, 20);
            this.celcius.TabIndex = 0;
            this.celcius.Text = "Celcius";
            // 
            // fahrenheit
            // 
            this.fahrenheit.AutoSize = true;
            this.fahrenheit.Location = new System.Drawing.Point(394, 50);
            this.fahrenheit.Name = "fahrenheit";
            this.fahrenheit.Size = new System.Drawing.Size(77, 20);
            this.fahrenheit.TabIndex = 1;
            this.fahrenheit.Text = "Fahrenheit";
            // 
            // celciusnumber
            // 
            this.celciusnumber.Location = new System.Drawing.Point(153, 86);
            this.celciusnumber.Name = "celciusnumber";
            this.celciusnumber.Size = new System.Drawing.Size(125, 27);
            this.celciusnumber.TabIndex = 2;
            // 
            // fahrenheitnumber
            // 
            this.fahrenheitnumber.Location = new System.Drawing.Point(394, 86);
            this.fahrenheitnumber.Name = "fahrenheitnumber";
            this.fahrenheitnumber.Size = new System.Drawing.Size(125, 27);
            this.fahrenheitnumber.TabIndex = 3;
            this.fahrenheitnumber.TextChanged += new System.EventHandler(this.fahrenheitnumber_TextChanged);
            // 
            // ctof
            // 
            this.ctof.Location = new System.Drawing.Point(153, 160);
            this.ctof.Name = "ctof";
            this.ctof.Size = new System.Drawing.Size(94, 29);
            this.ctof.TabIndex = 4;
            this.ctof.Text = "C to F";
            this.ctof.UseVisualStyleBackColor = true;
            this.ctof.Click += new System.EventHandler(this.ctof_Click);
            // 
            // ftoc
            // 
            this.ftoc.Location = new System.Drawing.Point(407, 160);
            this.ftoc.Name = "ftoc";
            this.ftoc.Size = new System.Drawing.Size(94, 29);
            this.ftoc.TabIndex = 5;
            this.ftoc.Text = "F to C";
            this.ftoc.UseVisualStyleBackColor = true;
            this.ftoc.Click += new System.EventHandler(this.ftoc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ftoc);
            this.Controls.Add(this.ctof);
            this.Controls.Add(this.fahrenheitnumber);
            this.Controls.Add(this.celciusnumber);
            this.Controls.Add(this.fahrenheit);
            this.Controls.Add(this.celcius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label celcius;
        private Label fahrenheit;
        private TextBox celciusnumber;
        private TextBox fahrenheitnumber;
        private Button ctof;
        private Button ftoc;
    }
}
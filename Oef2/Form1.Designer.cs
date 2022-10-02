namespace Oef2
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
            this.berekening1 = new System.Windows.Forms.Label();
            this.berekening2 = new System.Windows.Forms.Label();
            this.result1 = new System.Windows.Forms.Label();
            this.result2 = new System.Windows.Forms.Label();
            this.compare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // berekening1
            // 
            this.berekening1.AutoSize = true;
            this.berekening1.Location = new System.Drawing.Point(236, 57);
            this.berekening1.Name = "berekening1";
            this.berekening1.Size = new System.Drawing.Size(38, 20);
            this.berekening1.TabIndex = 0;
            this.berekening1.Text = "brk1";
            this.berekening1.Click += new System.EventHandler(this.berekening1_Click);
            // 
            // berekening2
            // 
            this.berekening2.AutoSize = true;
            this.berekening2.Location = new System.Drawing.Point(236, 114);
            this.berekening2.Name = "berekening2";
            this.berekening2.Size = new System.Drawing.Size(38, 20);
            this.berekening2.TabIndex = 1;
            this.berekening2.Text = "brk2";
            // 
            // result1
            // 
            this.result1.AutoSize = true;
            this.result1.Location = new System.Drawing.Point(330, 57);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(53, 20);
            this.result1.TabIndex = 2;
            this.result1.Text = "result1";
            // 
            // result2
            // 
            this.result2.AutoSize = true;
            this.result2.Location = new System.Drawing.Point(330, 114);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(53, 20);
            this.result2.TabIndex = 3;
            this.result2.Text = "result2";
            // 
            // compare
            // 
            this.compare.AutoSize = true;
            this.compare.Location = new System.Drawing.Point(236, 185);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(68, 20);
            this.compare.TabIndex = 4;
            this.compare.Text = "compare";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.berekening2);
            this.Controls.Add(this.berekening1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label berekening1;
        private Label berekening2;
        private Label result1;
        private Label result2;
        private Label label1;
        private Label compare;
    }
}
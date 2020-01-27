namespace RoonechrAssignment1_Duh
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
            this.dumbRadio = new System.Windows.Forms.RadioButton();
            this.xposTbox = new System.Windows.Forms.TextBox();
            this.yPosTbox = new System.Windows.Forms.TextBox();
            this.iterationsTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.smartRadio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dumbRadio
            // 
            this.dumbRadio.AutoSize = true;
            this.dumbRadio.Location = new System.Drawing.Point(198, 265);
            this.dumbRadio.Name = "dumbRadio";
            this.dumbRadio.Size = new System.Drawing.Size(92, 17);
            this.dumbRadio.TabIndex = 0;
            this.dumbRadio.TabStop = true;
            this.dumbRadio.Text = "Dumb Method";
            this.dumbRadio.UseVisualStyleBackColor = true;
            // 
            // xposTbox
            // 
            this.xposTbox.Location = new System.Drawing.Point(126, 97);
            this.xposTbox.Name = "xposTbox";
            this.xposTbox.Size = new System.Drawing.Size(100, 20);
            this.xposTbox.TabIndex = 1;
            this.xposTbox.Text = "3";
            // 
            // yPosTbox
            // 
            this.yPosTbox.Location = new System.Drawing.Point(126, 152);
            this.yPosTbox.Name = "yPosTbox";
            this.yPosTbox.Size = new System.Drawing.Size(100, 20);
            this.yPosTbox.TabIndex = 2;
            this.yPosTbox.Text = "4";
            // 
            // iterationsTbox
            // 
            this.iterationsTbox.Location = new System.Drawing.Point(126, 210);
            this.iterationsTbox.Name = "iterationsTbox";
            this.iterationsTbox.Size = new System.Drawing.Size(100, 20);
            this.iterationsTbox.TabIndex = 3;
            this.iterationsTbox.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X-Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y-Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Iterations";
            // 
            // smartRadio
            // 
            this.smartRadio.AutoSize = true;
            this.smartRadio.Location = new System.Drawing.Point(66, 265);
            this.smartRadio.Name = "smartRadio";
            this.smartRadio.Size = new System.Drawing.Size(91, 17);
            this.smartRadio.TabIndex = 7;
            this.smartRadio.TabStop = true;
            this.smartRadio.Text = "Smart Method";
            this.smartRadio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Run Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(430, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(281, 296);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Output:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.smartRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iterationsTbox);
            this.Controls.Add(this.yPosTbox);
            this.Controls.Add(this.xposTbox);
            this.Controls.Add(this.dumbRadio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton dumbRadio;
        private System.Windows.Forms.TextBox xposTbox;
        private System.Windows.Forms.TextBox yPosTbox;
        private System.Windows.Forms.TextBox iterationsTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton smartRadio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
    }
}


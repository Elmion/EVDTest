namespace GameTester
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bCardActivator = new System.Windows.Forms.Button();
            this.tbCardDescription = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCardActivator
            // 
            this.bCardActivator.Location = new System.Drawing.Point(3, 3);
            this.bCardActivator.Name = "bCardActivator";
            this.bCardActivator.Size = new System.Drawing.Size(172, 49);
            this.bCardActivator.TabIndex = 0;
            this.bCardActivator.Text = "button1";
            this.bCardActivator.UseVisualStyleBackColor = true;
            // 
            // tbCardDescription
            // 
            this.tbCardDescription.Location = new System.Drawing.Point(3, 58);
            this.tbCardDescription.Multiline = true;
            this.tbCardDescription.Name = "tbCardDescription";
            this.tbCardDescription.Size = new System.Drawing.Size(172, 231);
            this.tbCardDescription.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bCardActivator);
            this.panel1.Controls.Add(this.tbCardDescription);
            this.panel1.Location = new System.Drawing.Point(3, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 125);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(132, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 125);
            this.panel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 49);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 231);
            this.textBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(261, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 125);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 58);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 231);
            this.textBox2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 13);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(362, 10);
            this.progressBar1.TabIndex = 3;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 29);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(362, 10);
            this.progressBar2.TabIndex = 3;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(12, 45);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(362, 10);
            this.progressBar3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 584);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCardActivator;
        private System.Windows.Forms.TextBox tbCardDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
    }
}


namespace GameTester
{
    partial class CardCreator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbAddedEffect = new System.Windows.Forms.ListBox();
            this.ucCM = new GameTester.ucClassMethod();
            this.AddToList = new System.Windows.Forms.Button();
            this.RemoveSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Описание";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 83);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(317, 124);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 195);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbAddedEffect
            // 
            this.lbAddedEffect.FormattingEnabled = true;
            this.lbAddedEffect.Location = new System.Drawing.Point(12, 229);
            this.lbAddedEffect.Name = "lbAddedEffect";
            this.lbAddedEffect.Size = new System.Drawing.Size(150, 290);
            this.lbAddedEffect.TabIndex = 4;
            // 
            // ucCM
            // 
            this.ucCM.Location = new System.Drawing.Point(212, 230);
            this.ucCM.Name = "ucCM";
            this.ucCM.Size = new System.Drawing.Size(279, 289);
            this.ucCM.TabIndex = 5;
            // 
            // AddToList
            // 
            this.AddToList.Location = new System.Drawing.Point(168, 339);
            this.AddToList.Name = "AddToList";
            this.AddToList.Size = new System.Drawing.Size(40, 50);
            this.AddToList.TabIndex = 6;
            this.AddToList.Text = "button1";
            this.AddToList.UseVisualStyleBackColor = true;
            // 
            // RemoveSelected
            // 
            this.RemoveSelected.Location = new System.Drawing.Point(168, 395);
            this.RemoveSelected.Name = "RemoveSelected";
            this.RemoveSelected.Size = new System.Drawing.Size(40, 50);
            this.RemoveSelected.TabIndex = 6;
            this.RemoveSelected.Text = "button1";
            this.RemoveSelected.UseVisualStyleBackColor = true;
            // 
            // CardCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 528);
            this.Controls.Add(this.RemoveSelected);
            this.Controls.Add(this.AddToList);
            this.Controls.Add(this.ucCM);
            this.Controls.Add(this.lbAddedEffect);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CardCreator";
            this.Text = "CardCreator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbAddedEffect;
        private ucClassMethod ucCM;
        private System.Windows.Forms.Button AddToList;
        private System.Windows.Forms.Button RemoveSelected;
    }
}
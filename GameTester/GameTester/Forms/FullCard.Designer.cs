namespace GameTester
{
    partial class FullCard
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
            this.lHeader = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.pImage = new System.Windows.Forms.PictureBox();
            this.lbEffects = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lHeader
            // 
            this.lHeader.AutoSize = true;
            this.lHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lHeader.Location = new System.Drawing.Point(162, 13);
            this.lHeader.Name = "lHeader";
            this.lHeader.Size = new System.Drawing.Size(115, 25);
            this.lHeader.TabIndex = 1;
            this.lHeader.Text = "Заголовок";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDescription.Location = new System.Drawing.Point(2, 151);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(421, 133);
            this.tbDescription.TabIndex = 2;
            this.tbDescription.Text = "Текст описания";
            // 
            // bClose
            // 
            this.bClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bClose.Location = new System.Drawing.Point(341, 290);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 24);
            this.bClose.TabIndex = 3;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            // 
            // pImage
            // 
            this.pImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pImage.Location = new System.Drawing.Point(2, 3);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(140, 142);
            this.pImage.TabIndex = 0;
            this.pImage.TabStop = false;
            // 
            // lbEffects
            // 
            this.lbEffects.FormattingEnabled = true;
            this.lbEffects.Location = new System.Drawing.Point(148, 50);
            this.lbEffects.Name = "lbEffects";
            this.lbEffects.Size = new System.Drawing.Size(275, 95);
            this.lbEffects.TabIndex = 4;
            // 
            // FullCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 315);
            this.Controls.Add(this.lbEffects);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lHeader);
            this.Controls.Add(this.pImage);
            this.Name = "FullCard";
            this.Text = "FullCard";
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pImage;
        private System.Windows.Forms.Label lHeader;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.ListBox lbEffects;
    }
}
namespace GameTester
{
    partial class CardView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCardDescription = new System.Windows.Forms.TextBox();
            this.lHeader = new System.Windows.Forms.Label();
            this.picCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCardDescription
            // 
            this.tbCardDescription.Enabled = false;
            this.tbCardDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCardDescription.Location = new System.Drawing.Point(0, 89);
            this.tbCardDescription.Multiline = true;
            this.tbCardDescription.Name = "tbCardDescription";
            this.tbCardDescription.Size = new System.Drawing.Size(125, 36);
            this.tbCardDescription.TabIndex = 1;
            this.tbCardDescription.Text = "asdasdasdasd";
            // 
            // lHeader
            // 
            this.lHeader.AutoSize = true;
            this.lHeader.Enabled = false;
            this.lHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lHeader.Location = new System.Drawing.Point(3, 0);
            this.lHeader.Name = "lHeader";
            this.lHeader.Size = new System.Drawing.Size(65, 20);
            this.lHeader.TabIndex = 2;
            this.lHeader.Text = "lHeader";
            // 
            // picCard
            // 
            this.picCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard.Enabled = false;
            this.picCard.Location = new System.Drawing.Point(28, 23);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(61, 60);
            this.picCard.TabIndex = 3;
            this.picCard.TabStop = false;
            // 
            // CardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picCard);
            this.Controls.Add(this.lHeader);
            this.Controls.Add(this.tbCardDescription);
            this.Name = "CardView";
            this.Size = new System.Drawing.Size(123, 123);
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCardDescription;
        private System.Windows.Forms.Label lHeader;
        private System.Windows.Forms.PictureBox picCard;
    }
}

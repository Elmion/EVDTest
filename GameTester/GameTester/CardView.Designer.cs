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
            this.SuspendLayout();
            // 
            // tbCardDescription
            // 
            this.tbCardDescription.Enabled = false;
            this.tbCardDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCardDescription.Location = new System.Drawing.Point(0, 74);
            this.tbCardDescription.Multiline = true;
            this.tbCardDescription.Name = "tbCardDescription";
            this.tbCardDescription.Size = new System.Drawing.Size(125, 51);
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
            // CardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lHeader);
            this.Controls.Add(this.tbCardDescription);
            this.Name = "CardView";
            this.Size = new System.Drawing.Size(125, 125);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCardDescription;
        private System.Windows.Forms.Label lHeader;
    }
}

namespace GameTester
{
    partial class ucClassMethod
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
            this.cbMethods = new System.Windows.Forms.ComboBox();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbMethods
            // 
            this.cbMethods.FormattingEnabled = true;
            this.cbMethods.Location = new System.Drawing.Point(3, 29);
            this.cbMethods.Name = "cbMethods";
            this.cbMethods.Size = new System.Drawing.Size(273, 21);
            this.cbMethods.TabIndex = 2;
            // 
            // gbParameters
            // 
            this.gbParameters.BackColor = System.Drawing.Color.White;
            this.gbParameters.Location = new System.Drawing.Point(3, 56);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Size = new System.Drawing.Size(273, 234);
            this.gbParameters.TabIndex = 3;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "Параметры";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(3, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(272, 20);
            this.tbName.TabIndex = 4;
            // 
            // ucClassMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.gbParameters);
            this.Controls.Add(this.cbMethods);
            this.Name = "ucClassMethod";
            this.Size = new System.Drawing.Size(279, 303);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMethods;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.TextBox tbName;
    }
}

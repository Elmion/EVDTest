namespace GraphEditor
{
    partial class UcParameterOutput
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
            this.sc = new System.Windows.Forms.SplitContainer();
            this.lNameType = new System.Windows.Forms.Label();
            this.pbOut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOut)).BeginInit();
            this.SuspendLayout();
            // 
            // sc
            // 
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.Location = new System.Drawing.Point(0, 0);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.Controls.Add(this.lNameType);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.Controls.Add(this.pbOut);
            this.sc.Size = new System.Drawing.Size(141, 24);
            this.sc.SplitterDistance = 111;
            this.sc.SplitterWidth = 1;
            this.sc.TabIndex = 0;
            // 
            // lNameType
            // 
            this.lNameType.AutoSize = true;
            this.lNameType.Location = new System.Drawing.Point(3, 5);
            this.lNameType.Name = "lNameType";
            this.lNameType.Size = new System.Drawing.Size(61, 13);
            this.lNameType.TabIndex = 0;
            this.lNameType.Text = "lNameType";
            // 
            // pbOut
            // 
            this.pbOut.BackColor = System.Drawing.Color.LimeGreen;
            this.pbOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbOut.Location = new System.Drawing.Point(0, 0);
            this.pbOut.Name = "pbOut";
            this.pbOut.Size = new System.Drawing.Size(29, 24);
            this.pbOut.TabIndex = 0;
            this.pbOut.TabStop = false;
            // 
            // UcParameterOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sc);
            this.Name = "UcParameterOutput";
            this.Size = new System.Drawing.Size(141, 24);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel1.PerformLayout();
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.Label lNameType;
        private System.Windows.Forms.PictureBox pbOut;
    }
}

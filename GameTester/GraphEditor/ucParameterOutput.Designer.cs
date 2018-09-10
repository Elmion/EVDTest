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
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.SuspendLayout();
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
            this.sc.Panel2.AllowDrop = true;
            this.sc.Panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.sc.Panel2.Click += new System.EventHandler(this.sc_Panel2_Click);
            this.sc.Panel2.MouseEnter += new System.EventHandler(this.pbOut_MouseEnter);
            this.sc.Panel2.MouseLeave += new System.EventHandler(this.pbOut_MouseLeave);
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
            // UcParameterOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sc);
            this.Name = "UcParameterOutput";
            this.Size = new System.Drawing.Size(141, 24);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.Label lNameType;
    }
}

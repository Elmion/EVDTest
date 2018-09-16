namespace GraphEditor
{
    partial class UcРarameterInput
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
            this.pbConnectorIn = new System.Windows.Forms.PictureBox();
            this.lName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectorIn)).BeginInit();
            this.SuspendLayout();
            // 
            // sc
            // 
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.Location = new System.Drawing.Point(0, 0);
            this.sc.Margin = new System.Windows.Forms.Padding(0);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.Controls.Add(this.pbConnectorIn);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.BackColor = System.Drawing.Color.White;
            this.sc.Panel2.Controls.Add(this.lName);
            this.sc.Size = new System.Drawing.Size(175, 24);
            this.sc.SplitterDistance = 25;
            this.sc.SplitterWidth = 1;
            this.sc.TabIndex = 0;
            // 
            // pbConnectorIn
            // 
            this.pbConnectorIn.BackColor = System.Drawing.Color.DarkRed;
            this.pbConnectorIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbConnectorIn.Location = new System.Drawing.Point(0, 0);
            this.pbConnectorIn.Name = "pbConnectorIn";
            this.pbConnectorIn.Size = new System.Drawing.Size(25, 24);
            this.pbConnectorIn.TabIndex = 0;
            this.pbConnectorIn.TabStop = false;
            this.pbConnectorIn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbConnectorIn_MouseClick);
            this.pbConnectorIn.MouseEnter += new System.EventHandler(this.pbConnectorIn_MouseEnter);
            this.pbConnectorIn.MouseLeave += new System.EventHandler(this.pbConnectorIn_MouseLeave);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(3, 5);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(37, 13);
            this.lName.TabIndex = 0;
            this.lName.Text = "lName";
            // 
            // UcРarameterInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.sc);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcРarameterInput";
            this.Size = new System.Drawing.Size(175, 24);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            this.sc.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectorIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.PictureBox pbConnectorIn;
        private System.Windows.Forms.Label lName;
    }
}

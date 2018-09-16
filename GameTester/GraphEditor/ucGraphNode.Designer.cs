namespace GraphEditor
{
    partial class ucGraphNode
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
            this.Body = new System.Windows.Forms.Panel();
            this.pMovePanel = new System.Windows.Forms.Panel();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.lDescription = new System.Windows.Forms.Label();
            this.Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.Silver;
            this.Body.Controls.Add(this.pMovePanel);
            this.Body.Controls.Add(this.cbMethod);
            this.Body.Controls.Add(this.lDescription);
            this.Body.Location = new System.Drawing.Point(34, 3);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(273, 264);
            this.Body.TabIndex = 1;
            // 
            // pMovePanel
            // 
            this.pMovePanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pMovePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMovePanel.Location = new System.Drawing.Point(0, 0);
            this.pMovePanel.Name = "pMovePanel";
            this.pMovePanel.Size = new System.Drawing.Size(273, 22);
            this.pMovePanel.TabIndex = 2;
            // 
            // cbMethod
            // 
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Location = new System.Drawing.Point(3, 26);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(199, 21);
            this.cbMethod.TabIndex = 1;
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(3, 50);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(60, 13);
            this.lDescription.TabIndex = 0;
            this.lDescription.Text = "Description";
            // 
            // ucGraphNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Body);
            this.Name = "ucGraphNode";
            this.Size = new System.Drawing.Size(331, 273);
            this.Body.ResumeLayout(false);
            this.Body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Body;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.Panel pMovePanel;
    }
}

namespace GameTester
{
    partial class ucListActions<T>
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
            this.RemoveSelected = new System.Windows.Forms.Button();
            this.AddToList = new System.Windows.Forms.Button();
            this.lbAddedEffect = new System.Windows.Forms.ListBox();
            this.ucCM = new GameTester.ucClassMethod();
            this.SuspendLayout();
            // 
            // RemoveSelected
            // 
            this.RemoveSelected.Location = new System.Drawing.Point(157, 168);
            this.RemoveSelected.Name = "RemoveSelected";
            this.RemoveSelected.Size = new System.Drawing.Size(40, 50);
            this.RemoveSelected.TabIndex = 6;
            this.RemoveSelected.Text = "Remove";
            this.RemoveSelected.UseVisualStyleBackColor = true;
            this.RemoveSelected.Click += new System.EventHandler(this.RemoveSelected_Click);
            // 
            // AddToList
            // 
            this.AddToList.Location = new System.Drawing.Point(157, 112);
            this.AddToList.Name = "AddToList";
            this.AddToList.Size = new System.Drawing.Size(40, 50);
            this.AddToList.TabIndex = 6;
            this.AddToList.Text = "Add";
            this.AddToList.UseVisualStyleBackColor = true;
            this.AddToList.Click += new System.EventHandler(this.AddToList_Click);
            // 
            // lbAddedEffect
            // 
            this.lbAddedEffect.FormattingEnabled = true;
            this.lbAddedEffect.Location = new System.Drawing.Point(3, 3);
            this.lbAddedEffect.Name = "lbAddedEffect";
            this.lbAddedEffect.Size = new System.Drawing.Size(150, 290);
            this.lbAddedEffect.TabIndex = 4;
            // 
            // ucCM
            // 
            this.ucCM.Location = new System.Drawing.Point(203, 3);
            this.ucCM.Name = "ucCM";
            this.ucCM.Size = new System.Drawing.Size(279, 290);
            this.ucCM.TabIndex = 5;
            // 
            // ucListActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucCM);
            this.Controls.Add(this.lbAddedEffect);
            this.Controls.Add(this.RemoveSelected);
            this.Controls.Add(this.AddToList);
            this.Name = "ucListActions";
            this.Size = new System.Drawing.Size(483, 297);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RemoveSelected;
        private System.Windows.Forms.Button AddToList;
        private System.Windows.Forms.ListBox lbAddedEffect;
        private ucClassMethod ucCM;
    }
}

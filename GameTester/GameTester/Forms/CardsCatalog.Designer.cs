namespace GameTester
{
    partial class CardsCatalog
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbCards = new System.Windows.Forms.ListBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbCards);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bDelete);
            this.splitContainer1.Panel2.Controls.Add(this.bSave);
            this.splitContainer1.Panel2.Controls.Add(this.bNew);
            this.splitContainer1.Size = new System.Drawing.Size(221, 649);
            this.splitContainer1.SplitterDistance = 581;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbCards
            // 
            this.lbCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCards.FormattingEnabled = true;
            this.lbCards.Location = new System.Drawing.Point(0, 0);
            this.lbCards.Name = "lbCards";
            this.lbCards.Size = new System.Drawing.Size(221, 581);
            this.lbCards.TabIndex = 0;
            this.lbCards.SelectedIndexChanged += new System.EventHandler(this.lbCards_SelectedIndexChanged);
            this.lbCards.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbCards_MouseDoubleClick);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(155, 6);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(63, 55);
            this.bDelete.TabIndex = 1;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(74, 6);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 55);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(3, 6);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(65, 55);
            this.bNew.TabIndex = 0;
            this.bNew.Text = "Новая";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // CardsCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 649);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CardsCatalog";
            this.Text = "CardsCatalog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CardsCatalog_FormClosing);
            this.Move += new System.EventHandler(this.CardsCatalog_Move);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbCards;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bSave;
    }
}
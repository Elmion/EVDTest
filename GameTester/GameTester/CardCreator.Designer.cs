namespace GameTester
{
    partial class CardCreator
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
            this.tbHeader = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDiscription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAddedEffect = new System.Windows.Forms.ListBox();
            this.AddToList = new System.Windows.Forms.Button();
            this.RemoveSelected = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.bNewPic = new System.Windows.Forms.Button();
            this.picCard = new System.Windows.Forms.PictureBox();
            this.ucCM = new GameTester.ucClassMethod();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHeader
            // 
            this.tbHeader.Location = new System.Drawing.Point(176, 31);
            this.tbHeader.Name = "tbHeader";
            this.tbHeader.Size = new System.Drawing.Size(317, 20);
            this.tbHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Описание";
            // 
            // tbDiscription
            // 
            this.tbDiscription.Location = new System.Drawing.Point(176, 70);
            this.tbDiscription.Multiline = true;
            this.tbDiscription.Name = "tbDiscription";
            this.tbDiscription.Size = new System.Drawing.Size(317, 142);
            this.tbDiscription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // lbAddedEffect
            // 
            this.lbAddedEffect.FormattingEnabled = true;
            this.lbAddedEffect.Location = new System.Drawing.Point(12, 229);
            this.lbAddedEffect.Name = "lbAddedEffect";
            this.lbAddedEffect.Size = new System.Drawing.Size(150, 290);
            this.lbAddedEffect.TabIndex = 4;
            // 
            // AddToList
            // 
            this.AddToList.Location = new System.Drawing.Point(168, 339);
            this.AddToList.Name = "AddToList";
            this.AddToList.Size = new System.Drawing.Size(40, 50);
            this.AddToList.TabIndex = 6;
            this.AddToList.Text = "Add";
            this.AddToList.UseVisualStyleBackColor = true;
            this.AddToList.Click += new System.EventHandler(this.AddToList_Click);
            // 
            // RemoveSelected
            // 
            this.RemoveSelected.Location = new System.Drawing.Point(168, 395);
            this.RemoveSelected.Name = "RemoveSelected";
            this.RemoveSelected.Size = new System.Drawing.Size(40, 50);
            this.RemoveSelected.TabIndex = 6;
            this.RemoveSelected.Text = "Remove";
            this.RemoveSelected.UseVisualStyleBackColor = true;
            this.RemoveSelected.Click += new System.EventHandler(this.RemoveSelected_Click);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(416, 525);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 7;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bNewPic
            // 
            this.bNewPic.Location = new System.Drawing.Point(12, 191);
            this.bNewPic.Name = "bNewPic";
            this.bNewPic.Size = new System.Drawing.Size(155, 21);
            this.bNewPic.TabIndex = 8;
            this.bNewPic.Text = "Сменить картинку";
            this.bNewPic.UseVisualStyleBackColor = true;
            this.bNewPic.Click += new System.EventHandler(this.bNewPic_Click);
            // 
            // picCard
            // 
            this.picCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard.Location = new System.Drawing.Point(12, 12);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(155, 173);
            this.picCard.TabIndex = 0;
            this.picCard.TabStop = false;
            // 
            // ucCM
            // 
            this.ucCM.Location = new System.Drawing.Point(212, 230);
            this.ucCM.Name = "ucCM";
            this.ucCM.Size = new System.Drawing.Size(279, 289);
            this.ucCM.TabIndex = 5;
            // 
            // CardCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 552);
            this.Controls.Add(this.bNewPic);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.RemoveSelected);
            this.Controls.Add(this.AddToList);
            this.Controls.Add(this.ucCM);
            this.Controls.Add(this.lbAddedEffect);
            this.Controls.Add(this.tbDiscription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHeader);
            this.Controls.Add(this.picCard);
            this.Name = "CardCreator";
            this.Text = "CardCreator";
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCard;
        private System.Windows.Forms.TextBox tbHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDiscription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbAddedEffect;
        private ucClassMethod ucCM;
        private System.Windows.Forms.Button AddToList;
        private System.Windows.Forms.Button RemoveSelected;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bNewPic;
    }
}
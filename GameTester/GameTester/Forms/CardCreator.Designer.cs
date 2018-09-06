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
            this.bOk = new System.Windows.Forms.Button();
            this.bNewPic = new System.Windows.Forms.Button();
            this.picCard = new System.Windows.Forms.PictureBox();
            this.groopEffect = new System.Windows.Forms.GroupBox();
            this.groupCondition = new System.Windows.Forms.GroupBox();
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
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(869, 15);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(105, 64);
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
            // groopEffect
            // 
            this.groopEffect.BackColor = System.Drawing.Color.Silver;
            this.groopEffect.Location = new System.Drawing.Point(2, 219);
            this.groopEffect.Name = "groopEffect";
            this.groopEffect.Size = new System.Drawing.Size(489, 319);
            this.groopEffect.TabIndex = 9;
            this.groopEffect.TabStop = false;
            this.groopEffect.Text = "Эффекты";
            // 
            // groupCondition
            // 
            this.groupCondition.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupCondition.Location = new System.Drawing.Point(497, 219);
            this.groupCondition.Name = "groupCondition";
            this.groupCondition.Size = new System.Drawing.Size(486, 319);
            this.groupCondition.TabIndex = 10;
            this.groupCondition.TabStop = false;
            this.groupCondition.Text = "Условия";
            // 
            // CardCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 542);
            this.Controls.Add(this.groupCondition);
            this.Controls.Add(this.groopEffect);
            this.Controls.Add(this.bNewPic);
            this.Controls.Add(this.bOk);
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
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bNewPic;
        private System.Windows.Forms.GroupBox groopEffect;
        private System.Windows.Forms.GroupBox groupCondition;
    }
}
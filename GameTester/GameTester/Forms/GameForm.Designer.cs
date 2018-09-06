namespace GameTester
{
    partial class GameForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBoard = new System.Windows.Forms.Panel();
            this.pbHealth = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lMoney = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoard
            // 
            this.pBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoard.Location = new System.Drawing.Point(1, 230);
            this.pBoard.Name = "pBoard";
            this.pBoard.Size = new System.Drawing.Size(383, 376);
            this.pBoard.TabIndex = 4;
            // 
            // pbHealth
            // 
            this.pbHealth.Location = new System.Drawing.Point(63, 61);
            this.pbHealth.Name = "pbHealth";
            this.pbHealth.Size = new System.Drawing.Size(313, 42);
            this.pbHealth.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GameTester.Properties.Resources.clock_flat;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(13, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 45);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::GameTester.Properties.Resources.Heart;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(13, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 42);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GameTester.Properties.Resources.Finance_Money_Box_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(13, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 42);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lMoney
            // 
            this.lMoney.AutoSize = true;
            this.lMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lMoney.Location = new System.Drawing.Point(63, 112);
            this.lMoney.Name = "lMoney";
            this.lMoney.Size = new System.Drawing.Size(161, 37);
            this.lMoney.TabIndex = 6;
            this.lMoney.Text = "99999999";
            // 
            // tbTime
            // 
            this.tbTime.Enabled = false;
            this.tbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTime.Location = new System.Drawing.Point(63, 12);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(129, 42);
            this.tbTime.TabIndex = 7;
            this.tbTime.Text = "99:99:99";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(255, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Age";
            // 
            // tbAge
            // 
            this.tbAge.Enabled = false;
            this.tbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAge.Location = new System.Drawing.Point(323, 15);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(52, 38);
            this.tbAge.TabIndex = 9;
            this.tbAge.Text = "999";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 610);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.lMoney);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pBoard);
            this.Controls.Add(this.pbHealth);
            this.Name = "GameForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pBoard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar pbHealth;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lMoney;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAge;
    }
}


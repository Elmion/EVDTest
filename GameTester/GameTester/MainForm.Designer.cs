namespace GameTester
{
    partial class MainForm
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
            this.bGameStart = new System.Windows.Forms.Button();
            this.bChangeDesk = new System.Windows.Forms.Button();
            this.pbTest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).BeginInit();
            this.SuspendLayout();
            // 
            // bGameStart
            // 
            this.bGameStart.Location = new System.Drawing.Point(12, 12);
            this.bGameStart.Name = "bGameStart";
            this.bGameStart.Size = new System.Drawing.Size(108, 63);
            this.bGameStart.TabIndex = 0;
            this.bGameStart.Text = "Game";
            this.bGameStart.UseVisualStyleBackColor = true;
            // 
            // bChangeDesk
            // 
            this.bChangeDesk.Location = new System.Drawing.Point(126, 13);
            this.bChangeDesk.Name = "bChangeDesk";
            this.bChangeDesk.Size = new System.Drawing.Size(108, 62);
            this.bChangeDesk.TabIndex = 1;
            this.bChangeDesk.Text = "Правка карт";
            this.bChangeDesk.UseVisualStyleBackColor = true;
            // 
            // pbTest
            // 
            this.pbTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTest.Location = new System.Drawing.Point(19, 119);
            this.pbTest.Name = "pbTest";
            this.pbTest.Size = new System.Drawing.Size(215, 162);
            this.pbTest.TabIndex = 2;
            this.pbTest.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 325);
            this.Controls.Add(this.pbTest);
            this.Controls.Add(this.bChangeDesk);
            this.Controls.Add(this.bGameStart);
            this.Name = "MainForm";
            this.Text = "GameForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bGameStart;
        private System.Windows.Forms.Button bChangeDesk;
        private System.Windows.Forms.PictureBox pbTest;
    }
}
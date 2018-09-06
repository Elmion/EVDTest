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
            this.bTests = new System.Windows.Forms.Button();
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
            this.bGameStart.Click += new System.EventHandler(this.bGameStart_Click);
            // 
            // bChangeDesk
            // 
            this.bChangeDesk.Location = new System.Drawing.Point(126, 13);
            this.bChangeDesk.Name = "bChangeDesk";
            this.bChangeDesk.Size = new System.Drawing.Size(108, 62);
            this.bChangeDesk.TabIndex = 1;
            this.bChangeDesk.Text = "Каталог";
            this.bChangeDesk.UseVisualStyleBackColor = true;
            this.bChangeDesk.Click += new System.EventHandler(this.bChangeDesk_Click);
            // 
            // bTests
            // 
            this.bTests.Location = new System.Drawing.Point(12, 86);
            this.bTests.Name = "bTests";
            this.bTests.Size = new System.Drawing.Size(108, 63);
            this.bTests.TabIndex = 0;
            this.bTests.Text = "Тесты";
            this.bTests.UseVisualStyleBackColor = true;
            this.bTests.Click += new System.EventHandler(this.bTests_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 161);
            this.Controls.Add(this.bChangeDesk);
            this.Controls.Add(this.bTests);
            this.Controls.Add(this.bGameStart);
            this.Name = "MainForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bGameStart;
        private System.Windows.Forms.Button bChangeDesk;
        private System.Windows.Forms.Button bTests;
    }
}
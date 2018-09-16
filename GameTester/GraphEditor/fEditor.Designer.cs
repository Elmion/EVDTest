namespace GraphEditor
{
    partial class fEditor
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
            this.scGroups = new System.Windows.Forms.SplitContainer();
            this.scWorkArea = new System.Windows.Forms.SplitContainer();
            this.ucCanvas1 = new GraphEditor.ucCanvas();
            ((System.ComponentModel.ISupportInitialize)(this.scGroups)).BeginInit();
            this.scGroups.Panel2.SuspendLayout();
            this.scGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scWorkArea)).BeginInit();
            this.scWorkArea.Panel2.SuspendLayout();
            this.scWorkArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // scGroups
            // 
            this.scGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scGroups.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scGroups.Location = new System.Drawing.Point(0, 0);
            this.scGroups.Name = "scGroups";
            this.scGroups.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scGroups.Panel2
            // 
            this.scGroups.Panel2.Controls.Add(this.scWorkArea);
            this.scGroups.Size = new System.Drawing.Size(1010, 567);
            this.scGroups.SplitterDistance = 37;
            this.scGroups.TabIndex = 0;
            // 
            // scWorkArea
            // 
            this.scWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scWorkArea.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scWorkArea.Location = new System.Drawing.Point(0, 0);
            this.scWorkArea.Name = "scWorkArea";
            // 
            // scWorkArea.Panel2
            // 
            this.scWorkArea.Panel2.AutoScroll = true;
            this.scWorkArea.Panel2.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.scWorkArea.Panel2.Controls.Add(this.ucCanvas1);
            this.scWorkArea.Size = new System.Drawing.Size(1010, 526);
            this.scWorkArea.SplitterDistance = 153;
            this.scWorkArea.TabIndex = 0;
            // 
            // ucCanvas1
            // 
            this.ucCanvas1.BackColor = System.Drawing.SystemColors.Control;
            this.ucCanvas1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucCanvas1.Location = new System.Drawing.Point(0, 0);
            this.ucCanvas1.Name = "ucCanvas1";
            this.ucCanvas1.Size = new System.Drawing.Size(818, 487);
            this.ucCanvas1.TabIndex = 0;
            // 
            // fEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 567);
            this.Controls.Add(this.scGroups);
            this.Name = "fEditor";
            this.Text = "Editor";
            this.scGroups.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scGroups)).EndInit();
            this.scGroups.ResumeLayout(false);
            this.scWorkArea.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scWorkArea)).EndInit();
            this.scWorkArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scGroups;
        private System.Windows.Forms.SplitContainer scWorkArea;
        private ucCanvas ucCanvas1;
    }
}
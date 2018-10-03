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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEditor));
            this.scGroups = new System.Windows.Forms.SplitContainer();
            this.pCommonPanel = new System.Windows.Forms.Panel();
            this.scWorkArea = new System.Windows.Forms.SplitContainer();
            this.pBlocksPanel = new System.Windows.Forms.Panel();
            this.lComponents = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ucCanvas1 = new GraphEditor.ucCanvas();
            ((System.ComponentModel.ISupportInitialize)(this.scGroups)).BeginInit();
            this.scGroups.Panel1.SuspendLayout();
            this.scGroups.Panel2.SuspendLayout();
            this.scGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scWorkArea)).BeginInit();
            this.scWorkArea.Panel1.SuspendLayout();
            this.scWorkArea.Panel2.SuspendLayout();
            this.scWorkArea.SuspendLayout();
            this.pBlocksPanel.SuspendLayout();
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
            // scGroups.Panel1
            // 
            this.scGroups.Panel1.Controls.Add(this.pCommonPanel);
            // 
            // scGroups.Panel2
            // 
            this.scGroups.Panel2.Controls.Add(this.scWorkArea);
            this.scGroups.Size = new System.Drawing.Size(1010, 567);
            this.scGroups.SplitterDistance = 37;
            this.scGroups.TabIndex = 0;
            // 
            // pCommonPanel
            // 
            this.pCommonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCommonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCommonPanel.Location = new System.Drawing.Point(0, 0);
            this.pCommonPanel.Name = "pCommonPanel";
            this.pCommonPanel.Size = new System.Drawing.Size(1010, 37);
            this.pCommonPanel.TabIndex = 0;
            // 
            // scWorkArea
            // 
            this.scWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scWorkArea.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scWorkArea.Location = new System.Drawing.Point(0, 0);
            this.scWorkArea.Name = "scWorkArea";
            // 
            // scWorkArea.Panel1
            // 
            this.scWorkArea.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.scWorkArea.Panel1.Controls.Add(this.pBlocksPanel);
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
            // pBlocksPanel
            // 
            this.pBlocksPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBlocksPanel.Controls.Add(this.lComponents);
            this.pBlocksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBlocksPanel.Location = new System.Drawing.Point(0, 0);
            this.pBlocksPanel.Name = "pBlocksPanel";
            this.pBlocksPanel.Size = new System.Drawing.Size(153, 526);
            this.pBlocksPanel.TabIndex = 0;
            // 
            // lComponents
            // 
            this.lComponents.LargeImageList = this.imageList1;
            this.lComponents.Location = new System.Drawing.Point(3, 3);
            this.lComponents.Name = "lComponents";
            this.lComponents.ShowGroups = false;
            this.lComponents.Size = new System.Drawing.Size(145, 518);
            this.lComponents.SmallImageList = this.imageList1;
            this.lComponents.TabIndex = 1;
            this.lComponents.UseCompatibleStateImageBehavior = false;
            this.lComponents.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lComponents_ItemDrag);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Monk.PNG");
            this.imageList1.Images.SetKeyName(1, "ninja.PNG");
            this.imageList1.Images.SetKeyName(2, "Warrior.PNG");
            // 
            // ucCanvas1
            // 
            this.ucCanvas1.AllowDrop = true;
            this.ucCanvas1.BackColor = System.Drawing.SystemColors.Control;
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
            this.scGroups.Panel1.ResumeLayout(false);
            this.scGroups.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scGroups)).EndInit();
            this.scGroups.ResumeLayout(false);
            this.scWorkArea.Panel1.ResumeLayout(false);
            this.scWorkArea.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scWorkArea)).EndInit();
            this.scWorkArea.ResumeLayout(false);
            this.pBlocksPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scGroups;
        private System.Windows.Forms.SplitContainer scWorkArea;
        private ucCanvas ucCanvas1;
        private System.Windows.Forms.Panel pCommonPanel;
        private System.Windows.Forms.Panel pBlocksPanel;
        private System.Windows.Forms.ListView lComponents;
        private System.Windows.Forms.ImageList imageList1;
    }
}
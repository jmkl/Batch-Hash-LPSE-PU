namespace Hash
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hapusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbl = new System.Windows.Forms.Button();
            this.flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(206, 254);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File";
            this.columnHeader1.Width = 500;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hapusToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 26);
            // 
            // hapusToolStripMenuItem
            // 
            this.hapusToolStripMenuItem.Name = "hapusToolStripMenuItem";
            this.hapusToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.hapusToolStripMenuItem.Text = "Hapus";
            this.hapusToolStripMenuItem.Click += new System.EventHandler(this.hapusToolStripMenuItem_Click);
            // 
            // tbl
            // 
            this.tbl.Location = new System.Drawing.Point(12, 272);
            this.tbl.Name = "tbl";
            this.tbl.Size = new System.Drawing.Size(206, 23);
            this.tbl.TabIndex = 1;
            this.tbl.Text = "Cek Hash";
            this.tbl.UseVisualStyleBackColor = true;
            this.tbl.Click += new System.EventHandler(this.tbl_Click);
            // 
            // flowlayout
            // 
            this.flowlayout.AutoScroll = true;
            this.flowlayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowlayout.Location = new System.Drawing.Point(224, 12);
            this.flowlayout.Name = "flowlayout";
            this.flowlayout.Size = new System.Drawing.Size(348, 254);
            this.flowlayout.TabIndex = 2;
            this.flowlayout.WrapContents = false;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(224, 272);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(346, 23);
            this.pb.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pb.TabIndex = 3;
            this.pb.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 307);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.flowlayout);
            this.Controls.Add(this.tbl);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Hash Cek Lelang PU";
            this.TopMost = true;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button tbl;
        private System.Windows.Forms.FlowLayoutPanel flowlayout;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hapusToolStripMenuItem;
        private System.Windows.Forms.ProgressBar pb;
    }
}


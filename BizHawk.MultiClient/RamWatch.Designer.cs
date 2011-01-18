﻿namespace BizHawk.MultiClient
{
    partial class RamWatch
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.autoLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWindowPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.newWatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editWatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeWatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateWatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.watchesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(375, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newListToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.appendFileToolStripMenuItem,
            this.recentToolStripMenuItem,
            this.toolStripSeparator1,
            this.autoLoadToolStripMenuItem,
            this.saveWindowPositionToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.filesToolStripMenuItem.Text = "&Files";
            // 
            // watchesToolStripMenuItem
            // 
            this.watchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWatchToolStripMenuItem,
            this.editWatchToolStripMenuItem,
            this.removeWatchToolStripMenuItem,
            this.duplicateWatchToolStripMenuItem,
            this.toolStripSeparator3,
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem});
            this.watchesToolStripMenuItem.Name = "watchesToolStripMenuItem";
            this.watchesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.watchesToolStripMenuItem.Text = "&Watches";
            // 
            // newListToolStripMenuItem
            // 
            this.newListToolStripMenuItem.Name = "newListToolStripMenuItem";
            this.newListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newListToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.newListToolStripMenuItem.Text = "&New List";
            this.newListToolStripMenuItem.Click += new System.EventHandler(this.newListToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // appendFileToolStripMenuItem
            // 
            this.appendFileToolStripMenuItem.Name = "appendFileToolStripMenuItem";
            this.appendFileToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.appendFileToolStripMenuItem.Text = "A&ppend File...";
            this.appendFileToolStripMenuItem.Click += new System.EventHandler(this.appendFileToolStripMenuItem_Click);
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.recentToolStripMenuItem.Text = "Recent";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // autoLoadToolStripMenuItem
            // 
            this.autoLoadToolStripMenuItem.Name = "autoLoadToolStripMenuItem";
            this.autoLoadToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.autoLoadToolStripMenuItem.Text = "Auto-Load";
            this.autoLoadToolStripMenuItem.Click += new System.EventHandler(this.autoLoadToolStripMenuItem_Click);
            // 
            // saveWindowPositionToolStripMenuItem
            // 
            this.saveWindowPositionToolStripMenuItem.Name = "saveWindowPositionToolStripMenuItem";
            this.saveWindowPositionToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.saveWindowPositionToolStripMenuItem.Text = "Save Window Position";
            this.saveWindowPositionToolStripMenuItem.Click += new System.EventHandler(this.saveWindowPositionToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.exitToolStripMenuItem.Text = "&Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(27, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(307, 360);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // newWatchToolStripMenuItem
            // 
            this.newWatchToolStripMenuItem.Name = "newWatchToolStripMenuItem";
            this.newWatchToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.newWatchToolStripMenuItem.Text = "&New Watch";
            this.newWatchToolStripMenuItem.Click += new System.EventHandler(this.newWatchToolStripMenuItem_Click);
            // 
            // editWatchToolStripMenuItem
            // 
            this.editWatchToolStripMenuItem.Name = "editWatchToolStripMenuItem";
            this.editWatchToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.editWatchToolStripMenuItem.Text = "&Edit Watch";
            this.editWatchToolStripMenuItem.Click += new System.EventHandler(this.editWatchToolStripMenuItem_Click);
            // 
            // removeWatchToolStripMenuItem
            // 
            this.removeWatchToolStripMenuItem.Name = "removeWatchToolStripMenuItem";
            this.removeWatchToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.removeWatchToolStripMenuItem.Text = "&Remove Watch";
            this.removeWatchToolStripMenuItem.Click += new System.EventHandler(this.removeWatchToolStripMenuItem_Click);
            // 
            // duplicateWatchToolStripMenuItem
            // 
            this.duplicateWatchToolStripMenuItem.Name = "duplicateWatchToolStripMenuItem";
            this.duplicateWatchToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.duplicateWatchToolStripMenuItem.Text = "&Duplicate Watch";
            this.duplicateWatchToolStripMenuItem.Click += new System.EventHandler(this.duplicateWatchToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(160, 6);
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.moveUpToolStripMenuItem.Text = "Move &Up";
            this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.moveUpToolStripMenuItem_Click);
            // 
            // moveDownToolStripMenuItem
            // 
            this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.moveDownToolStripMenuItem.Text = "Move &Down";
            this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.moveDownToolStripMenuItem_Click);
            // 
            // RamWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 422);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RamWatch";
            this.Text = "Ram Watch";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appendFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem autoLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWindowPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem newWatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editWatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeWatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateWatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
    }
}
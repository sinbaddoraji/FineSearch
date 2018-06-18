using System;
namespace FineSearch
{
    sealed partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fileSearchOption = new System.Windows.Forms.RadioButton();
            this.directorySearchOption = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.stopSearch = new System.Windows.Forms.Button();
            this.startSearch = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchStart = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useRegex = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.itemCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.Color.Black;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(-7, 80);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowLines = false;
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(579, 340);
            this.treeView1.TabIndex = 4;
            this.treeView1.DoubleClick += new System.EventHandler(this.TreeView1_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::FineSearch.Properties.Resources.dark_black_and_white_abstract_black_background_76353_1920x1080;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.searchStart);
            this.panel1.Controls.Add(this.useRegex);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 77);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.fileSearchOption);
            this.panel3.Controls.Add(this.directorySearchOption);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 31);
            this.panel3.TabIndex = 11;
            // 
            // fileSearchOption
            // 
            this.fileSearchOption.Appearance = System.Windows.Forms.Appearance.Button;
            this.fileSearchOption.AutoSize = true;
            this.fileSearchOption.Checked = true;
            this.fileSearchOption.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fileSearchOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileSearchOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSearchOption.ForeColor = System.Drawing.Color.White;
            this.fileSearchOption.Location = new System.Drawing.Point(0, 3);
            this.fileSearchOption.Name = "fileSearchOption";
            this.fileSearchOption.Size = new System.Drawing.Size(72, 25);
            this.fileSearchOption.TabIndex = 8;
            this.fileSearchOption.TabStop = true;
            this.fileSearchOption.Text = "File Search";
            this.fileSearchOption.UseVisualStyleBackColor = true;
            // 
            // directorySearchOption
            // 
            this.directorySearchOption.Appearance = System.Windows.Forms.Appearance.Button;
            this.directorySearchOption.AutoSize = true;
            this.directorySearchOption.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.directorySearchOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directorySearchOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorySearchOption.ForeColor = System.Drawing.Color.White;
            this.directorySearchOption.Location = new System.Drawing.Point(71, 3);
            this.directorySearchOption.Name = "directorySearchOption";
            this.directorySearchOption.Size = new System.Drawing.Size(98, 25);
            this.directorySearchOption.TabIndex = 7;
            this.directorySearchOption.Text = "Directory Search";
            this.directorySearchOption.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.clear);
            this.panel2.Controls.Add(this.stopSearch);
            this.panel2.Controls.Add(this.startSearch);
            this.panel2.Controls.Add(this.searchBox);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 31);
            this.panel2.TabIndex = 10;
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Image = global::FineSearch.Properties.Resources.clear;
            this.clear.Location = new System.Drawing.Point(546, -4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(22, 36);
            this.clear.TabIndex = 5;
            this.clear.Tag = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button3_Click);
            // 
            // stopSearch
            // 
            this.stopSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopSearch.FlatAppearance.BorderSize = 0;
            this.stopSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.stopSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopSearch.ForeColor = System.Drawing.Color.White;
            this.stopSearch.Location = new System.Drawing.Point(519, -6);
            this.stopSearch.Name = "stopSearch";
            this.stopSearch.Size = new System.Drawing.Size(26, 40);
            this.stopSearch.TabIndex = 3;
            this.stopSearch.Tag = "Stop";
            this.stopSearch.Text = "X";
            this.stopSearch.UseVisualStyleBackColor = true;
            this.stopSearch.Click += new System.EventHandler(this.Button2_Click);
            // 
            // startSearch
            // 
            this.startSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startSearch.FlatAppearance.BorderSize = 0;
            this.startSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.startSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startSearch.Image = ((System.Drawing.Image)(resources.GetObject("startSearch.Image")));
            this.startSearch.Location = new System.Drawing.Point(492, -6);
            this.startSearch.Name = "startSearch";
            this.startSearch.Size = new System.Drawing.Size(21, 40);
            this.startSearch.TabIndex = 1;
            this.startSearch.Tag = "Search";
            this.startSearch.UseVisualStyleBackColor = true;
            this.startSearch.Click += new System.EventHandler(this.Button1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.Color.Black;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.HideSelection = false;
            this.searchBox.Location = new System.Drawing.Point(0, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(484, 25);
            this.searchBox.TabIndex = 0;
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // searchStart
            // 
            this.searchStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchStart.BackColor = System.Drawing.Color.Black;
            this.searchStart.ContextMenuStrip = this.contextMenuStrip1;
            this.searchStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStart.ForeColor = System.Drawing.Color.White;
            this.searchStart.FormattingEnabled = true;
            this.searchStart.ItemHeight = 24;
            this.searchStart.Location = new System.Drawing.Point(182, 40);
            this.searchStart.Name = "searchStart";
            this.searchStart.Size = new System.Drawing.Size(302, 32);
            this.searchStart.Sorted = true;
            this.searchStart.TabIndex = 1;
            this.searchStart.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.searchStart_DrawItem);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFolderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 26);
            // 
            // addFolderToolStripMenuItem
            // 
            this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
            this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.addFolderToolStripMenuItem.Text = "Add folder";
            this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
            // 
            // useRegex
            // 
            this.useRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.useRegex.AutoSize = true;
            this.useRegex.BackColor = System.Drawing.Color.Transparent;
            this.useRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useRegex.ForeColor = System.Drawing.Color.White;
            this.useRegex.Location = new System.Drawing.Point(492, 44);
            this.useRegex.Name = "useRegex";
            this.useRegex.Size = new System.Drawing.Size(74, 24);
            this.useRegex.TabIndex = 9;
            this.useRegex.Text = "Regex";
            this.useRegex.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(570, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // itemCount
            // 
            this.itemCount.ForeColor = System.Drawing.Color.White;
            this.itemCount.Name = "itemCount";
            this.itemCount.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(570, 445);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "FineSearch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button startSearch;
        private System.Windows.Forms.Button stopSearch;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ComboBox searchStart;
        private System.Windows.Forms.RadioButton directorySearchOption;
        private System.Windows.Forms.RadioButton fileSearchOption;
        private System.Windows.Forms.CheckBox useRegex;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel itemCount;
    }
}


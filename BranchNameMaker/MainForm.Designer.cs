namespace BranchNameMaker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblClipboard = new System.Windows.Forms.Label();
            this.LblClipboardView = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLock = new FontAwesome.Sharp.IconButton();
            this.BtnCommitFormat = new FontAwesome.Sharp.IconButton();
            this.BtnBranchFormat = new FontAwesome.Sharp.IconButton();
            this.LblBranchView = new System.Windows.Forms.Label();
            this.LblBranchFormat = new System.Windows.Forms.Label();
            this.LblCommitView = new System.Windows.Forms.Label();
            this.LblCommitFormat = new System.Windows.Forms.Label();
            this.Txtbox_branchFolder = new System.Windows.Forms.TextBox();
            this.Txtbox_prefix = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblClipboard
            // 
            this.LblClipboard.AutoSize = true;
            this.LblClipboard.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblClipboard.ForeColor = System.Drawing.Color.LightYellow;
            this.LblClipboard.Location = new System.Drawing.Point(12, 9);
            this.LblClipboard.Name = "LblClipboard";
            this.LblClipboard.Size = new System.Drawing.Size(110, 21);
            this.LblClipboard.TabIndex = 5;
            this.LblClipboard.Text = "Clipboard:";
            // 
            // LblClipboardView
            // 
            this.LblClipboardView.AutoSize = true;
            this.LblClipboardView.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblClipboardView.ForeColor = System.Drawing.Color.LightYellow;
            this.LblClipboardView.Location = new System.Drawing.Point(12, 34);
            this.LblClipboardView.Name = "LblClipboardView";
            this.LblClipboardView.Size = new System.Drawing.Size(380, 21);
            this.LblClipboardView.TabIndex = 6;
            this.LblClipboardView.Text = "User Story: 544410 Esto es un ejemplo";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.BtnLock);
            this.panel1.Controls.Add(this.BtnCommitFormat);
            this.panel1.Controls.Add(this.BtnBranchFormat);
            this.panel1.Location = new System.Drawing.Point(12, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 68);
            this.panel1.TabIndex = 9;
            // 
            // BtnLock
            // 
            this.BtnLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLock.BackColor = System.Drawing.Color.LightYellow;
            this.BtnLock.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.BtnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLock.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnLock.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.BtnLock.IconColor = System.Drawing.Color.LimeGreen;
            this.BtnLock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLock.IconSize = 30;
            this.BtnLock.Location = new System.Drawing.Point(747, 14);
            this.BtnLock.Name = "BtnLock";
            this.BtnLock.Size = new System.Drawing.Size(142, 40);
            this.BtnLock.TabIndex = 16;
            this.BtnLock.UseVisualStyleBackColor = false;
            this.BtnLock.Click += new System.EventHandler(this.BtnLock_Click);
            // 
            // BtnCommitFormat
            // 
            this.BtnCommitFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCommitFormat.BackColor = System.Drawing.Color.LightYellow;
            this.BtnCommitFormat.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.BtnCommitFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCommitFormat.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCommitFormat.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.BtnCommitFormat.IconColor = System.Drawing.Color.Black;
            this.BtnCommitFormat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCommitFormat.IconSize = 30;
            this.BtnCommitFormat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCommitFormat.Location = new System.Drawing.Point(53, 14);
            this.BtnCommitFormat.Name = "BtnCommitFormat";
            this.BtnCommitFormat.Size = new System.Drawing.Size(290, 40);
            this.BtnCommitFormat.TabIndex = 15;
            this.BtnCommitFormat.Text = "Commit Format";
            this.BtnCommitFormat.UseVisualStyleBackColor = false;
            this.BtnCommitFormat.Click += new System.EventHandler(this.BtnCommitFormat_Click);
            // 
            // BtnBranchFormat
            // 
            this.BtnBranchFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBranchFormat.BackColor = System.Drawing.Color.LightYellow;
            this.BtnBranchFormat.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.BtnBranchFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBranchFormat.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBranchFormat.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.BtnBranchFormat.IconColor = System.Drawing.Color.Black;
            this.BtnBranchFormat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBranchFormat.IconSize = 30;
            this.BtnBranchFormat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBranchFormat.Location = new System.Drawing.Point(384, 14);
            this.BtnBranchFormat.Name = "BtnBranchFormat";
            this.BtnBranchFormat.Size = new System.Drawing.Size(290, 40);
            this.BtnBranchFormat.TabIndex = 14;
            this.BtnBranchFormat.Text = "Branch Format";
            this.BtnBranchFormat.UseVisualStyleBackColor = false;
            this.BtnBranchFormat.Click += new System.EventHandler(this.BtnBranchFormat_Click);
            // 
            // LblBranchView
            // 
            this.LblBranchView.AutoSize = true;
            this.LblBranchView.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBranchView.ForeColor = System.Drawing.Color.LightYellow;
            this.LblBranchView.Location = new System.Drawing.Point(12, 140);
            this.LblBranchView.Name = "LblBranchView";
            this.LblBranchView.Size = new System.Drawing.Size(150, 21);
            this.LblBranchView.TabIndex = 11;
            this.LblBranchView.Text = "Sin Resultados";
            // 
            // LblBranchFormat
            // 
            this.LblBranchFormat.AutoSize = true;
            this.LblBranchFormat.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBranchFormat.ForeColor = System.Drawing.Color.LightYellow;
            this.LblBranchFormat.Location = new System.Drawing.Point(12, 115);
            this.LblBranchFormat.Name = "LblBranchFormat";
            this.LblBranchFormat.Size = new System.Drawing.Size(150, 21);
            this.LblBranchFormat.TabIndex = 10;
            this.LblBranchFormat.Text = "Branch Format:";
            // 
            // LblCommitView
            // 
            this.LblCommitView.AutoSize = true;
            this.LblCommitView.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCommitView.ForeColor = System.Drawing.Color.LightYellow;
            this.LblCommitView.Location = new System.Drawing.Point(12, 261);
            this.LblCommitView.Name = "LblCommitView";
            this.LblCommitView.Size = new System.Drawing.Size(150, 21);
            this.LblCommitView.TabIndex = 13;
            this.LblCommitView.Text = "Sin Resultados";
            // 
            // LblCommitFormat
            // 
            this.LblCommitFormat.AutoSize = true;
            this.LblCommitFormat.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCommitFormat.ForeColor = System.Drawing.Color.LightYellow;
            this.LblCommitFormat.Location = new System.Drawing.Point(12, 236);
            this.LblCommitFormat.Name = "LblCommitFormat";
            this.LblCommitFormat.Size = new System.Drawing.Size(150, 21);
            this.LblCommitFormat.TabIndex = 12;
            this.LblCommitFormat.Text = "Commit Format:";
            // 
            // Txtbox_branchFolder
            // 
            this.Txtbox_branchFolder.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Txtbox_branchFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtbox_branchFolder.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txtbox_branchFolder.Location = new System.Drawing.Point(17, 86);
            this.Txtbox_branchFolder.Name = "Txtbox_branchFolder";
            this.Txtbox_branchFolder.PlaceholderText = "Branch Folder";
            this.Txtbox_branchFolder.Size = new System.Drawing.Size(100, 23);
            this.Txtbox_branchFolder.TabIndex = 14;
            // 
            // Txtbox_prefix
            // 
            this.Txtbox_prefix.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Txtbox_prefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtbox_prefix.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txtbox_prefix.Location = new System.Drawing.Point(17, 210);
            this.Txtbox_prefix.Name = "Txtbox_prefix";
            this.Txtbox_prefix.Size = new System.Drawing.Size(100, 23);
            this.Txtbox_prefix.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(977, 397);
            this.Controls.Add(this.Txtbox_prefix);
            this.Controls.Add(this.Txtbox_branchFolder);
            this.Controls.Add(this.LblCommitView);
            this.Controls.Add(this.LblCommitFormat);
            this.Controls.Add(this.LblBranchView);
            this.Controls.Add(this.LblBranchFormat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblClipboardView);
            this.Controls.Add(this.LblClipboard);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(16, 391);
            this.Name = "MainForm";
            this.Text = "RamaMaker";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDoubleClick);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblClipboard;
        private System.Windows.Forms.Label LblClipboardView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblBranchView;
        private System.Windows.Forms.Label LblBranchFormat;
        private System.Windows.Forms.Label LblCommitView;
        private System.Windows.Forms.Label LblCommitFormat;
        private FontAwesome.Sharp.IconButton BtnCommitFormat;
        private FontAwesome.Sharp.IconButton BtnBranchFormat;
        private FontAwesome.Sharp.IconButton BtnLock;
        private System.Windows.Forms.TextBox Txtbox_branchFolder;
        private System.Windows.Forms.TextBox Txtbox_prefix;
    }
}

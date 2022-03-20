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
            this.BtnPower = new FontAwesome.Sharp.IconButton();
            this.BtnCommitFormat = new FontAwesome.Sharp.IconButton();
            this.BtnBranchFormat = new FontAwesome.Sharp.IconButton();
            this.LblBranchView = new System.Windows.Forms.Label();
            this.LblBranchFormat = new System.Windows.Forms.Label();
            this.LblCommitView = new System.Windows.Forms.Label();
            this.LblCommitFormat = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblClipboard
            // 
            this.LblClipboard.AutoSize = true;
            this.LblClipboard.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblClipboard.ForeColor = System.Drawing.Color.LightYellow;
            this.LblClipboard.Location = new System.Drawing.Point(12, 22);
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
            this.LblClipboardView.Location = new System.Drawing.Point(12, 47);
            this.LblClipboardView.Name = "LblClipboardView";
            this.LblClipboardView.Size = new System.Drawing.Size(360, 21);
            this.LblClipboardView.TabIndex = 6;
            this.LblClipboardView.Text = "User Story: 544410 Tu mama en tanga";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.BtnPower);
            this.panel1.Controls.Add(this.BtnCommitFormat);
            this.panel1.Controls.Add(this.BtnBranchFormat);
            this.panel1.Location = new System.Drawing.Point(12, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 69);
            this.panel1.TabIndex = 9;
            // 
            // BtnPower
            // 
            this.BtnPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPower.BackColor = System.Drawing.Color.LightYellow;
            this.BtnPower.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.BtnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPower.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPower.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnPower.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.BtnPower.IconColor = System.Drawing.Color.LimeGreen;
            this.BtnPower.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPower.IconSize = 30;
            this.BtnPower.Location = new System.Drawing.Point(608, 14);
            this.BtnPower.Name = "BtnPower";
            this.BtnPower.Size = new System.Drawing.Size(48, 40);
            this.BtnPower.TabIndex = 16;
            this.BtnPower.UseVisualStyleBackColor = false;
            this.BtnPower.Click += new System.EventHandler(this.BtnPower_Click);
            // 
            // BtnCommitFormat
            // 
            this.BtnCommitFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCommitFormat.BackColor = System.Drawing.Color.LightYellow;
            this.BtnCommitFormat.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.BtnCommitFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCommitFormat.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCommitFormat.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.BtnCommitFormat.IconColor = System.Drawing.Color.Black;
            this.BtnCommitFormat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCommitFormat.IconSize = 30;
            this.BtnCommitFormat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCommitFormat.Location = new System.Drawing.Point(85, 14);
            this.BtnCommitFormat.Name = "BtnCommitFormat";
            this.BtnCommitFormat.Size = new System.Drawing.Size(170, 40);
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
            this.BtnBranchFormat.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.BtnBranchFormat.IconColor = System.Drawing.Color.Black;
            this.BtnBranchFormat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBranchFormat.IconSize = 30;
            this.BtnBranchFormat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBranchFormat.Location = new System.Drawing.Point(344, 14);
            this.BtnBranchFormat.Name = "BtnBranchFormat";
            this.BtnBranchFormat.Size = new System.Drawing.Size(170, 40);
            this.BtnBranchFormat.TabIndex = 14;
            this.BtnBranchFormat.Text = "Branch Format";
            this.BtnBranchFormat.UseVisualStyleBackColor = false;
            this.BtnBranchFormat.Click += new System.EventHandler(this.BtnBranchFormat_Click_1);
            // 
            // LblBranchView
            // 
            this.LblBranchView.AutoSize = true;
            this.LblBranchView.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBranchView.ForeColor = System.Drawing.Color.LightYellow;
            this.LblBranchView.Location = new System.Drawing.Point(12, 129);
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
            this.LblBranchFormat.Location = new System.Drawing.Point(12, 104);
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
            this.LblCommitView.Location = new System.Drawing.Point(12, 210);
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
            this.LblCommitFormat.Location = new System.Drawing.Point(12, 185);
            this.LblCommitFormat.Name = "LblCommitFormat";
            this.LblCommitFormat.Size = new System.Drawing.Size(150, 21);
            this.LblCommitFormat.TabIndex = 12;
            this.LblCommitFormat.Text = "Commit Format:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(700, 352);
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
            this.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
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
        private FontAwesome.Sharp.IconButton BtnPower;
    }
}

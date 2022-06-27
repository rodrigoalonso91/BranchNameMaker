using System;
using System.Drawing;
using System.Windows.Forms;

namespace BranchNameMaker
{
    public partial class MainForm : Form
    {
        private static bool IsLockOpen = true;

        public MainForm()
        {
            InitializeComponent();
            GetResults();
        }

        private void GetResults()
        {

            LblClipboardView.Text = Clipboard.GetText();
            if (string.IsNullOrEmpty(LblClipboardView.Text))
            {
                MessageBox.Show("Clipboard vacio...", "RamaMaker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clipboard.SetText("Clipboard vacio...");
            }
            var formatBuilder = new FormatBuilder(Txtbox_branchFolder.Text, Txtbox_prefix.Text);
            LblBranchView.Text = formatBuilder.GetFormat(LblClipboardView.Text);
            LblCommitView.Text = formatBuilder.GetFormat(LblClipboardView.Text, CommitMode: true);
        }

        private void BtnBranchFormat_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LblBranchView.Text);
        }

        private void BtnCommitFormat_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LblCommitView.Text);
        }

        private void BtnLock_Click(object sender, EventArgs e)
        {
            IsLockOpen = !IsLockOpen;
            BtnLock.IconColor = IsLockOpen ? Color.LimeGreen : Color.OrangeRed;
            BtnLock.IconChar = IsLockOpen ? FontAwesome.Sharp.IconChar.LockOpen : FontAwesome.Sharp.IconChar.Lock;
        }

        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (IsLockOpen)
            {
                var clipboardText = Clipboard.GetText();
                if (clipboardText == LblCommitView.Text || clipboardText == LblBranchView.Text) return;
                GetResults();
            }
        }
    }
}
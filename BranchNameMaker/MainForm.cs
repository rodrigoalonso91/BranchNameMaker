using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BranchNameMaker
{
    public partial class MainForm : Form
    {
        private static bool PowerOn = false;
        private static bool WarnedUser = false;
        public MainForm()
        {
            InitializeComponent();
            GetResults();
        }

        private void GetResults()
        {
            if (WarnedUser) return;
            LblClipboardView.Text = Clipboard.GetText();
            if (string.IsNullOrEmpty(LblClipboardView.Text))
            {
                MessageBox.Show("Clipboard vacio...", "RamaMaker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                WarnedUser = true;
                return;
            }
            WarnedUser = false;
            var formatBuilder = new FormatBuilder();
            LblBranchView.Text = formatBuilder.GetFormat(LblClipboardView.Text);
            LblCommitView.Text = formatBuilder.GetFormat(LblClipboardView.Text, CommitMode: true);
        }

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            if (PowerOn)
            {
                var clipboardText = Clipboard.GetText();
                if (clipboardText == LblCommitView.Text || clipboardText == LblBranchView.Text) return;
                GetResults();
            }
        }

        private void BtnBranchFormat_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(LblBranchView.Text);
        }

        private void BtnCommitFormat_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LblCommitView.Text);
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            PowerOn = !PowerOn;
            BtnPower.IconColor = PowerOn ? Color.OrangeRed : Color.LimeGreen;
        }
    }
}

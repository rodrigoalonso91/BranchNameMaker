using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BranchNameMaker
{
    public class FormatBuilder
    {
        private void RemoveStringBuilderSymbols(StringBuilder sb)
        {
            string patron = @"[^\w]";
            Regex regex = new Regex(patron);
            for (int i = 0; i < sb.Length; i++)
            {
                if (char.IsWhiteSpace(sb[i]) || sb[i].Equals('-')) continue;
                if (regex.IsMatch(sb[i].ToString())) sb.Remove(i, 1);
            }
        }

        private int SetFistNumbreIndex(StringBuilder sb)
        {
            for (int i = 0; i < sb.Length; i++)
            {
                var currentChar = sb[i].ToString();
                if (int.TryParse(currentChar.ToString(), out int result)) return i;
            }
            return 0;
        }

        public string GetFormat(string text, bool CommitMode = false)
        {
            var sb = new StringBuilder(text);
            var firstNumberIndex = SetFistNumbreIndex(sb);
            sb.Remove(0, firstNumberIndex);
            RemoveStringBuilderSymbols(sb);

            if (CommitMode) sb.Replace("-", " ");
            else sb.Replace(' ', '-');

            sb.Insert(0, '#');

            return sb.ToString();
        }
    }
}

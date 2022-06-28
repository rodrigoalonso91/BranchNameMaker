using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace BranchNameMaker
{
    public class FormatBuilder
    {
        private readonly string Folder;

        public FormatBuilder(string folder)
        {
            Folder = folder;
        }

        private static void RemoveStringBuilderSymbols(StringBuilder sb)
        {
            const string patron = @"[^\w]";
            Regex regex = new Regex(patron);
            for (int i = 0; i < sb.Length; i++)
            {
                if (char.IsWhiteSpace(sb[i]) || sb[i].Equals('-')) continue;
                if (regex.IsMatch(sb[i].ToString())) sb.Remove(i, 1);
            }
        }

        private static int SetFistNumbreIndex(StringBuilder sb)
        {
            for (int i = 0; i < sb.Length; i++)
            {
                var currentChar = sb[i].ToString();
                if (int.TryParse(currentChar, out _)) return i;
            }
            return 0;
        }

        public string GetFormat(string text, bool CommitMode = false)
        {
            var sb = new StringBuilder(text);
            var firstNumberIndex = SetFistNumbreIndex(sb);
            sb.Remove(0, firstNumberIndex);
            RemoveStringBuilderSymbols(sb);

            if (CommitMode)
            {
                sb.Replace("-", " ").Insert(0, '#');
                return sb.ToString();
            }
            else
            {
                sb.Replace(' ', '-');
                return Path.Combine(Folder, sb.ToString());
            }
        }
    }
}
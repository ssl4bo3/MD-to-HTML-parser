using System.Text.RegularExpressions;

namespace LR4
{
    abstract class General
    {
        protected abstract string Pattern { get; }
        protected virtual MatchCollection GetContains(string line)
        {
            Regex rgx = new Regex(Pattern);
            return rgx.Matches(line);
        }
        public virtual string ReplaceMarkDown(string line)
        {
            string formatedLine = line;
            MatchCollection matches = GetContains(line);
            foreach (Match match in matches)
            {
                formatedLine = formatedLine.Replace(match.Value, GetHtml(match.Value));
            }
            return formatedLine;
        }
        protected abstract string GetHtml(string text);
    }
}
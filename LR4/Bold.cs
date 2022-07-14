namespace LR4
{
    class Bold : General
    {
        protected override string Pattern => @"\*\*[^\*\n]+\*\*|__[^_\n]+__";

        protected override string GetHtml(string text)
        {
            text = text.Replace("**", string.Empty);
            text = text.Replace("__", string.Empty);
            return $"<b>{text}</b>";
        }
    }
}
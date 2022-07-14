namespace LR4
{
    class BoldItalics : General
    {
        protected override string Pattern => @"\*\*\*[^\*\n]+\*\*\*";

        protected override string GetHtml(string text)
        {
            text = text.Replace("***", string.Empty);
            return $"<b><i>{text}</b></i>";
        }
    }
}
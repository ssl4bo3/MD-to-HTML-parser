namespace LR4
{
    class Quote : General
    {
        protected override string Pattern => @"(?<=\n|^)> .+(?=\n|$)";

        protected override string GetHtml(string text)
        {
            text = text.Replace(">", string.Empty);
            return $"<blockquote>{text}</blockquote>";
        }
    }
}
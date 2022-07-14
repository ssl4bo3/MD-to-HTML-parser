namespace LR4
{
    class H2Token : General
    {
        protected override string Pattern => @"(?<=\n|^)## .+(?=\n|$)";

        protected override string GetHtml(string text)
        {
            text = text.Replace("##", string.Empty);
            return $"<h2>{text}</h2>";
        }
    }
}
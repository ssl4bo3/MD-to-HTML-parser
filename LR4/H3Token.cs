namespace LR4
{
    class H3Token : General
    {
        protected override string Pattern => @"(?<=\n|^)### .+(?=\n|$)";

        protected override string GetHtml(string text)
        {
            text = text.Replace("###", string.Empty);
            return $"<h3>{text}</h3>";
        }
    }
}
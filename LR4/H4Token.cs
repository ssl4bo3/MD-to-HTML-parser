namespace LR4
{
    class H4Token : General
    {
        protected override string Pattern => @"(?<=\n|^)#### .+(?=\n|$)";

        protected override string GetHtml(string text)
        {
            text = text.Replace("####", string.Empty);
            return $"<h4>{text}</h4>";
        }
    }
}
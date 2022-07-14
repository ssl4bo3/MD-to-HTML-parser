namespace LR4
{
    class H1Token : General
    {
        protected override string Pattern => @"(?<=\n|^)# .+(?=\n|$)";

        protected override string GetHtml(string text)
        {
            text = text.Replace("#", string.Empty);
            return $"<h1>{text}</h1>";
        }
    }
}
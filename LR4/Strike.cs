namespace LR4
{
    class Strike : General
    {
        protected override string Pattern => @"~[^~\n]+~";

        protected override string GetHtml(string text)
        {
            text = text.Replace("~", string.Empty);
            return $"<s>{text}</s>";
        }
    }
}
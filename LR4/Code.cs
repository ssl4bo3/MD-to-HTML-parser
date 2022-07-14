namespace LR4
{
    class Code : General
    {
        protected override string Pattern => @"```[^`]+```";

        protected override string GetHtml(string text)
        {
            text = text.Replace("```", string.Empty);
            return $"<code>{text}</code>";
        }
    }
}
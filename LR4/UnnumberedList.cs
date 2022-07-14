namespace LR4
{
    class UnnumberedList : General
    {
        protected override string Pattern => @"(?<=\n|^)\*[^\*\n]+|(?<=\n|^)\+[^\+\n]+|(?<=\n|^)-[^-\n]+";

        protected override string GetHtml(string text)
        {
            text = text.Replace("*", string.Empty);
            text = text.Replace("+", string.Empty);
            text = text.Replace("-", string.Empty);
            return $"<li>{text}</li>";
        }
    }
}
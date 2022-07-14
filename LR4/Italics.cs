namespace LR4
{
    class Italics : General
    {
        protected override string Pattern => @"(?<!^|\*|\n)\*[^\*\n]+\*(?!\*)|(?<!^|_|\n)_[^_\n]+_(?!_)";

        protected override string GetHtml(string text)
        {
            text = text.Replace("*", string.Empty);
            text = text.Replace("_", string.Empty);
            return $"<i>{text}</i>";
        }
    }
}
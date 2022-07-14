namespace LR4
{
    class Paragraph : General
    {
        protected override string Pattern => @"(?<=\n|^)((?![#>\-\+\|*]).+\n)+(?!=\n)+";

        protected override string GetHtml(string text)
        {
            text = text.Replace("\n", string.Empty);
            return $"<p>{text}</p>";
        }
    }
}
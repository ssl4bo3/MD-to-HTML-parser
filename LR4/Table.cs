namespace LR4
{
    class Table : General
    {
        protected override string Pattern => @"\|+[^\d]+\|";

        protected override string GetHtml(string text)
        {
            text = text.Replace("|", "<td>");
            return $"<table>\n{text}\n</table>";
        }
    }
}
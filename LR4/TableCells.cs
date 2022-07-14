namespace LR4
{
    class TableCells : General
    {
        protected override string Pattern => @"(?<!\n|^)<td> .+(?=\n|$)";

        protected override string GetHtml(string text)
        {
            text = text.Replace("<td>", "</td><td>");
            return text;
            //return text.Substring(0, text.Length - 4);
        }
    }
}
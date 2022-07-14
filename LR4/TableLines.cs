namespace LR4
{
    class TableLines : General
    {
        protected override string Pattern => @"(?<=\n|^)<td> .+(?=\n|$)";

        protected override string GetHtml(string text)
        {
            return $"<tr>{text}</tr>";
        }
    }
}
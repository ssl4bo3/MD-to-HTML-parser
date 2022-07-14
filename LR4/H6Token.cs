namespace LR4
{
    class H6Token : General
    {
        protected override string Pattern => @"(?<=\n|^)###### .+(?=\n|$)";

        protected override string GetHtml(string text)
        {
            text = text.Replace("######", string.Empty);
            return $"<h6>{text}</h6>";
        }
    }
}
namespace LR4
{
    class H5Token : General
    {
        protected override string Pattern => @"(?<=\n|^)##### .+(?=\n|$)";

        protected override string GetHtml(string text)
        {
            text = text.Replace("#####", string.Empty);
            return $"<h5>{text}</h5>";
        }
    }
}
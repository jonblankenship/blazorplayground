namespace RenderMarkdown.App.Utilities
{
    public class HtmlSanitizer: IHtmlSanitizer
    {
        private readonly Ganss.XSS.HtmlSanitizer _sanitizer;

        public HtmlSanitizer()
        {
            // Configure sanitizer rules as needed here.
            // For now, just use default rules + allow class attributes
            _sanitizer = new Ganss.XSS.HtmlSanitizer();
            _sanitizer.AllowedAttributes.Add("class");
        }

        public string Sanitize(string html) => _sanitizer.Sanitize(html);
    }
}
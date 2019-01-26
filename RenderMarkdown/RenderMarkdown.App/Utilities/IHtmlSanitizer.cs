using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenderMarkdown.App.Utilities
{
    public interface IHtmlSanitizer
    {
        string Sanitize(string html);
    }
}

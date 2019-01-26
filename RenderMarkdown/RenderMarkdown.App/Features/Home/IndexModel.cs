using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Blazor.Components;

namespace RenderMarkdown.App.Features.Home
{
    public class IndexModel: BlazorComponent
    {
        public string Title => "Render Markdown";

        public string MarkdownContent { get; set; }

        protected override void OnInit()
        {
            MarkdownContent = GetInitialMarkdown();
        }

        private string GetInitialMarkdown()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = assembly.GetManifestResourceNames().Single(x => x.EndsWith("InitialMarkdown.md"));

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
        }
    }
}

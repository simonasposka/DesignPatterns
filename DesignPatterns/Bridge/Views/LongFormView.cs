using System;
using DesignPatterns.Bridge.Resources;

namespace DesignPatterns.Bridge.Views
{
    public class LongFormView : View
    {
        public LongFormView(IResource resource) : base(resource)
        {
        }

        public override string GetHtml()
        {
            var html = "<div id=\"large\">";
            var title = "<h1>" + Resource.Title() + "</h1>";
            var image = "<img src=\"" + Resource.Image() + "\" />";
            var snippet = "<p>" + Resource.Snippet() + "</p>";

            return html + title + image + snippet + "</div>";
        }
    }
}


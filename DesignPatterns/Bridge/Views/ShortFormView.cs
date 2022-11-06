using DesignPatterns.Bridge.Resources;

namespace DesignPatterns.Bridge.Views
{
    public class ShortFormView : View
    {
        public ShortFormView(IResource resource) : base(resource)
        {
        }

        public override string GetHtml()
        {
            var html = "<div id=\"small\">";
            var title = "<h1>" + Resource.Title() + "</h1>";
            var image = "<img src=\"" + Resource.Image() + "\" />";
            var snippet = "<p>" + Resource.Snippet() + "</p>";

            return html + title + image + snippet + "</div>";
        }
    }
}


using DesignPatterns.Bridge.Resources;

namespace DesignPatterns.Bridge.Views
{
    // Abstraction Hierarchy
    public abstract class View
    {
        protected IResource Resource;

        public View(IResource resource)
        {
            Resource = resource;
        }

        public abstract string GetHtml();
    }
}


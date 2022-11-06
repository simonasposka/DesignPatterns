namespace DesignPatterns.Bridge.Resources
{
    public class BookResource : IResource
    {
        protected Book Book;
        
        public BookResource(Book book)
        {
            Book = book;
        }

        public string Image()
        {
            return Book.Image;
        }

        public string Snippet()
        {
            return Book.Summary;
        }

        public string Title()
        {
            return Book.Title;
        }
    }
}


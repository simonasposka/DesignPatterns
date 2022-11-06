namespace DesignPatterns.Bridge
{
    public class Book
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Image { get; set; }

        public Book(string title, string summary, string img)
        {
            Title = title;
            Summary = summary;
            Image = img;
        }
    }
}


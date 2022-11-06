using System;
namespace DesignPatterns.Bridge.Resources
{
    public class ArtistResource : IResource
    {
        protected Artist Artist;
        
        public ArtistResource(Artist artist)
        {
            Artist = artist;
        }

        public string Image()
        {
            return Artist.Image;
        }

        public string Snippet()
        {
            return Artist.Bio;
        }

        public string Title()
        {
            return Artist.FirstName + " " + Artist.LastName;
        }
    }
}


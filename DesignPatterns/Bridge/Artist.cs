using System;
namespace DesignPatterns.Bridge
{
    public class Artist
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }

        public Artist(string firstName, string lastName, string bio, string img)
        {
            FirstName = firstName;
            LastName = lastName;
            Bio = bio;
            Image = img;
        }
    }
}


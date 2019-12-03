using System;

namespace RandomFilesTest.Model
{
    public class Plays
    {
        public int Id { get; set; }
        public string VideoName { get; set; }
        public DateTime LastPlayed { get; set; }
        public int NumberOfPlays { get; set; }
    }
}
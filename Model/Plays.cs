using System;
using SQLite;

namespace RandomFilesTest.Model
{
    public class Plays
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Indexed]
        public string VideoName { get; set; }
        public DateTime LastPlayed { get; set; }
        public int NumberOfPlays { get; set; }
    }
}
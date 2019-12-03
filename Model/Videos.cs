using System;
using SQLite;

namespace RandomFilesTest.Model
{
    public class Videos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string VideoName { get; set; }
        public string VideoPath { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
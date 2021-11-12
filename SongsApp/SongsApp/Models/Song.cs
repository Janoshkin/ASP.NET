using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongsApp.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string SongTitle { get; set; }
        public string SongLyrics { get; set; }

        public Song()
        {

        }

    }
}

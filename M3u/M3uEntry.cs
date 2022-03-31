using System;
using System.Collections.Generic;

namespace M3u
{
    public class M3uEntry
    {
        public int Duration { get; set; } = 0;
        public string Title { get; set; } = "";
        public string Path { get; set; } = "";

        public string Group { get; set; } = "";

        public Dictionary<string, string> attributes = new Dictionary<string, string>();

    }
}
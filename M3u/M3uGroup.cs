using System;
using System.Collections.Generic;

namespace M3u
{
    public class M3uGroup
    {
        public string Name { get; set; } = "";

        public List<M3uEntry> entries = new List<M3uEntry>();
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace M3u
{
    public class M3uFile
    {
        public List<M3uEntry> entries = new List<M3uEntry>();
        public List<M3uGroup> groups = new List<M3uGroup>();

        private string _fileName = null;

        public M3uFile(string fileName)
        {
            _fileName = fileName;
        }

        public void Load()
        {
            entries.Clear();

            string[] lines = File.ReadAllLines(_fileName);

            if (lines == null || lines.Length == 0)
                throw new Exception("M3u file is empty");

            if (!lines[0].StartsWith("#EXTM3U"))
                throw new Exception("M3U header is missing.");

            for (int i = 1; i < lines.Length; i += 3)
            {
                if (i + 3 >= lines.Length)
                    break;

                var entry = new M3uEntry();

                var lineInf = lines[i];
                var lineGpr = lines[i + 1];
                var linePath = lines[i + 2];

                var split = lineInf.Replace("#EXTINF:", "").Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var splitAttr = split[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!int.TryParse(splitAttr[0], out int seconds))
                    throw new Exception("Invalid track duration.");

                entry.Title = split.Last();
                entry.Duration = seconds;

                entry.Path = linePath;
                entry.Group = lineGpr.Replace("#EXTGRP:", "");

                for (int j = 1; j < splitAttr.Length; j++)
                {
                    var items = splitAttr[j].Split(new[] { '=', '"' }, StringSplitOptions.RemoveEmptyEntries);

                    if (items.Length != 2)
                        throw new Exception("Invalid attributes duration.");

                    entry.attributes[items[0]] = items[1];
                }

                entries.Add(entry);
            }
        }

        public void Save()
        {
            SaveAs(_fileName);
        }

        public void SaveAs(string fileName)
        {
            using (var writer = new StreamWriter(fileName))
            {
                writer.WriteLine("#EXTM3U");

                foreach (var group in groups)
                {
                    foreach (var entry in group.entries)
                    {
                        var attrList = entry.attributes.Select(x => $"{x.Key}=\"{x.Value}\"");
                        var attrText = string.Join(" ", attrList);
                        writer.WriteLine($"#EXTINF:{entry.Duration} {attrText},{entry.Title}");
                        writer.WriteLine($"#EXTGRP:{group.Name}");
                        writer.WriteLine(entry.Path);
                    }
                }
            }
        }

        public void GroupEntries()
        {
            var dictionary = new Dictionary<string, List<M3uEntry>>();

            foreach (var entry in entries)
            {
                if (!dictionary.ContainsKey(entry.Group))
                    dictionary[entry.Group] = new List<M3uEntry>();

                dictionary[entry.Group].Add(entry);
            }

            foreach (var item in dictionary)
            {
                var group = new M3uGroup
                {
                    Name = item.Key,
                    entries = item.Value
                };

                groups.Add(group);
            }
        }
    }
}
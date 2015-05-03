﻿using MarkdownApp.Languages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace MarkdownApp.Files
{
    public class NewFile : IDataItem
    {
        private Languages.SupportedLanguage lang;

        [JsonIgnore]
        public string Name { get; set; }

        [JsonIgnore]
        public string Color { get; set; }

        [JsonIgnore]
        public string[] FileExtensions { get; set; }

        [JsonIgnore]
        public FileType FileType { get; set; }

        public NewFile(Languages.SupportedLanguage lang)
        {
            Name = lang.Title;
            Color = lang.Color;
            FileExtensions = lang.Extensions;
            FileType = lang.FileType;
        }

        [JsonIgnore]
        public string UniqueId { get { return "new:" + string.Join(",", FileExtensions); } }
        [JsonIgnore]
        public string Title { get { return Name; } }
        [JsonIgnore]
        public string Subtitle { get { return string.Join(", ", FileExtensions.Select(e => "\"" + e + "\"")); } }
        [JsonIgnore]
        public string Description { get { return ""; } }
        [JsonIgnore]
        public string ImagePath { get { return ""; } }
        [JsonIgnore]
        public string Content { get { return ""; } }
        [JsonIgnore]
        public string BackgroundColor { get { return Color; } }

        public override string ToString()
        {
            return this.UniqueId;
        }
    }
}

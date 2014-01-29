using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiContrib.CollectionJson
{
    public class Link
    {
        public string Rel { get; set; }
        public Uri Href { get; set; }
        public string Prompt { get; set; }
        public string Render { get; set; }

        /// <summary>
        /// Model Extension https://github.com/collection-json/extensions/blob/master/model.md
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Inline Extension Support https://github.com/collection-json/extensions/blob/master/inline.md
        /// </summary>
        public bool Inline { get; set; }

        /// <summary>
        /// Inline Extension Support https://github.com/collection-json/extensions/blob/master/inline.md
        /// </summary>
        public long Length { get; set; }
    }
}

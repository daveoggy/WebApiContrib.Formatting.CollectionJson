using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiContrib.CollectionJson
{
    public class Collection
    {
        public Collection()
        {
            Links = new List<Link>();
            Items = new List<Item>();
            Queries = new List<Query>();
            Template = new Template();
            Inline = new Dictionary<String, IReadDocument>();
        }

        public string Version { get; set; }
        public Uri Href { get; set; }
        public IList<Link> Links { get; private set; }
        public IList<Item> Items { get; private set; }
        public IList<Query> Queries { get; private set; }
        public Template Template { get; private set; }

        /// <summary>
        /// OData Quert Options Extension https://github.com/daveoggy/collection-json/blob/master/extensions/odata-query-options.md
        /// </summary>
        public OData OData { get; set; }

        /// <summary>
        /// Inline Extension https://github.com/collection-json/extensions/blob/master/inline.md
        /// </summary>
        public IDictionary<String, IReadDocument> Inline { get; set; }

        #region ShouldSerialize Methods for Json.Net

        public bool ShouldSerializeTemplate()
        {
            return Template.Data.Any();
        }

        public bool ShouldSerializeLinks()
        {
            return Links.Any();
        }

        public bool ShouldSerializeQueries()
        {
            return Queries.Any();
        }

        public bool ShouldSerializeInline()
        {
            return Inline.Any();
        }

        public bool ShouldSerializeOData()
        {
            return OData != null;
        }

        public virtual bool ShouldSerializeItems()
        {
            return Items.Any();
        }

        #endregion
    }

    public class Collection<T> : Collection
    {
        public Collection()
        {
            Items = new List<Item<T>>();
        }
        public new IList<Item<T>> Items { get; private set; }

        public override bool ShouldSerializeItems()
        {
            return Items.Any();
        }
    }
}

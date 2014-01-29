using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApiContrib.CollectionJson
{
    public class Collection : Collection<object>
    {
    }

    public class Collection<T>
    {
        public Collection()
        {
            Links = new List<Link>();
            Items = new List<Item<T>>();
            Queries = new List<Query>();
            Template = new Template();
        }

        public string Version { get; set; }
        public Uri Href { get; set; }
        public IList<Link> Links { get; private set; }
        public IList<Item<T>> Items { get; private set; }
        public IList<Query> Queries { get; private set; }
        public Template Template { get; private set; }
    }
}

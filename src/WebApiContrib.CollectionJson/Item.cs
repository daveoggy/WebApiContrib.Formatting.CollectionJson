using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApiContrib.CollectionJson
{
    public class Item
    {
        public Item()
        {
            Data = new List<Data>();
            Links = new List<Link>();
        }

        public Uri Href { get; set; }
        public IList<Data> Data { get; private set; }
        public IList<Link> Links { get; private set; }

        #region ShouldSerialize Methods for Json.Net

        public bool ShouldSerializeData()
        {
            return Data.Any();
        }

        public bool ShouldSerializeLinks()
        {
            return Links.Any();
        }

        #endregion
    }

    public class Item<T> : Item
    {
        public T Raw { get; set; }

        #region ShouldSerialize Methods for Json.Net

        public bool ShouldSerializeRaw()
        {
            return true;
        }

        #endregion
    }
}

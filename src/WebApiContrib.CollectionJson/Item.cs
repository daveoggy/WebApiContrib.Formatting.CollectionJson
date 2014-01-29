﻿using System;
using System.Collections.Generic;

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
    }

    public class Item<T> : Item
    {
        public T Raw { get; set; }
    }
}

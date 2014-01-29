using System;
using System.Collections.Generic;

namespace WebApiContrib.CollectionJson
{
    public class OData
    {
        public OData()
        {
            Data = new List<Data>();
            ODataOptions = new List<ODataOption>();
        }

        public Uri Href { get; set; }
        public IList<Data> Data { get; set; }
        public IList<ODataOption> ODataOptions { get; set; }
    }
}
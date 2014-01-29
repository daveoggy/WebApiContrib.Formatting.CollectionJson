using System.Collections.Generic;

namespace WebApiContrib.CollectionJson
{
    public class ODataOption
    {
        public string Option { get; set; }
        public bool Enabled { get; set; }
        public IList<string> Operations { get; set; }
    }
}
using System.Collections.Generic;

namespace WebApiContrib.CollectionJson
{
    public class ODataOption
    {
        public ODataOption()
        {
            Operations = new List<string>();
        }

        public string Option { get; set; }
        public bool Enabled { get; set; }
        public IList<string> Operations { get; set; }
    }
}
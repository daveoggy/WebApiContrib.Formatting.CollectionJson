using System.Collections.Generic;

namespace WebApiContrib.CollectionJson
{
    public class Data
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Prompt { get; set; }
        public IList<ODataOption> ODataOptions { get; set; }
    }
}

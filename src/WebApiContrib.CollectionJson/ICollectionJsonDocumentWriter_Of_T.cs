using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Configuration;
using System.Text;

namespace WebApiContrib.CollectionJson
{
    public interface ICollectionJsonDocumentWriter<TItem>
    {
        IReadDocument Write(IEnumerable<TItem> data);
        IReadDocument Write(IEnumerable<TItem> data, CollectionJsonWriteSettings collectionJsonDocumentWriterSettings);
    }

    public class CollectionJsonWriteSettings
    {
        private static CollectionJsonWriteSettings _defaults = new CollectionJsonWriteSettings
        {
            IncludeInline = false,
            IncludeOData = true,
            IncludeItems = true,
            IncludeLinks = true,
            IncludeQueries = true,
            IncludeTemplate = true,
            ItemWriteSettings = new ItemWriterSettings
            {
                IncludeLinks = true,
                IncludeData = true,
                IncludeRaw = false
            }
        };

        public static CollectionJsonWriteSettings DefaultSettings
        {
            get { return _defaults; }
        }

        public bool IncludeLinks { get; set; }
        public bool IncludeItems { get; set; }
        public bool IncludeQueries { get; set; }
        public bool IncludeTemplate { get; set; }
        public bool IncludeOData { get; set; }
        public bool IncludeInline { get; set; }

        public ItemWriterSettings ItemWriteSettings { get; set; }
    }

    public class ItemWriterSettings
    {
        public bool IncludeData { get; set; }
        public bool IncludeLinks { get; set; }
        public bool IncludeRaw { get; set; }
    }
}

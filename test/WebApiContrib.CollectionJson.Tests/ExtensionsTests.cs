using System.Collections.Generic;
using System.Linq;
using Xunit;
using Should;

namespace WebApiContrib.CollectionJson.Tests
{
    using Newtonsoft.Json;

    public class ExtensionsTests
    {
        [Fact]
        public void WhenRetrievingLinkByRelAndLinkIsPresentShouldReturnIt()
        {
            var links = new List<Link>
                {
                    new Link {Rel = "Foo"},
                    new Link {Rel = "Bar"}
                };

            links.GetLinksByRel("Foo").Count(l=>l.Rel == "Foo").ShouldEqual(1);
        }

        [Fact]
        public void WhenRetrievingDataElementByNameAndDataIsPresentShouldReturnIt()
        {
            var data = new List<Data>
                {
                    new Data {Name = "Foo"},
                    new Data {Name = "Bar"}
                };

            data.GetDataByName("Foo").Name.ShouldEqual("Foo");
        }

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
        }

        [Fact]
        public void WhenSerializingDeserializingItemShouldProperlyInflateType()
        {
            var c = new Collection<Person>();

            c.Items.Add(new Item<Person> { Raw = new Person { Address = "123 Example Ln", Id = 1, Name = "Patient1" } });

            var serialized = JsonConvert.SerializeObject(c);

            var unserialized = JsonConvert.DeserializeObject<Collection<Person>>(serialized);

            unserialized.Items.First().Raw.ShouldBeType<Person>();
        }
    }
}

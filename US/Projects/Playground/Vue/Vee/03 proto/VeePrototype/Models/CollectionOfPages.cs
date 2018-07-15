using System.Collections.Generic;

namespace VeePrototype.Models
{
    public class CollectionOfPages
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Page> Pages { get; set; }
    }
}
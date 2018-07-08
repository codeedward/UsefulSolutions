using System.Collections.Generic;

namespace VeePrototype.Models
{
    public class Section
    {
        public string Title { get; set; }
        public List<Question> Questions { get; set; }
    }
}
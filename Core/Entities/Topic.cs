using System.Collections.Generic;

namespace Core.Entities
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        public User User { get; set; } = new User();
        public List<Word> Words { get; set; } = new List<Word>();
    }
}

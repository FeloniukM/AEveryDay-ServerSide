using Core.Interfaces;

namespace Core.Entities
{
    public class Word : IBaseEntity
    {
        public int WordId { get; set; }
        public string EngWord { get; set; }
        public string Transcription { get; set; }
        public string Translation { get; set; }
        public int State { get; set; }

        public Topic Topic { get; set; } = new Topic();
    }
}

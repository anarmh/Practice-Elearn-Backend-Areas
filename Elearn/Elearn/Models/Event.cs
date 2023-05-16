namespace Elearn.Models
{
    public class Event:BaseEntity
    {
        public string EventDay { get; set; }
        public string EventMonth { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
    }
}

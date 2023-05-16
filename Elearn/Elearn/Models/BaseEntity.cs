namespace Elearn.Models
{
    public abstract class BaseEntity
    {
        public int id { get; set; }
        public bool SoftDelete { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}

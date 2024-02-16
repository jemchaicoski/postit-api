namespace Postit_webapp.Models
{
    public class Postit
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Text { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsFinished { get; set; } = false;
        public bool IsFavorite { get; set; } = false;
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;
    }
}
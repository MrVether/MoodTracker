namespace MoodTracker.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime dateTime { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}

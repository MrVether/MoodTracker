namespace MoodTracker.Models
{
    public class TalkTherapy
    {
        public int Id { get; set; }
        public bool occurs { get; set; }
        public DateTime dateTime { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}

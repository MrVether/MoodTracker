namespace MoodTracker.Models
{
    public class SleepHour
    {
        public int Id { get; set; }
        public int Hours  { get; set; }
        public DateTime dateTime { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}

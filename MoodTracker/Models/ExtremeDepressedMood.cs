namespace MoodTracker.Models
{
    public class ExtremeDepressedMood
    {
        public int Id { get; set; }
        public enum Scale
        {
            None = 0,
            Mild = 1,
            Moderate = 2,
            Severe = 3,
            Extreme = 4
        }
        public DateTime dateTime { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}

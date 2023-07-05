namespace MoodTracker.Models
{
    public class Medication
    {
        public int Id { get; set; }
        public string medicationName { get; set; }
        public string medicationDosage { get; set; }
        public enum medicationFrequency {
            Daily,
            Weekly,
            Monthly,
            AsNeeded
        }
        public enum timeOfDay {
            Morning,
            Afternoon,
            Evening,
            Night
        }
        public string medicationNotes { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}

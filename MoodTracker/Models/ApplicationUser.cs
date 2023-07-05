using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    public enum weightUnit { lbs, kg }
    public enum temperatureUnit { F, C }
    public bool ToggleDefaultTrackingPoints { get; set; }
    public bool ToggleLogSleep { get; set; }
    public bool ToggleLogIrritability { get; set; }
    public bool ToggleLogTalkTherapy { get; set; }
    public bool ToggleLogDepressedMood { get; set; }
    public bool ToggleLogAnxiety { get; set; }
    public bool ToggleLogMenstrualCycle { get; set; }
    public bool ToggleLogElevatedMood { get; set; }
    public bool ToggleLogPsychoticSymptoms { get; set; }
    public bool ToggleLogWeight { get; set; }
}

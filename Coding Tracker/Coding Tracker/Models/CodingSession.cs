using Coding_Tracker;

internal class CodingSession
{
    public int Id { get; set; }
    public DateTime StartTime { get; private set; }
    public DateTime EndTime { get; private set; }

    public TimeSpan Duration => EndTime - StartTime;

    public static CodingSession Create(DateTime startTime, DateTime endTime)
    {
        if (endTime <= startTime) 
        {
            throw new ArgumentException("End time must be after start time.");
        }


        return new CodingSession
        {
            StartTime = startTime,
            EndTime = endTime
        };
    }
}

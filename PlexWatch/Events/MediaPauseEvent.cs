using PlexWatch.Enums;

namespace PlexWatch.Events;

public class MediaPauseEvent : BaseEvent
{
    public string UserName { get; set; }
    public string MediaTitle { get; set; }
    public MediaType MediaType { get; set; }
    public string RatingKey { get; set; }
}

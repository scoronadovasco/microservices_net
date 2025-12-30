namespace Common.Core.Events;

public class TicketCreateEvent : BaseEvent
{
    public TicketCreateEvent() : base(nameof(TicketCreateEvent))
    {
    }

    public required string UserName { get; set; }
    public string? TypeError { get; set; }

    public required string DetailError { get; set; }
}
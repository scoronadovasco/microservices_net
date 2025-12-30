using Common.Core.Events;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using MongoDB.Bson.Serialization.Attributes;
using Ticketing.Command.Domain.Common;

namespace Ticketing.Command;

[BsonCollection("eventStores")]
public class EventModel : Document
{
    [BsonElement("timestamp")]
    public DateTime Timestamp { get; set; }

    [BsonElement("aggregateIdentifier")]
    public required string aggregateIdentifier { get; set; }

    [BsonElement("aggregateType")]
    public string AggregateType { get; set; } = string.Empty;

    [BsonElement("version")]
    public int Version { get; set; }

    [BsonElement("eventType")]
    public string EventType { get; set; } = string.Empty;

    public BaseEvent? EventData { get; set;}
}
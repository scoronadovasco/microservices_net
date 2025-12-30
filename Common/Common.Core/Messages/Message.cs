using MongoDB.Bson.Serialization.Attributes;

namespace Common.Core.Events;

public abstract class Message
{
    public Message()
    {

    }
    [BsonId]
    public string Id { get; set; } = string.Empty;


}
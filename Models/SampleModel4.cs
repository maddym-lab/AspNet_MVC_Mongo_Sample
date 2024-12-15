using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Diagnostics.CodeAnalysis;

namespace AspNet_MVC_Mongo_Sample.Models
{
    public class Strategy
    {
        [BsonElement("strategy_id")]
        public int strategy_id { get; set; }

        [BsonElement("description")]
        public string Description { get; set; } = null!;

        [BsonElement("status")]
        public string status { get; set; } = null!;
    }
}

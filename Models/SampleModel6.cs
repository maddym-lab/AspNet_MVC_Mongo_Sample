using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace AspNet_MVC_Mongo_Sample.Models
{
    public class SampleModel6
    {
        [BsonElement("objective_id")]
        public int objective_id { get; set; }

        [BsonElement("description")]
        public string Description { get; set; } = null!;

        [BsonElement("type")]
        public string type { get; set; } = null!;

        [BsonElement("definition")]
        public string definition { get; set; } = null!;

        [BsonElement("strategies")]
        public List<Strategy> stratgies { get; set; } = null!;
    }
}

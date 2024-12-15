using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace AspNet_MVC_Mongo_Sample.Models
{
    public class SampleModel2
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string SampleModel1_Id { get; set; } = null!;

        [BsonElement("type")]
        public string Type { get; set; } = null!;

        [BsonElement("level")]
        public string Level { get; set; } = null!;
        
        public SampleModel3 Business_Case { get; set; } = null!;

        public string Status { get; set; } = null!;
    }
}

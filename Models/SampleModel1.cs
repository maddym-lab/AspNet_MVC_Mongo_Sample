using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace AspNet_MVC_Mongo_Sample.Models
{
    public class SampleModel1
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("version")]
        public int Version { get; set; } = 1;

        [BsonElement("level")]
        public string Level { get; set; } = null!;

        public string Statement { get; set; } = null!;

        public SampleModel1(string? id, int version, string level, string statement)
        {
            Id = id;
            Version = version;
            Level = level;
            Statement = statement;
        }

        public SampleModel1()
        {
        }

        [BsonElement("Goals")]
        public List<SampleModel5> Goals { get; set; } = null!;       

 
    }
}

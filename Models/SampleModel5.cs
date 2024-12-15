using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel;

namespace AspNet_MVC_Mongo_Sample.Models
{
    public class SampleModel5
    {
        [BsonElement("goal_id")]
        public int goal_id { get; set; }

        [BsonElement("description")]
        public string Description { get; set; } = null!;

        [BsonElement("objectives")]
        public List<SampleModel6> objectives { get; set; } = null!;


    }
}

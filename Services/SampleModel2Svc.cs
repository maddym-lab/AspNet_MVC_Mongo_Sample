using Microsoft.Extensions.Options;
using MongoDB.Driver;
using AspNet_MVC_Mongo_Sample.Models;

namespace AspNet_MVC_Mongo_Sample.Services
{
    public class SampleModel2Svc
    {
        private IMongoCollection<SampleModel2> _sampleModel2Collection;

        public SampleModel2Svc(IMongoClient mongoClient, IConfiguration configuration)
        {
            var databaseName = configuration.GetValue<string>("MongoDbConnection:DatabaseName");
            var sampleModel2Collection = configuration.GetValue<string>("MongoDbConnection:Collections:SampleModel2CollectionName");
            var database = mongoClient.GetDatabase(databaseName);
            _sampleModel2Collection = database.GetCollection<SampleModel2>(sampleModel2Collection);
        }

        public List<SampleModel2> GetProposalList() =>
        _sampleModel2Collection.Find(_ => true).ToList();

        public SampleModel2 Add(SampleModel2 sampleModel2)
        {
            _sampleModel2Collection.InsertOne(sampleModel2);
            return sampleModel2;

        }

    }
}

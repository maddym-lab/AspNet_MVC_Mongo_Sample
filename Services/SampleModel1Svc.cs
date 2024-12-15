using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Collections.Generic;
using AspNet_MVC_Mongo_Sample.Models;

namespace AspNet_MVC_Mongo_Sample.Services
{
    public class SampleModel1Svc
    {
        private IMongoCollection<SampleModel1> _sampleModel1Collection;
        
        public SampleModel1Svc(IMongoClient mongoClient, IConfiguration configuration)
        {
            var databaseName = configuration.GetValue<string>("MongoDbConnection:DatabaseName");
            var sampleModel1Collection = configuration.GetValue<string>("MongoDbConnection:Collections:SampleModel1CollectionName");
            var database = mongoClient.GetDatabase(databaseName);
            _sampleModel1Collection = database.GetCollection<SampleModel1>(sampleModel1Collection);
        }
        
             
        /*
        public SampleModel1Svc(IOptions<MongoDbConnectionSettings> mongoDbSettings)
        {
            var mongoClient = new MongoClient(
                mongoDbSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
            mongoDbSettings.Value.DatabaseName);

            _SampleModel1Collection = mongoDatabase.GetCollection<SampleModel1>(
                mongoDbSettings.Value.BooksCollectionName);
        }
        */

        public async Task<List<SampleModel1>> GetAsync() =>
        await _sampleModel1Collection.Find(_ => true).ToListAsync();

        public List<SampleModel1> GetAll() =>
        _sampleModel1Collection.Find(_ => true).ToList();


        public SampleModel1 AddSampleModel1(SampleModel1 sampleModel1)
        {
            _sampleModel1Collection.InsertOne(sampleModel1);
            return sampleModel1;

        }

    }
}

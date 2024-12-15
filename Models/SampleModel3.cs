using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel;

namespace AspNet_MVC_Mongo_Sample.Models
{
    public class SampleModel3
    {
        public string ProblemStatement { get; set; } = null!;

        public string EconomicAnalysis { get; set; } = null!;

        public string SolutionOptions { get; set; } = null!;

        public string ImplementationApproach { get; set; } = null!;

        public string Status { get; set; } = null!;

    }
}

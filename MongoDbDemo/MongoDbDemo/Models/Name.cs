using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDbDemo.Models
{
    [BsonIgnoreExtraElements]
    public class Name
    {
        [BsonId]
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}

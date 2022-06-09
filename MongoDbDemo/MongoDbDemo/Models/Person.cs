using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDbDemo.Models
{
    public class Person
    {
        [BsonId]
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address Address { get; set; }

        [BsonElement("Birthday")]
        public DateTime DateOfBirth { get; set; }
    }

    
}
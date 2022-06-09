using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

public class MongoDbCRUD
{
    private IMongoDatabase db;

    public MongoDbCRUD(string database)
    {
        var client = new MongoClient();
        db = client.GetDatabase(database);
    }

    public void Insert<T>(string table, T record)
    {
        var collection = db.GetCollection<T>(table);
        collection.InsertOne(record);
    }

    public List<T> GetAll<T>(string table)
    {
        var collection = db.GetCollection<T>(table);

        var result = collection.Find(new BsonDocument()).ToList();

        return result;
    }

    public T GetById<T>(string table, Guid id)
    {
        var collection = db.GetCollection<T>(table);
        var filter = Builders<T>.Filter.Eq("_id", id);

        var result = collection.Find(filter).First();

        return result;
    }

    public T GetByBirthday<T>(string table, DateTime date)
    {
        var collection = db.GetCollection<T>(table);
        var filter = Builders<T>.Filter.Eq("DateOfBirth", date);

        var result = collection.Find(filter).First();

        return result;
    }

    public void Upsert<T>(string table, Guid id, T record)
    {
        var collection = db.GetCollection<T>(table);

        collection.ReplaceOne(
            new BsonDocument("_id", id),
            record,
            new ReplaceOptions() { IsUpsert = true });
    }

    public void Delete<T>(string table, Guid id)
    {
        var collection = db.GetCollection<T>(table);
        var filter = Builders<T>.Filter.Eq("Id", id);

        collection.DeleteOne(filter);
    }
}

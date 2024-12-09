using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MicroserviceProject.Catalog.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}

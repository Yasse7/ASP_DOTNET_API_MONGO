using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApi_Swagger.Models
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id {  get; set; }
        [BsonElement("firstname")]
        public string firstname { get; set; }

        [BsonElement("lastname")]
        public string lastname { get; set; }
        
        [BsonElement("departement")]
        public string departement { get; set; }
        [BsonElement("class")]
        public string classe { get; set; }
        [BsonElement("gender")]
        public int gender { get; set; }
            

    }
}

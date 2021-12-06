using MongoDB.Bson.Serialization.Attributes;

namespace AddressBook

{
    public class Address
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

        public string Id { get; set; }
        public string City { get; set; }
        public string Adres{ get; set; }
        public string Number { get; set; }
       
    }
}

using Microsoft.Extensions.Options;
using MongoDB.Driver;


namespace AddressBook


{
    public class DbClient : IDbClient
    {
        private  IMongoCollection<Address> _addresses;

        public DbClient(IOptions<AddressBookDbConfig> addressbookDbConfig)
        {
            var client = new MongoClient(addressbookDbConfig.Value.Connection_String);
            var database = client.GetDatabase(addressbookDbConfig.Value.Database_Name);
            _addresses = database.GetCollection<Address>(addressbookDbConfig.Value.Addresses_Collection_Name);
        }

        public IMongoCollection<Address> GetAddressesCollection()
        {
            return _addresses;
        }
  
    }
}

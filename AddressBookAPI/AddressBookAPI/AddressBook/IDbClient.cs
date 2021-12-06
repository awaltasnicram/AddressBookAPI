using MongoDB.Driver;


namespace AddressBook


{
    public interface IDbClient
    {
        IMongoCollection<Address> GetAddressesCollection();
    }
}

using MongoDB.Driver;
using System.Collections.Generic;

namespace AddressBook

{
    public class AddressServices : IAddressServices
    {
        private readonly IMongoCollection<Address> _addresses;

        public AddressServices(IDbClient dbClient)
        {
            _addresses = dbClient.GetAddressesCollection();
        }

        public Address AddAddress(Address address)
        {
            _addresses.InsertOne(address);
            return address;
        }

        public void DeleteAddress(string id)
        {
            _addresses.DeleteOne(address => address.Adres == id);
        }

        public Address GetAddress(string id) => _addresses.Find(address => address.Adres == id).First();

        public List<Address> GetAddresses() => _addresses.Find(adress => true).ToList();

        public Address UpdateAddress(Address address)
        {
            GetAddress(address.Adres);
            _addresses.ReplaceOne(a => a.Adres == address.Adres, address);
            return address;
        }

       
    }
}
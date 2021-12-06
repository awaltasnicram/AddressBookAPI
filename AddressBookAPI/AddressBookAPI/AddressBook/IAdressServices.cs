using System.Collections.Generic;

namespace AddressBook

{
    public interface IAddressServices
    {
        List<Address> GetAddresses();
        Address GetAddress(string id);
        Address AddAddress(Address adress);
        void DeleteAddress(string id);
        Address UpdateAddress(Address adress);
    }
}

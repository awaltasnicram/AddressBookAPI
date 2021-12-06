# AddressBookAPI

Do uruchomienia i poprawnego skompilowania pliku potrzeba zainstalować następujące nuggety:
MongoDB.Driver
MongoDB.Bson
NETStandard.Library

Dodatkowo wymagany jest .netcore w wersji 5.0 (bez tego może być problem w odnajdowaniu parametrów i dodawaniu, może być błąd, że parametr będzie mieć wartość 
0 przez co bedzie wyskakiwać błąd)


Do uruchemienia programu używany plik  AddressBookAPI.sln w lokalizacji AddressBookAPI
Po uruchomieniu mamy pusty swagger do którego mozemy przy użyciu metody POST dodać nowy element.
Istnieją 4 stringi: ID CIty Adres oraz Number do ktorych przypisujemy podane przez uzytkownika parametry
Dodane są również metody GET zwracajacy wszystkie parametry jakie dodalismy oraz GET, gdzie mozemy sprawdzic konkretny parametr po numerze Id
Dodatkowo istnieja  metody PUT dzięki któremu możemy dodawac parametry, które można dodać tylko raz(róznica pomiedzy POST jest taka, że PUT nie będzie
duplikować a tym bardziej nadpisywać parametrów ) oraz DELETE, który służy do usuwania parametrów.


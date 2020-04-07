using Database;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;


namespace ObjectWCF
{
    [ServiceContract]
    interface InterfaceItem
    {
        [OperationContract]
        int AddItem(Item item);

        [OperationContract]
        Item GetById(int id);

        [OperationContract]
        void RemoveItem(int id);

        [OperationContract]
        List<Item> GetAllItems();

        [OperationContract]
        string UpdateItem(int id, Item newItem);

        [OperationContract]
        List<Item> FilterItems(FilterModel filter);

    }

    [ServiceContract]
    interface InterfacePerson
    {
        [OperationContract]
        int AddPerson(Person person);

        [OperationContract]
        List<Person> GetPersonsForItem(int id);

        [OperationContract]
        List<string> GetNamePersons();

        [OperationContract]
        int VerifyIfPersonExist(int id, string name);

        [OperationContract]
        void RemovePersons(int id);

        [OperationContract]
        void RemovePerson(Person person);
    }

    [ServiceContract]
    interface IItemPerson: InterfaceItem, InterfacePerson
    {
    }
}

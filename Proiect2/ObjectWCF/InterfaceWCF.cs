using Database;
using System.Linq;
using System.ServiceModel;


namespace ObjectWCF
{
    [ServiceContract]
    interface InterfaceItem
    {
        [OperationContract]
        bool AddItem(Item item);

        [OperationContract]
        Item GetById(int id);

        [OperationContract]
        void RemoveItem(int id);

        [OperationContract]
        IQueryable<Item> GetAllItems();

        [OperationContract]
        string UpdateItem(int id, Item newItem);

        [OperationContract]
        IQueryable<Item> FilterItems(FilterModel filter);

    }

    [ServiceContract]
    interface InterfacePerson
    {
        [OperationContract]
        bool AddPerson(Person person);

        [OperationContract]
        IQueryable<Person> GetPersonsForItem(int id);

        [OperationContract]
        IQueryable<string> GetNamePersons();

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

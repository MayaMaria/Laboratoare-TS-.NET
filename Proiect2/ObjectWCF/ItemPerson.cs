using Database;
using System.Collections.Generic;
using System.Linq;

namespace ObjectWCF
{
    public class ItemPerson : IItemPerson
    {
        public int AddItem(Item item) => item.AddItem();

        public int AddPerson(Person person) => person.AddPerson();


        public List<Item> FilterItems(FilterModel filter)
        {
            Item item = new Item();
            return  item.FilterItems(filter).ToList();
        }

        public List<Item> GetAllItems()
        {
            Item item = new Item();
            return item.GetAllItems();
        }

        public Item GetById(int id)
        {
            Item item = new Item();
            item = item.GetById(id);
            return item;
        }

        public List<string> GetNamePersons()
        {
            Person person = new Person();
            return person.GetNamePersons();
        }

        public List<Person> GetPersonsForItem(int id)
        {
            Person person = new Person();
            return person.GetPersonsForItem(id);

        }

        public void RemoveItem(int id)
        {
            Item item = new Item();
            item.RemoveItem(id);
        }

        public void RemovePerson(Person person)
        {
            Person person_ = new Person();
            person_.RemovePerson(person);
        }

        public void RemovePersons(int id)
        {
            Person person = new Person();
            person.RemovePersons(id);
        }

        public string UpdateItem(int id, Item newItem)
        {
            Item item = new Item();
            return item.UpdateItem(id, newItem);
        }

        public int VerifyIfPersonExist(int id, string name)
        {
            Person person = new Person();
            return person.VerifyIfPersonExist(id, name);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public partial class Item
    {
        public int AddItem()
        {
            using (PhotoModelContainer context = new PhotoModelContainer())
            {
                int bResult = 0;
                if (this.Id_item == 0)
                {
                    var it = context.Entry<Item>(this).State = EntityState.Added;
                    context.SaveChanges(); bResult = this.Id_item;
                }
                return bResult;
            }

        }

        public Item GetById(int id)
        {
            using (PhotoModelContainer context = new PhotoModelContainer())
            {
                return context.Items.SingleOrDefault(item => item.Id_item == id);
            }
        }


        public void RemoveItem(int idItem)
        {
            using (PhotoModelContainer context = new PhotoModelContainer())
            {
                Person person = new Person();
                var result = context.Items.SingleOrDefault(item => item.Id_item == idItem);
                if (result != null)
                {
                    person.RemovePersons(idItem);
                    context.Items.Remove(result);
                    context.SaveChanges();
                }
            }
        }

        public List<Item> GetAllItems()
        {
            Person person = new Person();
            using (PhotoModelContainer context = new PhotoModelContainer())
            {
                var items = context.Items;

                foreach (var item in items)
                {
                    item.People = person.GetPersonsForItem(item.Id_item).ToList();

                }
                return items.ToList();
            }
        }

        public string UpdateItem(int id, Item newItem)
        {
            using (PhotoModelContainer context = new PhotoModelContainer())
            {
                var result = context.Items.First(item => item.Id_item == id);
                result.Description = newItem.Description;
                result.Event = newItem.Event;
                result.Date_created = newItem.Date_created;
                result.Landscape = newItem.Landscape;
                result.Country = newItem.Country;
                try
                {
                    context.SaveChanges();
                    return "Updated successfully";
                }
                catch
                {
                    return "Updated not successful. Try again";
                }
            }
        }

        public List<Item> FilterItems(FilterModel filter)
        {
            using (PhotoModelContainer context = new PhotoModelContainer())
            {
                var items = context.Items.AsQueryable();
                var persons = context.People.AsQueryable();

                if (filter.Type != "")
                    items = items.Where(item => item.Type == filter.Type);
                if (filter.Event != "")
                    items = items.Where(item => item.Event == filter.Event);
                if (filter.Landscape != "")
                    items = items.Where(item => item.Landscape == filter.Landscape);
                if (filter.Country != "")
                    items = items.Where(item => item.Country == filter.Country);
                if (filter.Year != null)
                    items = items.Where(item => item.Date_created.Year == filter.Year);

                List<Person> personsList = new List<Person>();
                
                foreach (var person in filter.Persons)
                {
                    var resultPerson = persons.Where(p => p.Name == person);
                    foreach (var item in resultPerson)
                    {
                        personsList.Add(item);
                    }
                }

                List<Item> final_items = new List<Item>();
                foreach (var person in personsList)
                {
                    var resultItems = items.Where(item => item.Id_item == person.Id_item);
                    foreach (var item in resultItems)
                    {
                        if (final_items.Exists(i => i == item) == false)
                            final_items.Add(item);
                    }
                }

                if (final_items.Count != 0)
                    items = final_items.AsQueryable();
                return items.ToList();
            }
        }
    }

    public partial class Person
    {
        public int AddPerson()
        {
            using (PhotoModelContainer context = new PhotoModelContainer())
            {
                int bResult = 0;
                if (this.Id_person == 0)
                {
                    var it = context.Entry<Person>(this).State = EntityState.Added;
                    context.SaveChanges(); bResult = this.Id_person;
                }
                return bResult;
            }

        }

        public List<Person> GetPersonsForItem(int id)
        {
            using (PhotoModelContainer context = new PhotoModelContainer())
            {
                return context.People.Where(person => person.Id_item == id).ToList();
            }
        }

        public int VerifyIfPersonExist(int id, string name)
        {
            using (PhotoModelContainer context = new PhotoModelContainer())
            {
                return context.People
                     .Where(person => person.Id_item == id)
                     .Where(p => p.Name == name)
                     .Count();
            }
        }


        public List<string> GetNamePersons()
        {
            using (PhotoModelContainer context = new PhotoModelContainer())
            {
                return context.People.Select(person => person.Name).Distinct().ToList();
            }
        }

        public void RemovePersons(int id)
        {
            using (PhotoModelContainer context = new PhotoModelContainer())
            {
                var persons = GetPersonsForItem(id);
                foreach (var person in persons)
                {
                    context.People.Attach(person);
                    context.People.Remove(person);
                }
                context.SaveChanges();
            }
        }

        public void RemovePerson(Person person)
        {
            using (PhotoModelContainer context = new PhotoModelContainer())
            {
                context.People.Remove(person);
                context.SaveChanges();
            }
        }

    }
}
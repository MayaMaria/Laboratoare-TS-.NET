using EF_codefirst.Context;
using EF_codefirst.Models;
using System;

namespace Code_first_example
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Test Model Code First");
            TestDatabase();
        }

        static void TestDatabase()
        {
            using (PhotosContext context = new PhotosContext())
            {
                Person person = new Person()
                {
                    gender = "Male",
                    name = "Test Name"
                };

                Item item = new Item()
                {
                    type = "type test",
                    description = "description test",
                    path = "path test",
                    event_ = "event test",
                    landscape = "test landscape",
                    country = "test country",
                    date_created = DateTime.Now
                };

                context.Items.Add(item);
                context.Persons.Add(person);
                context.SaveChanges();

                var items = context.Items;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.description, x.path);
                var persons = context.Persons;
                foreach (var p in persons)
                    Console.WriteLine("{0} {1}", p.id_person, p.name);

            }
        }
    }
}

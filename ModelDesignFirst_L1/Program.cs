using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            TestPerson();
            Console.ReadKey();
            Console.WriteLine("TestOneToMany");
            TesTOneToMany();
        }
        static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                Console.WriteLine("Enter first name");
                var firstName = Console.ReadLine();
                Console.WriteLine("Enter last name");
                var lastName = Console.ReadLine();
                Console.WriteLine("Enter middle name");
                var middleName = Console.ReadLine();
                Console.WriteLine("Enter TelephonNumber");
                var telephonNumber = Console.ReadLine();

                Person p = new Person()
                {
                    FirstName = firstName.ToString(),
                    LastName = lastName.ToString(),
                    MiddleName = middleName.ToString(),
                    TelephonNumber = telephonNumber.ToString()
                };
                context.People.Add(p);
                context.SaveChanges();
                var items = context.People;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
                Console.WriteLine("Press enter to continue");
            }
        }

        static void TesTOneToMany()
        {
            Console.WriteLine("One to many association");

           
            using (Model2Container context =
                     new Model2Container())
            {
                Console.WriteLine("Enter customer name");
                var nameCustomer = Console.ReadLine();
                Console.WriteLine("Enter city for customer");
                var city = Console.ReadLine();
                Customer c = new Customer()
                {
                    Name = nameCustomer,
                    City = city
                };

                Console.WriteLine("Enter totalValue for order1");
                var totalvalue1 = Console.ReadLine();
                Console.WriteLine("Enter totalValue for order2");
                var totalvalue2 = Console.ReadLine();
                Order o1 = new Order()
                {
                    TotalValue = Int32.Parse(totalvalue1),
                    Date = DateTime.Now,
                    Customer = c
                };
                Order o2 = new Order()
                {
                    TotalValue = Int32.Parse(totalvalue2),
                    Date = DateTime.Now,
                    Customer = c
                };
                context.Customers.Add(c);
                context.Orders.Add(o1);
                context.Orders.Add(o2);
                context.SaveChanges();
                var items = context.Customers;
                foreach (var x in items)
                {
                    Console.WriteLine("Customer : {0}, {1}, {2}",
                   x.CustomerId, x.Name, x.City);
                    foreach (var ox in x.Orders)
                        Console.WriteLine("\tOrders: {0}, {1}, {2}",
                       ox.OrderId, ox.Date, ox.TotalValue);
                }
            }
        }

        static void TestManyToMany()
        {
            Console.WriteLine("Test many to many association");

            using (ModelManyToManyContainer context =
                       new ModelManyToManyContainer())
            {
                Album album = new Album()
                {
                    AlbumName = "Test Album"
                };

                Artist artist = new Artist()
                {
                    FirstName = "First Name Artist",
                    LastName = "Last Name Artist"
                };

                context.Albums.Add(album);
                context.Artists.Add(artist);
                context.SaveChanges();

                var artists = context.Artists;
                foreach(var a in artists)
                {
                    Console.WriteLine("Artist: {0} , {1},{2} ", a.ArtistId, a.FirstName, a.LastName);
                }

            }


        }

    }
}

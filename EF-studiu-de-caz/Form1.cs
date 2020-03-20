using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_studiu_de_caz
{
    public partial class Form1 : Form
    {
        ModelSelfReference context = new ModelSelfReference();
        Model_scenariu2 context2 = new Model_scenariu2();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButon_Click(object sender, EventArgs e)
        {
            SelfReference self = new SelfReference()
            {
                Name = nameBox.Text
            };
            context.SelfReferences.Add(self);
            context.SaveChanges();

            var product = new Product
            {
                SKU = 147,
                Description = "Expandable Hydration Pack",
                Price = 19.97M,
                ImageURL = "/pack147.jpg"
            };
            context2.Products.Add(product);
            product = new Product
            {
                SKU = 178,
                Description = "Rugged Ranger Duffel Bag",
                Price = 39.97M,
                ImageURL = "/pack178.jpg"
            };
            context2.Products.Add(product);
            product = new Product
            {
                SKU = 186,
                Description = "Range Field Pack",
                Price = 98.97M,
                ImageURL = "/noimage.jp"
            };
            context2.Products.Add(product);
            product = new Product
            {
                SKU = 202,
                Description = "Small Deployment Back Pack",
                Price = 29.97M,
                ImageURL = "/pack202.jpg"
            };
            context2.Products.Add(product);
            context2.SaveChanges();

            byte[] thumbBits = new byte[100];
            byte[] fullBits = new byte[2000];
            using (var contextPhoto = new PhotoContext())
            {
                var photo = new Photograph
                {
                    Title = "My Dog",
                    ThumbnailBits = thumbBits
                };
                var fullImage = new PhotographFullImage
                {
                    HighResolutionBits = fullBits
                };
                photo.PhotographFullImage = fullImage;
                contextPhoto.Photographs.Add(photo);
                contextPhoto.SaveChanges();
            }

            using (var contextMostenire = new MostenireContext())
            {
                var business = new Business
                {
                    Name = "Corner Dry Cleaning",
                    LicenseNumber = "100x1"
                };
                contextMostenire.businesses.Add(business);
                var retail = new Retail
                {
                    Name = "Shop and Save",
                    LicenseNumber =
                "200C",
                    Address = "101 Main",
                    City = "Anytown",
                    State = "TX",
                    ZIPCode = "76106"
                };
                contextMostenire.businesses.Add(retail);
                var web = new eCommerce
                {
                    Name = "BuyNow.com",
                    LicenseNumber =
                "300AB",
                    URL = "www.buynow.com"
                };
                contextMostenire.businesses.Add(web);
                contextMostenire.SaveChanges();
            }

            using (var contextMostenireI = new Mostenire_ierarhieContext())
            {
                var fte = new FullTimeEmployee
                {
                    FirstName = "Jane",
                    LastName =
                "Doe",
                    Salary = 71500M
                };
                contextMostenireI.Employees.Add(fte);
                fte = new FullTimeEmployee
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Salary = 62500M
                };
                contextMostenireI.Employees.Add(fte);
                var hourly = new HourlyEmployee
                {
                    FirstName = "Tom",
                    LastName =
                "Jones",
                    Wage = 8.75M
                };
                contextMostenireI.Employees.Add(hourly);
                contextMostenireI.SaveChanges();
            }



        }

        private void getAllButton_Click(object sender, EventArgs e)
        {
            var result = context.SelfReferences;
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);

            }

            foreach (var p in context2.Products)
            {
                Console.WriteLine("{0} {1} {2} {3}", p.SKU, p.Description,
                p.Price.ToString("C"), p.ImageURL);
            }

            using (var contextPhoto = new PhotoContext())
            {
                foreach (var photo in contextPhoto.Photographs)
                {
                    Console.WriteLine("Photo: {0}, ThumbnailSize {1} bytes",
                    photo.Title, photo.ThumbnailBits.Length);
                    // explicitly load the "expensive" entity,
                    contextPhoto.Entry(photo)
                    .Reference(p => p.PhotographFullImage).Load();
                    Console.WriteLine("Full Image Size: {0} bytes",
                    photo.PhotographFullImage.HighResolutionBits.Length);
                }
            }
            using (var contextMostenire = new MostenireContext())
            {
                Console.WriteLine("\n--- All Businesses ---");
                foreach (var b in contextMostenire.businesses)
                {
                    Console.WriteLine("{0} (#{1})", b.Name, b.LicenseNumber);
                }
                Console.WriteLine("\n--- Retail Businesses ---");
                foreach (var r in contextMostenire.businesses.OfType<Retail>())
                {
                    Console.WriteLine("{0} (#{1})", r.Name, r.LicenseNumber);
                    Console.WriteLine("{0}", r.Address);
                    Console.WriteLine("{0}, {1} {2}", r.City, r.State, r.ZIPCode);
                }
                Console.WriteLine("\n--- eCommerce Businesses ---");
                foreach (var item in contextMostenire.businesses.OfType<eCommerce>())
                {
                    Console.WriteLine("{0} (#{1})", item.Name, item.LicenseNumber);
                    Console.WriteLine("Online address is: {0}", item.URL);
                }
            }

            using (var contextMostenireI = new Mostenire_ierarhieContext())
{
                Console.WriteLine("--- All Employees ---");
                foreach (var emp in contextMostenireI.Employees)
                {
                    bool fullTime = emp is HourlyEmployee ? false : true;
                    Console.WriteLine("{0} {1} ({2})", emp.FirstName, emp.LastName,
                    fullTime ? "Full Time" : "Hourly");
                }
                Console.WriteLine("--- Full Time ---");
                foreach (var fte in contextMostenireI.Employees.OfType<FullTimeEmployee>())
                {
                    Console.WriteLine("{0} {1}", fte.FirstName, fte.LastName);
                }
                Console.WriteLine("--- Hourly ---");
                foreach (var hourly in contextMostenireI.Employees.OfType<HourlyEmployee>())
                {
                    Console.WriteLine("{0} {1}", hourly.FirstName,
                    hourly.LastName);
                }
            }
        }
    }
}

using RennaisanceWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient
{
    class Program
    {
        static HttpClient client = new HttpClient();


        static void Main(string[] args)
        {
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            // New code:
            client.BaseAddress = new Uri("http://localhost/App/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // Create a new product
                AnnouncementDTO obj = new AnnouncementDTO
                {
                    Id=1,
                    Title = "Evening service",
                    Type = AnnouncementType.WEEKLY.ToString(),
                    EventTime = new DateTime(2017,5,6),
                    UpdatedDate = new DateTime(2017, 5, 6),
                    UpdatedBy = "user",
                    Sermon = "John 1:1",
                    Hymns = "How Great is our God",
                    Host = new UserDTO { FirstName="Newton",LastName="Acho", Phone="1234567890",
                        Email ="emailAddress", UpdatedBy="user", UpdatedDate= new DateTime(2017, 5, 6), Id=1
                    },
                };

                var url = await CreateProductAsync(obj);
                Console.WriteLine($"Created at {url}");

                // Get the product
                obj = await GetProductAsync(url.PathAndQuery);
                             
                // Get the updated product
                obj = await GetProductAsync(url.PathAndQuery);              
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }

        static async Task<AnnouncementDTO> GetProductAsync(string path)
        {
            AnnouncementDTO product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<AnnouncementDTO>();
            }
            return product;
        }

        static async Task<Uri> CreateProductAsync(AnnouncementDTO obj)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("api/Announcement", obj);
            response.EnsureSuccessStatusCode();

            // Return the URI of the created resource.
            return response.Headers.Location;
        }
        
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace API
{
    internal class Program
    {
        /*
        static void Main(string[] args)
        {
            GetReqest("http://localhost:3000/Cart");

            Console.ReadKey();
        } 
        async static void GetReqest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                using(HttpResponseMessage response = await client.GetAsync(url))
                {
                    using(HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        Console.WriteLine(mycontent);
                    }
                }
            }

        }
        */

        static void Main(string[] args)
        {
            try
            {
            using (var client =new HttpClient())
            {
                var endpoint = new Uri("http://localhost:3000/Cart");
                var result = client.GetAsync(endpoint).Result;
                string json = result.Content.ReadAsStringAsync().Result;
                List<ResponseModel> tmp = JsonConvert.DeserializeObject<List<ResponseModel>>(json);
                for(int i = 0; i<tmp.Count; i++)
                {
                    Console.WriteLine(tmp[i].id);
                }
                Console.WriteLine(tmp.Count);
            }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}

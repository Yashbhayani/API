using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public class ResponseModel
    {
        [JsonProperty("Product_id")]
        public int ProductId { get; set; }
        
        [JsonProperty("Productname")]
        public string Name { get; set; }
        
        [JsonProperty("Productfield")]
        public string Field { get; set; }

        [JsonProperty("Productimage")]
        public string image { get; set; }

        [JsonProperty("Productprice")]
        public int Price { get; set; }

        [JsonProperty("User_id")]
        public int Userid { get; set; }

        [JsonProperty("CountProduct")]
        public int Count { get; set; }

        public int id { get; set; }
    }
}

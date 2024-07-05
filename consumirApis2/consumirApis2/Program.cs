using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumirApis2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            var client = new RestClient("https://apiv2.allsportsapi.com");
            var request = new RestRequest("/football/?met=Countries&APIkey=ad1d734557f4af2afe23faf9accbdc44d061617c06072d0713d54d49333f0730", Method.Get);
            RestResponse response =  client.Execute(request);
            //Console.WriteLine(response.Content);

            if (response.IsSuccessStatusCode)
            {
                ListaPaises misPaises = JsonConvert.DeserializeObject<ListaPaises>(response.Content);
                if (!string.IsNullOrEmpty(misPaises.listaPaises.FirstOrDefault().Message))
                {
                    Console.WriteLine(misPaises.listaPaises.FirstOrDefault().Message);
                }
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }



            Console.ReadLine();
        }
    }
}

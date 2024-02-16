using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Extensions;

namespace APITestAutomation
{
    public class PostsPage
    {
        private readonly RestClient _client;

        public PostsPage()
        {
            _client = new RestClient("https://jsonplaceholder.typicode.com");
        }

        public RestResponse GetPosts()
        {
            //creamos un nuevo objeto RestRequest, que representa una solicitud HTTP
            var request = new RestRequest("/posts", Method.Get);

            //ejecutamos la solicitud HTTP utilizando el cliente RestSharp (_client) y pasamos el objeto RestRequest 
            return _client.Execute(request); //El método Execute realiza la solicitud HTTP y devuelve un objeto RestResponse
        }
    }
}

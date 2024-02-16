using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Newtonsoft.Json.Linq;

namespace APITestAutomation.Tests
{
    [TestFixture]
    public class PostsTests
    {
        [Test]
        public void GetPostsTest()
        {
            var postsPage = new PostsPage();
            var response = postsPage.GetPosts();

            // Agrega aquí las aserciones para verificar la respuesta
            Console.WriteLine(response.Content);
            Assert.That(response.IsSuccessful);

           

        }
        [Test]
        public void GetStatusCodeTest()
        {
            var postsPage = new PostsPage();
            var response = postsPage.GetPosts();

            // Agrega aquí las aserciones para verificar la respuesta
            Console.WriteLine(response.Content);
            Console.WriteLine(response.StatusCode);
            // Verifica si la respuesta de la solicitud HTTP fue exitosa (código de estado 200)
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);


        }
        [Test]
        public void GetPostByIdTest()
        {
            var postsPage = new PostsPage();
            string id = "38";
            var response = postsPage.GetPostByID(id);

            // Agrega aquí las aserciones para verificar la respuesta
            Console.WriteLine(response.Content);
            Console.WriteLine(response.StatusCode);
            //obteniendo los campos del response
            var jsonResponse = JObject.Parse(response.Content);

            int idPost = jsonResponse["id"].Value<int>();
            Assert.AreEqual(int.Parse(id), idPost); //Validamos que sea el dato esperado


        }
    }
}

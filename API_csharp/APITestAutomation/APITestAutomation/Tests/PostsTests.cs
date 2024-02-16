using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;



namespace APITestAutomation.Tests
{

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
    }
}

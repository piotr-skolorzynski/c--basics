using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;


namespace FirstProject
{
    class Program
    {
        //creating HTTP client using json placeholders
        static async Task OldMain(string[] args)
        {
            using(var httpClient = new HttpClient()) 
            {
                var result = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");
                var json = await result.Content.ReadAsStringAsync();
                //checking what is in json variable
                //Console.WriteLine(json);

                //deserialize json data to selected type
                var posts = JsonConvert.DeserializeObject<List<Post>>(json);

                //choose selected post and show its properties
                var selectedPost = posts.First(p => p.Id == 30);
                Console.WriteLine(selectedPost.Title);
                Console.WriteLine(selectedPost.Body);

                //change property value of selected
                selectedPost.Title = "test tile";
                selectedPost.Body = "test body";
                Console.WriteLine(selectedPost.Title);
                Console.WriteLine(selectedPost.Body);

                //creating new post and sending to server
                var postJsonContent = new StringContent(JsonConvert.SerializeObject(selectedPost)); //createing body for our Post request
                var postResult = await httpClient.PostAsync("https://jsonplaceholder.typicode.com/posts", postJsonContent); //sending POST request to server


                //other way to create http request
                /*using (var postRequestMessage = 
                    new HttpRequestMessage(HttpMethod.Put, "https://jsonplaceholder.typicode.com/posts"))
                {
                    //adding exemplary request header, you can add as many as you need
                    postRequestMessage.Headers.Add("content-type", "application/json");
                    postRequestMessage.Headers.Add("someheader", "somevalue");

                    //adding Request's body
                    postRequestMessage.Content = postJsonContent; 

                    //sending request to server
                    var post2Result = httpClient.SendAsync(postRequestMessage);
                }*/

                //creating request parameters
                var queryParams = HttpUtility.ParseQueryString(string.Empty);
                //create params
                queryParams["postId"] = "1";
                queryParams["someParam"] = "someValue";
                //format params
                var formattedParams = queryParams.ToString();

                //see paramas
                Console.WriteLine(formattedParams);

            }
        }

    }
}



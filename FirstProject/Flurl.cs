using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;

namespace FirstProject
{
    //alternative solution for Http Requests using Flurl library
    public class Flurl
    {
        //Main method was renamed to OldMain and these below is an alternative using flurl library
        static async Task Main()
        {
            var posts = await "https://jsonplaceholder.typicode.com/posts"
                .GetAsync()
                .ReceiveJson<List<Post>>();

            //to show it is the same list below is copied code from Program.cs
            //choose selected post and show its properties
            var selectedPost = posts.First(p => p.Id == 30);
            Console.WriteLine(selectedPost.Title);
            Console.WriteLine(selectedPost.Body);

            //change property value of selected
            selectedPost.Title = "test tile";
            selectedPost.Body = "test body";
            Console.WriteLine(selectedPost.Title);
            Console.WriteLine(selectedPost.Body);

            //send post request with serialized post to Json format, before that create request headers with annonymous object
            var postResult = await "https://jsonplaceholder.typicode.com/posts"
                .WithHeaders(new
                {
                    //example how to use values with pauze signs
                    some_header = "some-value",
                    header = "value",
                    header2 = "value2"
                }, true)
                //creating query params
                .SetQueryParams(new
                {
                    postId = 1,
                    someVqlue = "value"
                })
                .PostJsonAsync(selectedPost);
            //show server response
            Console.WriteLine($"status code: {postResult.StatusCode} and status message: {postResult.ResponseMessage}");

            //query parameters

            
            
        }
    }
}

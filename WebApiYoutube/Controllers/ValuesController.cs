using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiYoutube.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        public List<SearchResult> Get(string keyword)
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()

            {
                ApiKey = "AIzaSyA6F3R_kIdjAu7s1i7O7DwMxrvtwbpL1J8",
                ApplicationName = this.GetType().ToString()

            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = keyword; // Replace with your search term.
            searchListRequest.MaxResults = 10;

            // Call the search.list method to retrieve results matching the specified query term.

            var searchListResponse = searchListRequest.Execute();
            return searchListResponse.Items.ToList();
        }

       



        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

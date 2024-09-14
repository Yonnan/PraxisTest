using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json;
using PraxisTest.Models;

namespace PraxisTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoryController : ControllerBase
    {
        private readonly ILogger<StoryController> _logger;
        public StoryController(ILogger<StoryController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route("Best N stories")]
        public IEnumerable<Output> Get(int n)
        {
            var URL1 = "https://hacker-news.firebaseio.com/v0/beststories.json";
            WebClient C = new WebClient();
            var Data = C.DownloadString(URL1);

            Data = Data.Trim(new Char[] { '[', ']', ' ' });
            string[] DataArray = Data.Split(',');
            var Array = new List<Output>();
            var OutArray = new List<Output>();

            foreach (var item in DataArray)
            {
                var URL2 = $"https://hacker-news.firebaseio.com/v0/item/{item}.json";
                Data = C.DownloadString(URL2);
                var StoryData = JsonConvert.DeserializeObject<Story>(Data);
                var count = 0;
                foreach (var item2 in StoryData.kids)
                {
                    count++;
                }
                StoryData.CommentsCount = count;

                Array.Add(new Output(StoryData.title, StoryData.url, StoryData.by, StoryData.time, StoryData.score, StoryData.CommentsCount));
            }
            Output tmp;

            for (int i = 0; i < Array.Count; i++)
            {
                for (int j = 0; j < Array.Count - 1; j++)
                {
                    if (Array[j].Score < Array[j + 1].Score)
                    {
                        tmp = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = tmp;
                    }
                }
            }


            for (int i = 0; i < n; i++)
            {
                OutArray.Add(Array[i]);
            }
            return OutArray;
        }
    }
}

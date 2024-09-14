namespace PraxisTest.Models
{
    public class Output
    {
        public Output(string title, string url, string by, int time, int score, int commentsCount)
        {
            this.Title = title;
            this.Uri = url;
            this.PosteBy = by;
            this.Time = time;
            this.Score = score;
            CommentsCount = commentsCount;
        }

        public string Title { get; set; }
        public string Uri { get; set; }
        public string PosteBy { get; set; }
        public int Time { get; set; }
        public int Score { get; set; }
        public int CommentsCount { get; set; }
    }
}

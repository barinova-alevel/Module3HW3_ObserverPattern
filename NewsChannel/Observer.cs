namespace NewsChannel
{
    using System;

    public class Observer
    {
        private readonly News news;

        public Observer(News news)
        {
            this.news = news;
        }

        public void Subscribe()
        {
            this.news.NewsHandler += this.NotifyNews;
        }

        public void UnSubscribe()
        {
            this.news.NewsHandler -= this.NotifyNews;
            this.OptDown();
        }

        private void NotifyNews(object sender, EventArgs e)
        {
            Console.WriteLine("We got some news for you.");
        }

        private void OptDown()
        {
            Console.WriteLine("You are unsubscribed.");
        }
    }
}


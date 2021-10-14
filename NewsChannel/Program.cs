namespace NewsChannel
{
    using System;

    public class Program
    {
       public static void Main(string[] args)
        {
            News news = new News();
            Observer observer1 = new Observer(news);
            Observer observer2 = new Observer(news);
            Observer observer3 = new Observer(news);

            observer1.Subscribe();
            observer2.Subscribe();
            observer3.Subscribe();

            news.NotifySubscribers();

            observer1.UnSubscribe();
            news.NotifySubscribers();

            Console.ReadKey();
        }
    }
}

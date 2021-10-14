namespace NewsChannel
{
    using System;

    public class News
    {
        public event EventHandler NewsHandler;

        public void NotifySubscribers()
        {
            if (this.NewsHandler != null)
            {
                this.NewsHandler(this, EventArgs.Empty);
            }
        }
    }
}

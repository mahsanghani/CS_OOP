using System;
namespace practice.advanced.events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: sending a test message..." + e.Video.Title);
        }
    }
}

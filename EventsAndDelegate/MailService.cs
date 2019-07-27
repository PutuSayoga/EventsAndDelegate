using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegate
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e) // Method yang akan berjalan ketika event ter-trigger
        {
            Console.WriteLine($"MessageService: video \"{e.video.title}\" succes sended through Email");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { title = "Kimi no Nawa" };
            var videoEncoder = new VideoEncoder(); // Publisher
            var mailService = new MailService(); // Subscriber (optional karna bisa buat method langsung di kelas ini)
            var messageService = new MessageService(); // Add new Subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // Mendaftarkan subscriber
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; // Mendaftarkan subscriber baru
            

            videoEncoder.Encode(video);
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}

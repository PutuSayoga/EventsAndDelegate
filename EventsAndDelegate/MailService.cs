using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegate
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e) // Method yang akan berjalan ketika event ter-trigger
        {
            Console.WriteLine("MailService: Email sended");
        }
    }
}

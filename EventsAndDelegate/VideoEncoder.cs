using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EventsAndDelegate
{
    public class VideoEncoder
    {
        // 1. Define the delegate that will be use
        // 2. Define the event base on that delegate
        // 3. Raise the event
        // 4. Call the event method

        public void Encode()
        {
            Console.WriteLine("Encoding Video\nPlease wait a minute...");
            // Act ass testing encode logic
            Thread.Sleep(5000);

            // 4. Call the event method
            OnVideoEncoded();
        }

        // 1. Define the delegate
        public delegate void VideoEncoderEventHandler(object source, EventArgs args);

        // 2. Define the event
        public event VideoEncoderEventHandler VideoEncoded;
        // Pakek past tense yang menandakan event ini akan ditriger saat proses encode video selesai

        // 3. Raise the event
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}

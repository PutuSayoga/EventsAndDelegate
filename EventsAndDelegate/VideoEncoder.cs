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
        // Optional
        // 4. Create custom EventArgs

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video\nPlease wait a minute...");
            // Act ass testing encode logic
            Thread.Sleep(5000);

            // 3. Raise the event
            OnVideoEncoded(video);
        }

        // 1. Define the delegate
        public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);

        // 2. Define the event
        public event VideoEncoderEventHandler VideoEncoded; // Pakek past tense (menandakan event ini akan ditriger saat proses encode video selesai)

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { video = video });
        }

    }

    // 4. Create custom EventArgs
    public class VideoEventArgs : EventArgs
    {
        public Video video { get; set; }
    }
}

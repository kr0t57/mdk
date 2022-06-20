using System;

namespace Task3
{
    public sealed class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayVlc(string fileName)
        {
            Console.WriteLine($"Playing vlc file. Name: {fileName}");
        }

        public void PlayMp4(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}

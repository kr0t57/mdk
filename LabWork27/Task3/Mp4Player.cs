using System;

namespace Task3
{
    public sealed class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayVlc(string fileName)
        {
            throw new NotImplementedException();
        }

        public void PlayMp4(string fileName)
        {
            Console.WriteLine($"Playing Mp4 file. Name: {fileName}");
        }
    }
}

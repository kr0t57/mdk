using System;

namespace Task3
{
    public sealed class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter _mediaAdapter;

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("mp3", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine($"Playing Mp3 file. Name: {fileName}");
            }
            else if (audioType.Equals("vlc", StringComparison.InvariantCultureIgnoreCase) || audioType.Equals("mp4", StringComparison.InvariantCultureIgnoreCase))
            {
                _mediaAdapter = new MediaAdapter(audioType);
                _mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine($"Format not supported: {audioType}");
            }
        }
    }
}

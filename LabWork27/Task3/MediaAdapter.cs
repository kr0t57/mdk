namespace Task3
{
    public sealed class MediaAdapter : IMediaPlayer
    {
        private IAdvancedMediaPlayer _advancedMediaPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType.Equals("vlc", System.StringComparison.InvariantCultureIgnoreCase))
            {
                _advancedMediaPlayer = new VlcPlayer();
            }

            else if (audioType.Equals("mp4", System.StringComparison.InvariantCultureIgnoreCase))
            {
                _advancedMediaPlayer = new Mp4Player();
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc", System.StringComparison.InvariantCultureIgnoreCase))
            {
                _advancedMediaPlayer.PlayVlc(fileName);
            }

            else if (audioType.Equals("mp4", System.StringComparison.InvariantCultureIgnoreCase))
            {
                _advancedMediaPlayer.PlayMp4(fileName);
            }
        }
    }
}

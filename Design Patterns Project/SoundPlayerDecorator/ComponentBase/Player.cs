using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Project.SoundPlayerDecorator.ComponentBase
{
    public abstract class Player
    {
        public WaveOut waveOutEvent = new WaveOut();
        public List<AudioFileReader> fileReaders = new List<AudioFileReader>();

        public abstract void Play(int playPosition);

        public Player()
        {
            waveOutEvent.PlaybackStopped += new EventHandler<StoppedEventArgs>((sender, e) =>
            {
                this.waveOutEvent.Dispose();

            });
        }
    }
}

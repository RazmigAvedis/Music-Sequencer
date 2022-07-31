using Design_Patterns_Project.SoundPlayerDecorator.ComponentBase;
using Design_Patterns_Project.SoundPlayerDecorator.DecoratorBase;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Project.SoundPlayerDecorator.ConcreteDecorator
{
    public class Metronome:AudioPlayerDecorator
    { 
        public Metronome(Player player):base(player)
        {
            Player.fileReaders.Add(new AudioFileReader(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\SoundFiles\Metronome.wav")));//when this decorator is called, a metronome sound will be added to the filereaders to be mixed within the mixing stream
        }

        public override void Play(int playPosition)
        {
            Player.Play(playPosition);
        }
    }
}

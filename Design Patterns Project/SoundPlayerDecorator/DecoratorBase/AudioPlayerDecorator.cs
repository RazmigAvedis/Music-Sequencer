using Design_Patterns_Project.SoundPlayerDecorator.ComponentBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Project.SoundPlayerDecorator.DecoratorBase
{
    public class AudioPlayerDecorator : Player
    {
        protected Player Player;

        public AudioPlayerDecorator(Player player)
        {
            Player = player;
        }
        
        public override void Play(int playPosition)
        {
            Player.Play(playPosition);
        }
    }
}

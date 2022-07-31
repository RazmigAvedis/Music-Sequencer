using Design_Patterns_Project.Channel_Abstract_Factory.Abstract_Product;
using Design_Patterns_Project.MusicPlayState.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Project.Singleton
{
    public sealed class MusicState
    {
        public static volatile MusicState musicState;
        private static object _lockThis = new object();

        private MusicState()
        {
            musicMachine = new MusicMachine();
        }

        public static MusicState GetMusicState()
        {
            if (musicState == null)
            {
                lock (_lockThis)
                {
                    if (musicState == null) musicState = new MusicState();
                }
            }
            return musicState;
        }
        
        public MusicMachine musicMachine { set; get; }

    }

}


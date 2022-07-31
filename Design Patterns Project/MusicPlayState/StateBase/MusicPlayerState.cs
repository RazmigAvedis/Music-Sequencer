using Design_Patterns_Project.MusicPlayState.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Project.MusicPlayState.StateBase
{
    public abstract class MusicPlayerState
    {
        public abstract void PlayButtonPressed(MusicMachine musicMachine,Button playButton);

        public abstract void StopButtonPressed(MusicMachine musicMachine);
        
    }
}
